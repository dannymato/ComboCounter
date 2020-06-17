using ComboCounter.Classes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboCounter.CustomControls
{
    class TextButton : Button
    {

        public TextButton() : base()
        {
            Font = FontManager.getInstance().getButtonFont();

            BackColor = Color.Transparent;
            TextAlign = ContentAlignment.MiddleCenter;

            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;

            ForeColor = Color.White;
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
