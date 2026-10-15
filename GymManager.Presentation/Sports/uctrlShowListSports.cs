using GymManager.Business;
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
            dgvSports.DataSource = _AllSports;
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

        private void supprimmerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
