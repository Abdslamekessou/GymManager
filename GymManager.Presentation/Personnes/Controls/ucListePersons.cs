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
            dgvPersons.DataSource = _dtPersons;

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
    }
}
