using System.Windows.Forms;

namespace ComboCounter.Classes
{
    /// <summary>
    /// Base class for the UserControls in the application.
    /// Contains virtual methods that may be implemented by subclasses.
    /// Allows us to call specific methods when pages are attached, removed
    /// and when the program exits.
    /// </summary>
    public class BaseFormControl : UserControl
    {
        /// <summary>
        /// Called when the Main page attaches the page to the panel
        /// </summary>
        virtual public void OnPageAttached() { }

        /// <summary>
        /// Called when the Main page removes the page from the panel
        /// </summary>
        virtual public void OnPageRemoved() { }

        /// <summary>
        /// Called when the Main page is going to exit
        /// </summary>
        virtual public void OnExit() { }

    }
}
