﻿using System.Windows.Forms;

namespace ComboCounter.Classes
{
    class Header1 : Label
    {
        public Header1() : base()
        {
            FontManager fm = FontManager.getInstance();
            Font = fm.getHeaderFont();

            // ForeColor = ThemeManager thing
            ForeColor = System.Drawing.Color.FromArgb(255, 0, 255);

            AutoSize = false;
            TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        }

        
    }
}
