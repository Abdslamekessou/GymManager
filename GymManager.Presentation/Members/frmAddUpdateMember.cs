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
    public partial class frmAddUpdateMember : Form
    {
        public enum enMode { AddNew = 0, Update = 1 };

        public frmAddUpdateMember(int MemberID)
        {
            InitializeComponent();
        }

        public frmAddUpdateMember()
        {
            InitializeComponent();
        }

        private void frmAddUpdateMember_Load(object sender, EventArgs e)
        {

        }
    }
}
