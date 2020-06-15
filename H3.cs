using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace ComboCounter.Classes
{
    class H3 : Label
    {
        public H3() : base()
        {
            FontManager fm = FontManager.getInstance();
            Font = fm.getBigInfoFont();

            AutoSize = false;

        }

    }
}