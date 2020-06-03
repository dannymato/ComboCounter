using ComboCounter.UserControls_Gabriel;
using System;
using System.Drawing;
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



            exitMenu1.Location = new Point((Width / 2) - (exitMenu1.Width / 2), (Height / 2) - (exitMenu1.Height / 2));
        }

        protected virtual void OnExitApplication(EventArgs e)
        {
            exitApplication?.Invoke(this, e);
        }

        public event System.EventHandler exitApplication;
    }
}
