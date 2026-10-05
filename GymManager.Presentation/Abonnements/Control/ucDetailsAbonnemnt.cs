using GymManager.Business.GymManager.Business;
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
    public partial class ucDetailsAbonnemnt : UserControl
    {
        private int _abonnementID = -1;
        private clsAbonnement _abonnement;

        public int AbonnementID
        {
            get { return _abonnementID; }
        }

        public clsAbonnement SelectedAbonnementInfo
        {
            get { return _abonnement; }
        }
        public ucDetailsAbonnemnt()
        {
            InitializeComponent();
        }

        public void ResetAbonnementInfo()
        {
            _abonnementID = -1;
            _abonnement = null;

            lblAbonnementID.Text = "ID Abonnement : [???]";
            lblSport.Text = "Sport : [???]";
            lblTypeAbonnement.Text = "Type d'abonnement : [???]";
            lblDuree.Text = "Durée : [???]";
            lblDateDebut.Text = "Date de début : [???]";
            lblDateFin.Text = "Date de fin : [???]";
            lblPrixPaye.Text = "Prix payé : [???]";
            lblNombreSeances.Text = "Nombre de séances : [???]";
            lblStatut.Text = "Statut : [???]";
        }

        public void LoadAbonnementInfo(int abonnementID)
        {
            _abonnementID = abonnementID;
            _abonnement = clsAbonnement.Find(_abonnementID);

            if (_abonnement == null)
            {
                ResetAbonnementInfo();
                MessageBox.Show("Abonnement non trouvé !", "Erreur", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            _FillAbonnementInfo();
        }

        private void _FillAbonnementInfo()
        {
            lblAbonnementID.Text = $"ID Abonnement : {_abonnement.AbonnementID}";
            lblDateDebut.Text = $"Date de début : {_abonnement.DateDebut:dd/MM/yyyy}";
            lblDateFin.Text = $"Date de fin : {_abonnement.DateFin:dd/MM/yyyy}";
            lblPrixPaye.Text = $"Prix payé : {_abonnement.PrixPaye:0.00} DA";
            lblSport.Text = $"Sport : {_abonnement.TypeAbonnementInfo.SportInfo.Nom}";

            switch (_abonnement.EtatAbonnement)
            {
                case 1:
                    lblStatut.Text = "Statut : Actif";
                    break;
                case 2:
                    lblStatut.Text = "Statut : Expiré";
                    break;
                default:
                    lblStatut.Text = "Statut : Inactif";
                    break;
            }

            if (_abonnement.TypeAbonnementInfo != null)
            {
                lblTypeAbonnement.Text = $"Type d'abonnement : {_abonnement.TypeAbonnementInfo.Nom}";
                lblDuree.Text = $"Durée : {_abonnement.TypeAbonnementInfo.DureeEnJour} jours";

                if (_abonnement.TypeAbonnementInfo.NombreDeSeances > 0)
                {
                    lblNombreSeances.Text = $"Nombre de séances : {_abonnement.TypeAbonnementInfo.NombreDeSeances}";
                }
                else
                {
                    lblNombreSeances.Text = "Nombre de séances : Illimité";
                }
            }
        }

    }
}