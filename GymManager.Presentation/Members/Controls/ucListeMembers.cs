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
    public partial class ucListeMembers : UserControl
    {
        public ucListeMembers()
        {
            InitializeComponent();
        }

        private void ucListeMembers_Load(object sender, EventArgs e)
        {
            dgvMembers.DataSource = clsMember.GetAllMembers();
        }
    }
}
