using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace GymManager.Presentation.Helpers
{
    public static class UIHelper
    {
        private static IconButton _activeButton;
        public static void SetupIconButton(IconButton btn , IconChar icon)
        {

            btn.IconChar = icon;
            btn.TextImageRelation = TextImageRelation.ImageBeforeText;
           
            btn.ImageAlign = ContentAlignment.MiddleLeft;
            btn.TextAlign = ContentAlignment.MiddleRight;

            btn.Padding = new Padding(10, 0, 0, 0);
        }


        public static void SetupSidebarButtonStyle(IconButton btn )
        {
            Color normalColor;
            Color hoverColor;
            if (btn.Name == "btnDeconnexion")
            {
                normalColor = ColorTranslator.FromHtml("#DC2626");
                hoverColor = ColorTranslator.FromHtml("#B91C1C");
            }
            else
            {
                normalColor = ColorTranslator.FromHtml("#0F172A");
                hoverColor = ColorTranslator.FromHtml("#1E293B"); 
            }

            btn.BackColor = normalColor;

            btn.ForeColor = ColorTranslator.FromHtml("#F8FAFC");
            btn.IconColor = ColorTranslator.FromHtml("#F8FAFC");
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;

            btn.MouseEnter += (s, args) =>
            {
                if (btn != _activeButton)
                {
                    btn.BackColor = hoverColor;
                }
            };



            btn.MouseLeave += (s, args) =>
            {
                if (btn != _activeButton)
                {
                    btn.BackColor = normalColor;
                }
            };
                           
        }

        public static void ActivateButton(IconButton button ,Panel indicator ,List<Panel> _sidebarIndicators, Panel SideBar)
        {
            
            
            foreach(Control control in SideBar.Controls)
            {
                if(control is IconButton sidebarButton && sidebarButton.Name != "btnDeconnexion")
                {
                    sidebarButton.BackColor = ColorTranslator.FromHtml("#0F172A");
                    sidebarButton.ForeColor = ColorTranslator.FromHtml("#F8FAFC");
                    sidebarButton.IconColor = ColorTranslator.FromHtml("#F8FAFC");
                }


            }

            foreach(Panel idicator in _sidebarIndicators)
            {
                idicator.Visible = false;
            }

            button.BackColor = ColorTranslator.FromHtml("#334155");
            button.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
            button.IconColor = ColorTranslator.FromHtml("#3B82F6");

            indicator.Visible = true;
            indicator.BackColor = ColorTranslator.FromHtml("#3B82F6");

            _activeButton = button;
        }
    }
}
