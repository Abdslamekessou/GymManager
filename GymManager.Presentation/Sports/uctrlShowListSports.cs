using GymManager.Business;
using GymManager.Presentation.Global_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManager.Presentation.Sports
{
    public partial class uctrlShowListSports : UserControl
    {
        DataTable _AllSports = clsSport.GetAllSports();

        public uctrlShowListSports()
        {
            InitializeComponent();
            dgvSports.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dgvSports.DataSource = _AllSports;
            if (clsGlobal.CurrentUser.RoleID != 1)
            {
                btnAdd.Enabled = false;
                btnEdit.Enabled = false;
                dgvSports.Enabled = false;
            }
        }



        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (dgvSports.DataSource is DataTable dt)
            {
                dt.DefaultView.RowFilter =
                    $"Nom LIKE '{txtSearch.Text.Trim().Replace("'", "''").Replace("[", "[[]").Replace("%", "[%]").Replace("*", "[*]")}%'";
            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAjouterModifierTest frm = new frmAjouterModifierTest(-1);
            frm.ShowDialog();
            _AllSports = clsSport.GetAllSports();
            dgvSports.DataSource = _AllSports;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmAjouterModifierTest frm = new frmAjouterModifierTest((int)dgvSports.SelectedRows[0].Cells[0].Value);
            frm.ShowDialog();

            _AllSports = clsSport.GetAllSports();
            dgvSports.DataSource = _AllSports;
        }

        private void AjouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAjouterModifierTest frm = new frmAjouterModifierTest(-1);
            frm.ShowDialog();
            _AllSports = clsSport.GetAllSports();
            dgvSports.DataSource = _AllSports;
        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAjouterModifierTest frm = new frmAjouterModifierTest((int)dgvSports.SelectedRows[0].Cells[0].Value);
            frm.ShowDialog();

            _AllSports = clsSport.GetAllSports();
            dgvSports.DataSource = _AllSports;
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Check if a row is actually selected
            if (dgvSports.SelectedRows.Count > 0)
            {
                // Get the Sport ID and Sport Name from the selected row 
                // (Note: Adjust Cells[1] index if your sport name is in a different column)
                int sportId = (int)dgvSports.SelectedRows[0].Cells[0].Value;
                string sportName = dgvSports.SelectedRows[0].Cells[1].Value.ToString();

                // 1. Ask the user to confirm deletion with a message box showing the sport name
                DialogResult confirmResult = MessageBox.Show(
                    $"Voulez-vous vraiment supprimer le sport \"{sportName}\" ?",
                    "Confirmation de suppression",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirmResult == DialogResult.Yes)
                {
                    // 2. Call the deletion method and check the result
                    bool isDeleted = clsSport.DeletSport(sportId);

                    if (isDeleted)
                    {
                        MessageBox.Show(
                            "le sport a été supprimer",
                            "Succès",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );
                    }
                    else
                    {
                        MessageBox.Show(
                            "le sport ne peut pas etre supprimer car il y a des abonnements qui dépend de ce sport",
                            "Suppression impossible",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );
                    }

                    // 3. Refresh the DataGridView with updated data
                    _AllSports = clsSport.GetAllSports();
                    dgvSports.DataSource = _AllSports;
                }
            }
            else
            {
                MessageBox.Show(
                    "Veuillez sélectionner un sport à supprimer.",
                    "Aucune sélection",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }

        private void tlpMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
