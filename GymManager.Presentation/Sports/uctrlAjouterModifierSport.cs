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
    public partial class uctrlAjouterModifierSport : UserControl
    {
        enum enMode { enAddNew = 0, enUpdate = 1 }
        enMode _Mode = enMode.enAddNew;
        clsSport _Sport;
        int _SportID;
        public uctrlAjouterModifierSport()
        {
            InitializeComponent();
        }

        public void LoadSportInformation(clsSport sport)
        {
            _Sport = sport;
            _Mode = enMode.enUpdate;
            txtSportName.Text = _Sport.Nom;
            txtDescription.Text = _Sport.Description;
            rbActive.Checked = _Sport.EstActif;
            rbInactive.Checked = !(_Sport.EstActif);


        }
        private void uctrlAjouterModifierSport_Load(object sender, EventArgs e)
        {

        }

        private void tlpMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtSportName_Validating(object sender, CancelEventArgs e)
        {
            
            if (txtSportName.Text.Trim() == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(txtSportName, "Il faut Saisir le Nom du sport");

            }
            else
            {
                errorProvider1.SetError(txtSportName, null);

                if (_Mode ==enMode.enAddNew)
                {

                    if (clsSport.DoesSportExist(txtSportName.Text.Trim()))
                    {
                        errorProvider1.SetError(txtSportName, "Ce Nom Exist déja .");
                        e.Cancel = true;

                    }
                    else
                    {
                        errorProvider1.SetError(txtSportName, null);

                    }

                }
                else
                {

                    if (clsSport.DoesSportExist(txtSportName.Text.Trim())&&txtSportName.Text.Trim()!=_Sport.Nom)
                    {
                        errorProvider1.SetError(txtSportName, "Ce Nom Exist déja .");
                        e.Cancel = true;
                    }
                    else
                    {
                        errorProvider1.SetError(txtSportName, null);

                    }
                }
            }


        }

        public void Save()
        {

            if (!this.ValidateChildren())
            {
                return;
            }

            if (_Mode == enMode.enAddNew)
                _Sport = new clsSport();

            //--
            _Sport.Nom = txtSportName.Text;
            _Sport.Description = txtDescription.Text;
            _Sport.EstActif = rbActive.Checked;

            string Message = "";
            if (_Sport.Save())
            {

                if (_Mode == enMode.enAddNew)
                {
                    Message = $"Le nouveau Sport {_Sport.Nom} est sauvegardé avec successé .";
                }
                else
                {
                    Message = $"Les Changements sont sauvegardé avec successé .";

                }
                MessageBox.Show(Message, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }

            if (_Mode == enMode.enAddNew)
            {
                Message = $"Le nouveau Sport {_Sport.Nom} n' est pas sauvegardé .";
            }
            else
            {
                Message = $"Les Changements ne sont pas sauvegardés .";

            }
            MessageBox.Show(Message, "Il y a un Erreur !", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                return;
            }

            if (_Mode == enMode.enAddNew)
                _Sport = new clsSport();

            //--
            _Sport.Nom = txtSportName.Text;
            _Sport.Description = txtDescription.Text;
            _Sport.EstActif = rbActive.Checked;

            string Message = "";
            if (_Sport.Save())
            {

                if (_Mode == enMode.enAddNew)
                {
                    Message = $"Le nouveau Sport {_Sport.Nom} est sauvegardé avec successé .";
                }
                else
                {
                    Message = $"Les Changements sont sauvegardé avec successé .";

                }
                MessageBox.Show(Message, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }

            if (_Mode == enMode.enAddNew)
            {
                Message = $"Le nouveau Sport {_Sport.Nom} n' est pas sauvegardé .";
            }
            else
            {
                Message = $"Les Changements ne sont pas sauvegardés .";

            }
            MessageBox.Show(Message, "Il y a un Erreur !", MessageBoxButtons.OK, MessageBoxIcon.Error);





        }

    }
}
