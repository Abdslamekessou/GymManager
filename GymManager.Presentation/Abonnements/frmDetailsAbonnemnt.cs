using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManager.Presentation.Abonnements
{
    public partial class frmDetailsAbonnemnt : Form
    {
        private int _AbonnemntID = -1;

        public frmDetailsAbonnemnt(int selectedID)
        {
            InitializeComponent();
            _AbonnemntID = selectedID;
        }

        private void frmDetailsAbonnemnt_Load(object sender, EventArgs e)
        {
            if (_AbonnemntID != -1)
                ucDetailsAbonnemnt1.LoadAbonnementInfo(_AbonnemntID);
            else
                MessageBox.Show("Error");
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
