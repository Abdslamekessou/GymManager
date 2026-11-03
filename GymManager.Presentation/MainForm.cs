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

namespace GymManager.Presentation
{
    public partial class MainForm : Form
    {
        public frmLogin _frmLogin;

        public MainForm(frmLogin frm)
        {
            InitializeComponent();
            _frmLogin = frm;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

      
      

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            _frmLogin.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Test test = new Test();
            test.ShowDialog();
        }
    }
}
