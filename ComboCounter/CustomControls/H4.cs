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
    class H4 : Label
    {
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override Font Font { get; set; }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override Color ForeColor { get => base.ForeColor; set => base.ForeColor = value; }

        public H4() : base()
        {
            FontManager fm = FontManager.getInstance();
            Font = fm.getHeader4Font();

            ThemeManager.initHeaderColor();

            AutoSize = true;

        }

    }
}