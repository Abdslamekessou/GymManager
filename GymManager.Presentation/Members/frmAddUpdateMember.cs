using GymManager.Business;
using GymManager.Presentation.Personnes.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManager.Presentation.Members
{
    public partial class frmAddUpdateMember : Form
    {
        public enum enMode { AddNew = 0, Update = 1 };

        private enMode _Mode = enMode.AddNew;

        private int _MemberID = -1;

        public clsMember MemberInfo;

        public int MemberID
        {
            get { return _MemberID; }
        }

        public frmAddUpdateMember(int MemberID)
        {
            InitializeComponent();

            _MemberID = MemberID;
            _Mode = enMode.Update;
        }

        public frmAddUpdateMember()
        {
            InitializeComponent();

            _Mode = enMode.AddNew;
        }

        private void _ResetDefualtValues()
        {
            // This will initialize the reset the defaule values

            if (_Mode == enMode.AddNew)
            {
                lblTitle.Text = "👤 AJOUTER Un Membre";
                MemberInfo = new clsMember();
            }
            else
            {
                lblTitle.Text = "👤 Modifier Le Membre";
                ucAbonnementInfo1.IsUpdateMode = true;
            }

        }

        private void _LoadMemberAndAbonnementData()
        {
            MemberInfo = clsMember.FindMember(MemberID);

            if (MemberInfo == null)
            {
                MessageBox.Show("No Member with ID = " + MemberID, "Member Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }

            ucPersonCardWithFilter1.LoadPersonInfo(MemberInfo.PersonID);
            ucPersonCardWithFilter1.FilterEnabled = false;

            if (MemberInfo.IsActif)
                rbActif.Checked = true;
            else
                rbInActif.Checked = true;

            if( !ucAbonnementInfo1.LoadAbonnementInfoByMemberID(MemberInfo.MemberID) )
                this.Close();


        }

        private void frmAddUpdateMember_Load(object sender, EventArgs e)
        {

            _ResetDefualtValues();

            if (_Mode == enMode.Update)
                _LoadMemberAndAbonnementData();
        }


        private bool SaveMember()
        {

            MemberInfo.PersonID = ucPersonCardWithFilter1.SelectedPersonInfo.PersonID;
            MemberInfo.CreatedAt = DateTime.Now;
            MemberInfo.CreatedBy = 1;

            if(rbActif.Checked)
                MemberInfo.IsActif = true;
            else
                MemberInfo.IsActif = false;

            return MemberInfo.Save();

        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if(ucPersonCardWithFilter1.SelectedPersonInfo != null )
            {

                if (!SaveMember() )
                {
                    MessageBox.Show(
                        "Erreur dans le sauvgarde de ce 'Membre'",
                        "Erreur",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );

                    return;
                }


                if(_Mode == enMode.AddNew)
                {
                    if (!ucAbonnementInfo1.SaveAbonnementInfo(MemberInfo.MemberID, 1))
                    {
                        MessageBox.Show(
                        "Une erreur s'est produite lors de l'enregistrement de l'abonnement.",
                        "Erreur",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                        );

                        return;
                    }
                }


                //change form mode to update.
                _Mode = enMode.Update;
                lblTitle.Text = "👤 Modifier Le Membre";
                ucPersonCardWithFilter1.FilterEnabled = false;
                ucAbonnementInfo1.IsUpdateMode = true;

                MessageBox.Show(
                    "L'adhérent et l'abonnement ont été enregistrés avec succès.",
                    "Succès",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                return;
            }
            else
            {
                if(_Mode == enMode.AddNew)
                {
                    MessageBox.Show(
                    "Veuillez d'abord sélectionner une personne.",
                    "Erreur",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );

                    return;
                }

            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
