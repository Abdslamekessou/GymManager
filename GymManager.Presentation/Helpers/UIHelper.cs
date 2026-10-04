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
        public static void SetupIconButton(IconButton btn , IconChar icon)
        {

            btn.IconChar = icon;
            btn.TextImageRelation = TextImageRelation.ImageBeforeText;
           
            btn.ImageAlign = ContentAlignment.MiddleLeft;
            btn.TextAlign = ContentAlignment.MiddleRight;
        }


        public static void SetupSidebarButtonStyle(IconButton btn)
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
                    btn.BackColor = hoverColor;

            btn.MouseLeave += (s, args) =>
                           btn.BackColor = normalColor;
        }
    }
}
