using System;
using System.Windows.Forms;

namespace ComboCounter.Forms
{
    public partial class CustomTargetTotalForm : Form
    {
        int numOfPlayers = 1; //set to one as default 
        public CustomTargetTotalForm()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.ForeColor = System.Drawing.Color.CadetBlue;
            button4.ForeColor = System.Drawing.Color.Gray;
            numOfPlayers = 1;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.ForeColor = System.Drawing.Color.CadetBlue;
            button5.ForeColor = System.Drawing.Color.Gray;
            numOfPlayers = 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (numOfPlayers == 1)
            {
                TargetedTotalForce TargetedTotalForce = new TargetedTotalForce();
                TargetedTotalForce.Show();
            }
            else
            {
                TargetTotalForceComp TargetTotalForceComp = new TargetTotalForceComp();
                TargetTotalForceComp.Show();

            }
        }
    }
}
