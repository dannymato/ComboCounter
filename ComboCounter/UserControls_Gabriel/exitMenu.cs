using System;
using System.Windows.Forms;

namespace ComboCounter.UserControls_Gabriel
{
    public partial class exitMenu : UserControl
    {
        public exitMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OnExitApplication(EventArgs.Empty);
        }

        public event EventHandler exitApplication;

        public event EventHandler closeDialog;

        protected virtual void OnExitApplication(EventArgs e)
        {
            exitApplication?.Invoke(this, e);
        }

        protected virtual void OnCloseDialog(EventArgs e)
        {
            closeDialog?.Invoke(this, e);
        }

        private void vstimeBtn_Click(object sender, EventArgs e)
        {
            OnCloseDialog(EventArgs.Empty);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
