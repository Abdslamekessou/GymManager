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
    public partial class ucListePersonnes : UserControl
    {
        private static DataTable _dtAllPersonnes = clsPersonne.GetAllPersonnes();

        private DataTable _dtPersonnes = _dtAllPersonnes.DefaultView.ToTable(false, "PersonneID", "Nom", "Prenom", "NumeroTelephone", "Email", "DateDeNaissance", "GendorCaption");


        public ucListePersonnes()
        {
            InitializeComponent();
        }

        private void ucListePersonnes_Load(object sender, EventArgs e)
        {
            dgvPersonnes.DataSource = _dtPersonnes;
        }

    }
}
