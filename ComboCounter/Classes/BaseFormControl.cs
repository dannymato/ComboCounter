using System.Windows.Forms;

namespace ComboCounter.Classes
{
    public class BaseFormControl : UserControl
    {

        virtual public void OnPageAttached() { }

        virtual public void OnPageRemoved() { }

        virtual public void OnExit() { }

    }
}
