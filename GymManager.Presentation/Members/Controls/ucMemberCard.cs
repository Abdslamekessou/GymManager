using DocumentFormat.OpenXml.Spreadsheet;
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

namespace GymManager.Presentation.Members.Controls
{
    public partial class ucMemberCard : UserControl
    {
        private int _MemberID = -1;
        public int MemberID
        {
            get { return _MemberID; }
        }

        private clsMember _Member;
        public clsMember SelectedMemberInfo
        {
            get { return _Member; }
        }

        public clsPerson PersonInfo
        {
            get { return ucPersonCard1.SelectedPersonInfo; }
        }


        private bool _isAddUpdateMode = true;
        public bool IsAddUpdateMode
        {

            get
            {
                return _isAddUpdateMode;
            }
            set
            {
                _isAddUpdateMode = value;

                if(!_isAddUpdateMode)
                {
                    lblStatusTitle.Visible = true;
                    lblStatus.Visible = true;

                    rbActif.Visible = false;
                    rbInActif.Visible = false;
                }
 
            }
        }

        public ucMemberCard()
        {
            InitializeComponent();
        }

        public void LoadMemberInfo(int MemberID)
        {
            _Member = clsMember.FindMember(MemberID);

            if (_Member == null)
            {
                MessageBox.Show("No Member with MemberID = " + MemberID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            _MemberID = MemberID;

            ucPersonCard1.Tilte = "DE MEMBRE";

            ucPersonCard1.LoadPersonInfo(_Member.PersonID);

            if(_isAddUpdateMode)
            {
                if (_Member.IsActif)
                    rbActif.Checked = true;
                else
                    rbInActif.Checked = true;
            }
            else
            {
                lblStatus.Text = (_Member.IsActif) ? "Actif" : "N'est Pas Actif";
            }

        }

    }
}
