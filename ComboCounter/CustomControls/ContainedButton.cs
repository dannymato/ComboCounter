using ComboCounter.Classes;
using System.Windows.Forms;

namespace ComboCounter.CustomControls
{
    class ContainedButton : Button
    {

        public ContainedButton() : base()
        {

            Font = FontManager.getInstance().getButtonFont(); 

            TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            BackColor = System.Drawing.Color.SteelBlue; // We'll use the theme manager here

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
