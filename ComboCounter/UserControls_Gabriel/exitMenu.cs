using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public event System.EventHandler exitApplication;

        public event System.EventHandler closeDialog;

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
