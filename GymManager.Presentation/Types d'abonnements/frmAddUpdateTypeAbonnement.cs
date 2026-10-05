
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
    public partial class frmAddUpdateTypeAbonnement : Form
    {

        enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;
        private int _TypeAbonnementID = -1;
        private clsTypeAbonnement _TypeAbonnement;

        public frmAddUpdateTypeAbonnement()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }

        public frmAddUpdateTypeAbonnement(int TypeAbonnement)
        {
            InitializeComponent();

            _TypeAbonnementID = TypeAbonnement;
            _Mode = enMode.Update;
        }

        private void _ResetDefaultValues()
        {

            _FillSportsInComboBox();


            if (_Mode == enMode.AddNew)
            {
                this.Text = "Ajouter un type d'abonnement";
                _TypeAbonnement = new clsTypeAbonnement();
            }
            else
            {
                this.Text = "Modifier un type d'abonnement";
            }


            txtDescription.Text = "";
            txtDureeEnJour.Text = "";
            txtNom.Text = "";
            txtNombreDeSeances.Text = "";
            txtPrix.Text = "";

            cbStatut.SelectedIndex = 0;
            cbSport.SelectedIndex = 0;

            rbLimite.Checked = true;

        }

        private void _FillSportsInComboBox()
        {
            DataTable dtSports = clsSport.GetAllSports();

            foreach (DataRow row in dtSports.Rows)
            {
                cbSport.Items.Add(row["Nom"]);
            }

        }

        private void _LoadData()
        {
            _TypeAbonnement = clsTypeAbonnement.Find(_TypeAbonnementID);

            if (_TypeAbonnement == null)
            {
                MessageBox.Show("No TypeAbonnement with ID = " + _TypeAbonnement, "TypeAbonnement Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }

            txtNom.Text = _TypeAbonnement.Nom;
            cbSport.SelectedIndex = _TypeAbonnement.SportID - 1;


            txtDureeEnJour.Text = _TypeAbonnement.DureeEnJour.ToString();
            txtPrix.Text = $"{_TypeAbonnement.Prix:0}";



            if (_TypeAbonnement.NombreDeSeances == null)
            {
                rbIllimite.Checked = true;
                txtNombreDeSeances.Enabled = false;
            }
            else
            {
                rbLimite.Checked = true;
                txtNombreDeSeances.Text = _TypeAbonnement.NombreDeSeances.ToString();
            }

            txtDescription.Text = _TypeAbonnement.Description.ToString();

            if (_TypeAbonnement.EstActif == true)
            {
                cbStatut.SelectedIndex = 0;
            }
            else
            {
                cbStatut.SelectedIndex = 1;
            }

        }

        private void frmAddUpdateTypeAbonnement_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();

            if (_Mode == enMode.Update)
            {
                _LoadData();
            }

        }

        private void rbLimite_CheckedChanged(object sender, EventArgs e)
        {
            txtNombreDeSeances.Enabled = true;
        }

        private void rbIllimite_CheckedChanged(object sender, EventArgs e)
        {
            txtNombreDeSeances.Enabled = false;
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }


            _TypeAbonnement.Nom = txtNom.Text.Trim();
            _TypeAbonnement.SportID = cbSport.SelectedIndex + 1;
            _TypeAbonnement.DureeEnJour = Convert.ToByte(txtDureeEnJour.Text.Trim());
            _TypeAbonnement.Prix = Convert.ToDecimal(txtPrix.Text.Trim());

            if (rbLimite.Checked)
                _TypeAbonnement.NombreDeSeances = Convert.ToByte(txtNombreDeSeances.Text.Trim());
            else
                _TypeAbonnement.NombreDeSeances = null;

            _TypeAbonnement.Description = txtDescription.Text.Trim();

            if (cbStatut.SelectedIndex == 0)
                _TypeAbonnement.EstActif = true;
            else
                _TypeAbonnement.EstActif = false;

            if (_TypeAbonnement.Save())
            {
                _Mode = enMode.Update;
                this.Text = "Modifier un type d'abonnement";

                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);


        }

        private void ValidateEmptyTextBox(object sender, CancelEventArgs e)
        {
            TextBox Temp = ((TextBox)sender);
            if (string.IsNullOrEmpty(Temp.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(Temp, "This field is required!");
            }
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError(Temp, null);
            }
        }

        private void KeyPressNumber(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
