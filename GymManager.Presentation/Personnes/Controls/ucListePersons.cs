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

        private void ucListePersons_Load(object sender, EventArgs e)
        {
            dgvPersons.DataSource = _dtPersons;

        }
    }
}
