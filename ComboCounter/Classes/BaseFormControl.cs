using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboCounter.Classes
{
    abstract public class BaseFormControl : UserControl
    {

        public abstract void OnPageAttached();

        public abstract void OnPageRemoved();

        public abstract void OnExit();

    }
}
