using System;
using System.Windows.Forms;

namespace ComboCounter.Forms
{
    public partial class CustomTargetTotalTime : Form
    {
        int numOfPlayers = 1; //set to one as default 
        public CustomTargetTotalTime()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.ForeColor = System.Drawing.Color.CadetBlue;
            button1.ForeColor = System.Drawing.Color.Gray;
            numOfPlayers = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.ForeColor = System.Drawing.Color.CadetBlue;
            button2.ForeColor = System.Drawing.Color.Gray;
            numOfPlayers = 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (numOfPlayers == 1)
            {
                TargetTotalTime TargetTotalTime = new TargetTotalTime();
                TargetTotalTime.Show();
            }
            else
            {
                TargetTotalTimeComp TargetTotalTimeComp = new TargetTotalTimeComp();
                TargetTotalTimeComp.Show();

            }

        }
    }
}
