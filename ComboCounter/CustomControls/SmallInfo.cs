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
    class SmallInfo : Label
    {

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override Font Font { get; set; }

        public SmallInfo() : base()
        {
            FontManager fm = FontManager.getInstance();
            Font = fm.getSmallInfoFont();

            //ForeColor = System.Drawing.Color.FromArgb(255, 0, 255);
            AutoSize = false;

            //TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        }

    }
}