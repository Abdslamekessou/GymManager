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

namespace GymManager.Presentation.Types_d_abonnements
{
    public partial class frmDetailsTypeAbonnement : Form
    {

        private int _TypeAbonnementID = -1;
        private clsTypeAbonnement _TypeAbonnement;

        public frmDetailsTypeAbonnement(int TypeAbonnementID)
        {
            InitializeComponent();
            _TypeAbonnementID = TypeAbonnementID;
        }

        private void ResetDefaultValues()
        {
            lblNom.Text = "[???]";
            lblSport.Text = "[???]";
            lblDurée.Text = "[???]";
            lblPrix.Text = "[???]";
            lblNombredeséances.Text = "[???]";
            lblStatut.Text = "[???]";
            lblDescription.Text = "[???]";
        }

        private void LoadInfoTypeAbonnement(int TypeAbonnementID)
        {
            if (_TypeAbonnementID == -1)
            {
                ResetDefaultValues();
                return;
            }


            _TypeAbonnement = clsTypeAbonnement.Find(_TypeAbonnementID);

            if (_TypeAbonnement == null)
            {
                ResetDefaultValues();
                MessageBox.Show($"Aucun type d'abonnement trouvé avec l'ID = {_TypeAbonnementID}",
                                "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            lblNom.Text = _TypeAbonnement.Nom;
            lblSport.Text = _TypeAbonnement.SportInfo.Nom;
            lblDurée.Text = $"{_TypeAbonnement.DureeEnJour} jours";
            lblPrix.Text = $"{_TypeAbonnement.Prix:0} DA";


            if (_TypeAbonnement.NombreDeSeances == null)
            {
                lblTypedeséances.Text = "Illimité";
                lblNombredeséances.Text = "Illimité";
            }

            else
            {
                lblTypedeséances.Text = "Limité";
                lblNombredeséances.Text = _TypeAbonnement.NombreDeSeances.ToString();
            }


            lblStatut.Text = _TypeAbonnement.EstActif ? "Actif" : "InActif";
            lblDescription.Text = string.IsNullOrEmpty(_TypeAbonnement.Description) ? "Aucune description" : _TypeAbonnement.Description;
        }

        private void frmDetailsTypeAbonnement_Load(object sender, EventArgs e)
        {
            LoadInfoTypeAbonnement(_TypeAbonnementID);
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
