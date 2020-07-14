using ComboCounter.Classes;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ComboCounter.CustomControls
{
    class OutlineButton : Button
    {

        // Makes sure that the designer does automatically not override the color set here in the constructor
        // Manual overrides of ForeColor and Font are still possible
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override Font Font { get; set; }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override Color ForeColor { get; set; }

        public OutlineButton() : base()
        {
            Font = FontManager.getInstance().getButtonFont();
            ForeColor = ThemeManager.initButtonColor();


            BackColor = Color.Transparent;
            TextAlign = ContentAlignment.MiddleCenter;


            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 2;
            FlatAppearance.BorderColor = Color.SteelBlue;

            AutoSize = true;

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
