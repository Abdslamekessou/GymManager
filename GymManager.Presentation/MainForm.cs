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
        public MainForm()
        {
            InitializeComponent();
            
        }

       

        private void MainForm_Load(object sender, EventArgs e)
        {
            ipbCurrentUser.IconChar = IconChar.User;
            ipbCurrentUser.IconSize = 50;

            UIHelper.SetupIconButton(btnPersonnes , IconChar.PeopleGroup);
            UIHelper.SetupIconButton(btnAdherents, IconChar.UserCheck);
            UIHelper.SetupIconButton(btnSports, IconChar.Dumbbell);
            UIHelper.SetupIconButton(btnTypesAbonnements, IconChar.List);
            UIHelper.SetupIconButton(btnAbonnements, IconChar.CreditCard);
            UIHelper.SetupIconButton(btnUtilisateurs, IconChar.UserCog);
            UIHelper.SetupIconButton(btnDeconnexion, IconChar.SignOutAlt);
        }

       
    }
}
