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

namespace GymManager.Presentation.Abonnements.Control
{
    public partial class ucAbonnementInfo : UserControl
    {

        public clsTypeAbonnement TypeAbonnement;

        public ucAbonnementInfo()
        {
            InitializeComponent();
        }

        private void _FullTypeAbonnementComboBox()
        {
            DataTable dtTypeAbonnement = clsTypeAbonnement.GetAllTypesDabonnements();

            foreach (DataRow row in dtTypeAbonnement.Rows)
            {
                cbTypeAbonnement.Items.Add(row["Nom"]);
            }
        }

        private void _LoadDefaultValues()
        {
            _FullTypeAbonnementComboBox();

            cbTypeAbonnement.SelectedIndex = 0;
            dtpDateDebut.Value = DateTime.Now;
            TypeAbonnement = clsTypeAbonnement.Find(cbTypeAbonnement.SelectedIndex + 1);
            txtPrixPaye.Text = $"{TypeAbonnement.Prix:0}";

            if (TypeAbonnement.EstActif)
                cbStatut.SelectedIndex = 0;
            else
                cbStatut.SelectedIndex = 1;

            txtSport.Text = TypeAbonnement.SportInfo.Nom;

            dtpDateFin.Value = dtpDateDebut.Value.AddDays(TypeAbonnement.DureeEnJour);

            if (TypeAbonnement.NombreDeSeances == null)
                txtNombreSeances.Text = "";
            else
                txtNombreSeances.Text = TypeAbonnement.NombreDeSeances.ToString();

        }

        private void ucAbonnementInfo_Load(object sender, EventArgs e)
        {
            _LoadDefaultValues();
        }

        private void cbTypeAbonnement_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            TypeAbonnement = clsTypeAbonnement.Find(cbTypeAbonnement.SelectedIndex + 1);
            dtpDateDebut.Value = DateTime.Now;

            txtPrixPaye.Text = $"{TypeAbonnement.Prix:0}";

            if (TypeAbonnement.EstActif)
                cbStatut.SelectedIndex = 0;
            else
                cbStatut.SelectedIndex = 1;

            txtSport.Text = TypeAbonnement.SportInfo.Nom;

            dtpDateFin.Value = dtpDateDebut.Value.AddDays(TypeAbonnement.DureeEnJour);

            if (TypeAbonnement.NombreDeSeances == null)
                txtNombreSeances.Text = "";
            else
                txtNombreSeances.Text = TypeAbonnement.NombreDeSeances.ToString();
        }

        private void dtpDateDebut_ValueChanged(object sender, EventArgs e)
        {
            dtpDateFin.Value = dtpDateDebut.Value.AddDays(TypeAbonnement.DureeEnJour);
        }

        private void gbInfoAbonnement_Enter(object sender, EventArgs e)
        {

        }
    }
}
