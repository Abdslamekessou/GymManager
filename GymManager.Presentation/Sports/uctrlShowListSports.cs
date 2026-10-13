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
    public partial class uctrlShowListSports : UserControl
    {
        DataTable _AllSports = clsSport.GetAllSports();
        
        public uctrlShowListSports()
        {
            InitializeComponent();
            dgvSports.DataSource = _AllSports;
        }

        private void uctrlShowListSports_Load(object sender, EventArgs e)
        {

        }

        private void btnFilter_Click(object sender, EventArgs e)
        {

        }

        private void tlpMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
