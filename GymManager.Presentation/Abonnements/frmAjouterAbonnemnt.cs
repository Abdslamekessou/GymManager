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
    public partial class frmAjouterAbonnemnt : Form
    {
        public frmAjouterAbonnemnt()
        {
            InitializeComponent();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {

            int memberId = ucMemberCardWithFilter1.MemberID;

            if (ucAbonnementInfo1.SaveAbonnementInfo(memberId, 1))
            {
                
                MessageBox.Show(
                    "L'abonnement a été enregistré avec succès !",
                    "Succès",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            else
            {
                
                MessageBox.Show(
                    "Une erreur est survenue lors de l'enregistrement de l'abonnement. Veuillez réessayer.",
                    "Erreur",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }


        }

        private void ucAbonnementInfo1_Load(object sender, EventArgs e)
        {

        }

        private void frmAjouterAbonnemnt_Load(object sender, EventArgs e)
        {

        }
    }
}
