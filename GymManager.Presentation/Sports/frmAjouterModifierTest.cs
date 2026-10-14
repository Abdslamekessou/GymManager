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
    public partial class frmAjouterModifierTest : Form
    {
        enum enMode { enAddNew = 0,enUpdate=1}
        enMode _Mode;
        clsSport _Sport;
        int _SportID;
        public frmAjouterModifierTest(int sportID)
        {
            InitializeComponent();
            btnAnnuler.CausesValidation = false;
            _SportID = sportID;
            if (_SportID == -1)
            {
             _Mode = enMode.enAddNew;   
             _Sport = new clsSport();
                return;
            }

            _Mode = enMode.enUpdate;
            _Sport = clsSport.Find(_SportID);

            // Load information in uctrlAjouterModifierSports
            if (_Sport!=null)
            {
                uctrlAjouterModifierSport1.LoadSportInformation(_Sport);
            }
        }

        private void frmAjouterModifierTest_Load(object sender, EventArgs e)
        {

        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            uctrlAjouterModifierSport1.Save();
        }
    }
}
