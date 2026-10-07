using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using GymManager.Presentation.Helpers;

namespace GymManager.Presentation
{
    public partial class MainForm : Form
    {
        private List<Panel> _sidebarIndicators;
        public MainForm()
        {
            InitializeComponent();

            _sidebarIndicators = new List<Panel>
            {
                    pnlPersonnesIndicator,
                    pnlAdherentsIndicator,
                    pnlSportsIndicator,
                    pnlTypesAbonnementIndicator,
                    pnlAbonnementsIndicator,
                    pnlUtilisateurIndicator
            };
            
        }

       

        private void MainForm_Load(object sender, EventArgs e)
        {
            ipbCurrentUser.IconChar = IconChar.User;
            ipbCurrentUser.IconSize = 40;

            UIHelper.SetupIconButton(btnPersonnes , IconChar.PeopleGroup);
            UIHelper.SetupIconButton(btnAdherents, IconChar.UserCheck);
            UIHelper.SetupIconButton(btnSports, IconChar.Dumbbell);
            UIHelper.SetupIconButton(btnTypesAbonnements, IconChar.List);
            UIHelper.SetupIconButton(btnAbonnements, IconChar.CreditCard);
            UIHelper.SetupIconButton(btnUtilisateurs, IconChar.UserCog);
            UIHelper.SetupIconButton(btnDeconnexion, IconChar.SignOutAlt);

            lblTitle.ForeColor = ColorTranslator.FromHtml("#111827");

            UIHelper.SetupSidebarButtonStyle(btnPersonnes);
            UIHelper.SetupSidebarButtonStyle(btnAdherents);
            UIHelper.SetupSidebarButtonStyle(btnSports);
            UIHelper.SetupSidebarButtonStyle(btnTypesAbonnements);
            UIHelper.SetupSidebarButtonStyle(btnAbonnements);
            UIHelper.SetupSidebarButtonStyle(btnUtilisateurs);
            UIHelper.SetupSidebarButtonStyle(btnDeconnexion);


            pnlSidebar.BackColor = ColorTranslator.FromHtml("#0F172A");
            pnlHeader.BackColor = ColorTranslator.FromHtml("#0F172A");
            lblTitle.ForeColor = Color.White;
            lblCurrentUser.ForeColor = Color.White;
            ipbCurrentUser.IconColor = Color.White;

            //this.ShowIcon = false;


        }

       
        private void btnPersonnes_Click(object sender, EventArgs e)
        {
            UIHelper.ActivateButton(btnPersonnes, pnlPersonnesIndicator, _sidebarIndicators, pnlSidebar);
        }

        private void btnAdherents_Click(object sender, EventArgs e)
        {
            UIHelper.ActivateButton(btnAdherents, pnlAdherentsIndicator, _sidebarIndicators, pnlSidebar);
        }

        private void btnSports_Click(object sender, EventArgs e)
        {
            UIHelper.ActivateButton(btnSports, pnlSportsIndicator, _sidebarIndicators, pnlSidebar);
        }

        private void btnTypesAbonnements_Click(object sender, EventArgs e)
        {
            UIHelper.ActivateButton(btnTypesAbonnements, pnlTypesAbonnementIndicator, _sidebarIndicators, pnlSidebar);
        }

        private void btnAbonnements_Click(object sender, EventArgs e)
        {
            UIHelper.ActivateButton(btnAbonnements, pnlAbonnementsIndicator, _sidebarIndicators, pnlSidebar);
        }

        private void btnUtilisateurs_Click(object sender, EventArgs e)
        {
            UIHelper.ActivateButton(btnUtilisateurs, pnlUtilisateurIndicator, _sidebarIndicators, pnlSidebar);
        }
    }
}
