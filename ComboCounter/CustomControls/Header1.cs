using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ComboCounter.Classes
{
    class Header1 : Label
    {
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override Font Font { get; set; }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override Color ForeColor { get; set; }

        public Header1() : base()
        {
            FontManager fm = FontManager.getInstance();
            Font = fm.getHeaderFont();

            // ForeColor = ThemeManager thing
            ForeColor = ThemeManager.initHeaderColor();

            AutoSize = false;
            TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        }

        
    }
}
