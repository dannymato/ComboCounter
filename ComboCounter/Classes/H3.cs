﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace ComboCounter.Classes
{
    class H3 : Label
    {
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override Font Font { get; set; }

        public H3() : base()
        {
            FontManager fm = FontManager.getInstance();
            Font = fm.getHeader3Font();



            AutoSize = false;

        }

    }
}