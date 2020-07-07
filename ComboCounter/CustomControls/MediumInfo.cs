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

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override Font Font { get; set; }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override Color ForeColor { get => base.ForeColor; set => base.ForeColor = value; }

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