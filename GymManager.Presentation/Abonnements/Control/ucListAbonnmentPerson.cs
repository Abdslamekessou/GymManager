using GymManager.Business.GymManager.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManager.Presentation.Abonnements.Control
{
    public partial class ucListAbonnmentPerson : UserControl
    {
        private int _MemberID;
        private DataTable _dtListAbonnement;
        public ucListAbonnmentPerson()
        {
            InitializeComponent();
        }

      

        public void LoadAbonnementsPersonData(int MemberID)
        {
            _MemberID = MemberID;

            _dtListAbonnement = clsAbonnement.GetAllAbonnementsWithMemberID(_MemberID);
            dgvAbonnements.DataSource = _dtListAbonnement;

            if (cbFilterStatut != null && cbFilterStatut.Items.Count > 0)
                cbFilterStatut.SelectedIndex = 0;

        }

        private void cbFilterStatut_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_dtListAbonnement == null) return;

            string selectedStatut = cbFilterStatut.Text.Trim();

            if (selectedStatut == "Tous" || string.IsNullOrEmpty(selectedStatut))
            {
                _dtListAbonnement.DefaultView.RowFilter = "";
            }
            else
            {
                _dtListAbonnement.DefaultView.RowFilter = string.Format("Statut = '{0}'", selectedStatut.Replace("'", "''"));
            }
        }
    }
}
