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

namespace GymManager.Presentation.Members
{
    public partial class frmShowMemberInfo : Form
    {
        private int _memberId;
        private clsMember _MemberInfo;

        public frmShowMemberInfo(int MemberID)
        {
            InitializeComponent();
            _memberId = MemberID;
        }

        private void frmShowMemberInfo_Load(object sender, EventArgs e)
        {
            _MemberInfo = clsMember.FindMember(_memberId);

            if( _MemberInfo == null )
            {
                MessageBox.Show($"Le membre avec cet identifiant : {_memberId} n'existe pas.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ucPersonCard1.LoadPersonInfo(_MemberInfo.PersonID);

        }


    }
}
