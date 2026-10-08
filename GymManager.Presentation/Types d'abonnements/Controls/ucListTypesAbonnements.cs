using GymManager.Business;
using GymManager.Presentation.Types_d_abonnements;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GymManager.Presentation
{
    public partial class ucListTypesAbonnements : UserControl
    {
        private static DataTable _dtAllTypesAbonnement;

        public ucListTypesAbonnements()
        {
            InitializeComponent();
        }

        private void ucListTypesAbonnements_Load(object sender, EventArgs e)
        {
            _dtAllTypesAbonnement = clsTypeAbonnement.GetAllTypesDabonnements();
            cbFilter.SelectedIndex = 0;
            cbRechercher.SelectedIndex = 0;
            dgvListTypeAbonnement.DataSource = _dtAllTypesAbonnement;
            cbFilter.SelectedIndex = 0;
           

            if (_dtAllTypesAbonnement.Rows.Count > 0)
            {

                dgvListTypeAbonnement.Columns[0].HeaderText = "ID";
                dgvListTypeAbonnement.Columns[0].Width = 60;

                dgvListTypeAbonnement.Columns[1].HeaderText = "Nom";
                dgvListTypeAbonnement.Columns[1].Width = 320;

                dgvListTypeAbonnement.Columns[2].HeaderText = "Sport";
                dgvListTypeAbonnement.Columns[2].Width = 180;

                dgvListTypeAbonnement.Columns[3].HeaderText = "Durée (jours)";
                dgvListTypeAbonnement.Columns[3].Width = 105;

                dgvListTypeAbonnement.Columns[4].HeaderText = "Prix";
                dgvListTypeAbonnement.Columns[4].Width = 145;

                dgvListTypeAbonnement.Columns[5].HeaderText = "Séances";
                dgvListTypeAbonnement.Columns[5].Width = 135;

                dgvListTypeAbonnement.Columns[6].HeaderText = "Statut";
                dgvListTypeAbonnement.Columns[6].Width = 155;


            }

        }

        private void btnAjouterType_Click(object sender, EventArgs e)
        {
            frmAddUpdateTypeAbonnement frm = new frmAddUpdateTypeAbonnement();
            frm.ShowDialog();
            ucListTypesAbonnements_Load(null, null);
        }

        private void voirLesDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvListTypeAbonnement.CurrentRow != null)
            {
                int selectedID = Convert.ToInt32(dgvListTypeAbonnement.CurrentRow.Cells[0].Value);

                frmDetailsTypeAbonnement frmDetails = new frmDetailsTypeAbonnement(selectedID);
                frmDetails.ShowDialog();

                ucListTypesAbonnements_Load(null, null);
            }
        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvListTypeAbonnement.CurrentRow != null)
            {
                int selectedID = Convert.ToInt32(dgvListTypeAbonnement.CurrentRow.Cells[0].Value);

                frmAddUpdateTypeAbonnement frm = new frmAddUpdateTypeAbonnement(selectedID);
                frm.ShowDialog();

                ucListTypesAbonnements_Load(null, null);

            }
        }

        private void désactiverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Êtes-vous sûr de vouloir désactiver ce type d'abonnement",
                "Confirmation de désactivation", MessageBoxButtons.OKCancel,MessageBoxIcon.Information) == DialogResult.OK)
            {
                int selectedID = Convert.ToInt32(dgvListTypeAbonnement.CurrentRow.Cells[0].Value);

                ;

                if(clsTypeAbonnement.DeactivateTypeAbonnement(selectedID))
                {
                    MessageBox.Show("Le type d'abonnement a été désactivé avec succès.", "Succès",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("L'opération a échoué.", "Erreur", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

            }

            ucListTypesAbonnements_Load(null, null);

        }

        private void cbRechercher_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbRechercher.Text == "None")
            {
                txtValeur.Text = "";
                txtValeur.Enabled = false;
                btnRechercher.Enabled = false;
                cbFilter.Enabled = true;

            }

            else
            {
                txtValeur.Text = "";
                txtValeur.Enabled = true;
                cbFilter.Enabled = false;
                btnRechercher.Enabled = true;
                txtValeur.Focus();
            }

            _dtAllTypesAbonnement.DefaultView.RowFilter = "";
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {

            if (txtValeur.Text == "")
            {
                MessageBox.Show("Veuillez saisir une valeur de recherche.", "Champ obligatoire",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string FilterColumn = "";
            //Map Selected Filter to real Column name 
            switch (cbRechercher.Text)
            {
                case "Nom du type d'abonnement":
                    FilterColumn = "Nom";
                    break;

                case "ID Type d'abonnement":
                    FilterColumn = "ID";
                    break;

                default:
                    FilterColumn = "None";
                    break;
            }

            //Reset the filters in case nothing selected or filter value conains nothing.
            if (txtValeur.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtAllTypesAbonnement.DefaultView.RowFilter = "";
                return;
            }


            if (FilterColumn != "Nom")
                //in this case we deal with numbers not string.
                _dtAllTypesAbonnement.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtValeur.Text.Trim());
            else
                _dtAllTypesAbonnement.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtValeur.Text.Trim());

        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilter.Text == "Actif")
            {
                _dtAllTypesAbonnement.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", "Statut", "Actif");
            }

            else if(cbFilter.Text == "InActif")
            {
                _dtAllTypesAbonnement.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", "Statut", "InActif");
            }

            else
            {
                _dtAllTypesAbonnement.DefaultView.RowFilter = "";
            }

            
        }

        private void txtValeur_TextChanged(object sender, EventArgs e)
        {
            if(txtValeur.Text == "")
                _dtAllTypesAbonnement.DefaultView.RowFilter = "";

        }

        private void txtValeur_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbRechercher.Text == "ID Type d'abonnement")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void activerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Êtes-vous sûr de vouloir activer ce type d'abonnement ?",
                "Confirmation d'activation", MessageBoxButtons.OKCancel, 
                MessageBoxIcon.Information) == DialogResult.OK)

            {
                int selectedID = Convert.ToInt32(dgvListTypeAbonnement.CurrentRow.Cells[0].Value);

                if (clsTypeAbonnement.ActivateTypeAbonnement(selectedID))
                {
                    MessageBox.Show("Le type d'abonnement a été activé avec succès.", "Succès",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("L'opération a échoué.", "Erreur", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

                ucListTypesAbonnements_Load(null, null);
            }
        }
    }
}
