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


            ucPersonCard1.Tilte = "DE MEMBRE";

            ucPersonCard1.LoadPersonInfo(_Member.PersonID);

            if (_Member.IsActif)
                rbActif.Checked = true;
            else
                rbInActif.Checked = true;

        }

        private void ucMemberCard_Load(object sender, EventArgs e)
        {

        }
    }
}
