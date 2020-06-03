using System;
using System.Windows.Forms;

namespace ComboCounter.Forms
{
    public partial class Exit : Form
    {
        public Exit()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, System.EventArgs e)
        {

        }

        private void exitMenu1_Load(object sender, System.EventArgs e)
        {
            exitMenu1.exitApplication += (o, a) =>
            {
                Close();
                OnExitApplication(e);
            };

            exitMenu1.closeDialog += (o, a) => { Close(); };
        }

        protected virtual void OnExitApplication(EventArgs e)
        {
            exitApplication?.Invoke(this, e);
        }

        public event System.EventHandler exitApplication;
    }
}
