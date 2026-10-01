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
    }
}
