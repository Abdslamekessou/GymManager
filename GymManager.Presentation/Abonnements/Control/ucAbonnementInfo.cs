using GymManager.Business;
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
    public partial class ucAbonnementInfo : UserControl
    {


        public clsTypeAbonnement TypeAbonnement;

        public clsAbonnement AbonnementInfo;

        private bool _isUpdateMode = false;
        public bool IsUpdateMode
        {
            get
            {
                return _isUpdateMode;
            }
            set
            {
                _isUpdateMode = value;
                dtpDateDebut.Enabled = _isUpdateMode ? false : true;
                cbTypeAbonnement.Enabled = _isUpdateMode ? false : true;
            }
        }

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

        public void LoadAbonnementInfoByAbonnementID(int AbonnementID)
        {
            AbonnementInfo = clsAbonnement.Find(AbonnementID);

            if (AbonnementInfo == null)
            {
                MessageBox.Show("No Abonnement with AbonnementID = " + AbonnementID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            TypeAbonnement = clsTypeAbonnement.Find(AbonnementInfo.TypeAbonnementID);
            cbTypeAbonnement.SelectedIndex = TypeAbonnement.TypeAbonnementID - 1;
            dtpDateDebut.Value = AbonnementInfo.DateDebut;
            dtpDateFin.Value = AbonnementInfo.DateFin;
            txtPrixPaye.Text = $"{AbonnementInfo.PrixPaye:0}";
            if (AbonnementInfo.EtatAbonnement == 1)
                cbStatut.SelectedIndex = 0;
            else
                cbStatut.SelectedIndex = 1;
        }

        public bool LoadAbonnementInfoByMemberID(int MemberID)
        {

            AbonnementInfo = clsAbonnement.FindAbonnementByMemberID(MemberID);

            if (AbonnementInfo == null)
            {
                MessageBox.Show("No Abonnement with MemberID = " + MemberID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            TypeAbonnement = clsTypeAbonnement.Find(AbonnementInfo.TypeAbonnementID);
            if (TypeAbonnement == null)
            {
                MessageBox.Show("No TypeAbonnement with TypeAbonnementID = " + AbonnementInfo.TypeAbonnementID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            cbTypeAbonnement.SelectedIndex = TypeAbonnement.TypeAbonnementID - 1;
            dtpDateDebut.Value = AbonnementInfo.DateDebut;
            dtpDateFin.Value = AbonnementInfo.DateFin;
            txtPrixPaye.Text = $"{AbonnementInfo.PrixPaye:0}";

            if (AbonnementInfo.EtatAbonnement == 1)
                cbStatut.SelectedIndex = 0;
            else
                cbStatut.SelectedIndex = 1;

            return true;

        }

        // We use the parameter "UserID" temporary until we have the clsGlobal
        public bool SaveAbonnementInfo(int MemberID , int UserID)
        {
            AbonnementInfo = new clsAbonnement();

            if(MemberID == -1)
            {
                MessageBox.Show("C'est obliger de selectioner une Personne !!!");

                return false;
            }

            if (TypeAbonnement == null)
            {
                MessageBox.Show("Type Abonnement n'est pas valid.");
                return false;

            }

            TypeAbonnement = clsTypeAbonnement.Find(cbTypeAbonnement.SelectedIndex + 1);
            AbonnementInfo.TypeAbonnementID = TypeAbonnement.TypeAbonnementID;
            AbonnementInfo.AdherentID = MemberID;
            AbonnementInfo.DateDebut = dtpDateDebut.Value;
            AbonnementInfo.DateFin = dtpDateFin.Value;

            // We user this temperary , until we the global variable "LogedInUser" which is inside "clsGloabal"
            AbonnementInfo.CreePar = UserID;


            if (decimal.TryParse(txtPrixPaye.Text, out decimal price))
            {
                AbonnementInfo.PrixPaye = price;
            }
            else
            {
                MessageBox.Show("Le Prix Payé n'est pas valid !!!");
                return false;
            }

            if (cbStatut.SelectedItem.ToString() == "Actif")
                AbonnementInfo.EtatAbonnement = 1;
            else
                AbonnementInfo.EtatAbonnement = 0;

                return AbonnementInfo.Save();
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
