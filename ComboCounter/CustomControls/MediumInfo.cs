using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace ComboCounter.Classes
{
    class MediumInfo : Label
    {

        // Makes sure that the designer does automatically not override the color set here in the constructor
        // Manual overrides of ForeColor and Font are still possible
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override Font Font { get; set; }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override Color ForeColor { get; set; }

        public MediumInfo() : base()
        {
            FontManager fm = FontManager.getInstance();
            Font = fm.getMediumInfoFont();

            ForeColor = ThemeManager.initTextColor();
            AutoSize = true;

            //TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        }

    }
}