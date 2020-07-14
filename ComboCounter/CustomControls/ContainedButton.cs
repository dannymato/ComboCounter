using ComboCounter.Classes;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ComboCounter.CustomControls
{
    class ContainedButton : Button
    {

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override Font Font {get; set;}

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override Color ForeColor { get; set; }

        public ContainedButton() : base()
        {

            Font = FontManager.getInstance().getButtonFont(); 

            TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            BackColor = ThemeManager.initButtonColor(); // We'll use the theme manager here

            ForeColor = System.Drawing.Color.White;
            FlatStyle = FlatStyle.Flat;

            AutoSize = true;

            FlatAppearance.BorderSize = 0;

            Padding = new Padding()
            {
                Top = 5,
                Bottom = 5,
                Left = 10,
                Right = 10
            };

        }

    }
}
