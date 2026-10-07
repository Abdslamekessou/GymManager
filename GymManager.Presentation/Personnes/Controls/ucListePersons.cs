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

namespace GymManager.Presentation.Personnes.Controls
{
    public partial class ucListePersons : UserControl
    {
        private static DataTable _dtAllPersons = clsPerson.GetAllPersons();

        private DataTable _dtPersons = _dtAllPersons.DefaultView.ToTable(false, "PersonneID", "Nom", "Prenom", "NumeroTelephone", "Email", "DateDeNaissance", "GendorCaption");


        public ucListePersons()
        {
            InitializeComponent();
        }

        private void _RefreshListPeople()
        {
            _dtAllPersons = clsPerson.GetAllPersons();

            _dtPersons = _dtAllPersons.DefaultView.ToTable(false, "PersonneID", "Nom", "Prenom", "NumeroTelephone", "Email", "DateDeNaissance", "GendorCaption");

            dgvPersons.DataSource = _dtPersons;

            lblRecordsCount.Text = dgvPersons.Rows.Count.ToString();
        }

        private void ucListePersons_Load(object sender, EventArgs e)
        {
            _RefreshListPeople();

            cmbGendor.SelectedIndex = 0;
            cbFilterBy.SelectedIndex = 0;

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddUpdatePerson((int)dgvPersons.CurrentRow.Cells[0].Value);
            frm.ShowDialog();

            _RefreshListPeople();
        }

        private void AddNewtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson frm = new frmAddUpdatePerson();

            frm.ShowDialog();

            _RefreshListPeople();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmShowPersonInfo frm = new frmShowPersonInfo((int)dgvPersons.CurrentRow.Cells[0].Value);
            frm.ShowDialog();

        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson frm = new frmAddUpdatePerson();

            frm.ShowDialog();

            _RefreshListPeople();
        }

        private void _ApplyFilters()
        {
            if (_dtPersons == null)
                return;

            _dtPersons.DefaultView.RowFilter = _GeneratePersonSearchFilter() + " AND " + _GenerateGenderFilter();
        }

        private string _GeneratePersonSearchFilter()
        {
            string filterColumn = "";

            // Map selected filter to real column name
            switch (cbFilterBy.Text)
            {
                case "PersonneID":
                    filterColumn = "PersonneID";
                    break;

                case "Prenom":
                    filterColumn = "Prenom";
                    break;

                case "Nom":
                    filterColumn = "Nom";
                    break;

                case "Numero de Telephone":
                    filterColumn = "NumeroTelephone";
                    break;

                case "Email":
                    filterColumn = "Email";
                    break;

                default:
                    filterColumn = "";
                    break;
            }

            string value = txtFilterValue.Text.Trim();

            if (txtFilterValue.Text.Trim() == "" || filterColumn == "")
                return "1=1";


            if (filterColumn == "PersonneID")
            {
                if (int.TryParse(value, out int id))
                {
                    return string.Format("[{0}] = {1}", filterColumn, id);
                }
                else
                {
                    // invalid numeric filter -> no results
                    return "1=1";
                }

            }


            return string.Format("{0} LIKE '{1}%'", filterColumn, txtFilterValue.Text);

        }

        private string _GenerateGenderFilter()
        {
            if (cmbGendor.SelectedItem.ToString() == "Tous")
            {
                return "1=1";
            }
            else
            {
                return $"[GendorCaption] = '{cmbGendor.Text}'";
            }

        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {

            _ApplyFilters();
            lblRecordsCount.Text = dgvPersons.Rows.Count.ToString();

        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbFilterBy.SelectedItem.ToString() == "Aucun")
            {
                txtFilterValue.Visible = false;
            }
            else
            {
                txtFilterValue.Visible = true;
                txtFilterValue.Text = "";
            }

        }

        private void cmbGendor_SelectedIndexChanged(object sender, EventArgs e)
        {
            _ApplyFilters();
            lblRecordsCount.Text = dgvPersons.Rows.Count.ToString();
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            //we allow number incase person id is selected.
            if (cbFilterBy.Text == "PersonneID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }
    }

}
