using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace ComboCounter.Classes
{
    class BigInfo : Label
    {
        public BigInfo() : base()
        {
            FontManager fm = FontManager.getInstance();
            Font = fm.getBigInfoFont();

            //ForeColor = System.Drawing.Color.FromArgb(255, 0, 255);
            AutoSize = false;
            
            //TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        }

    }
}
