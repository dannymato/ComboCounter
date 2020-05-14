using System;
using System.Windows.Forms;

namespace ComboCounter.Forms
{
    public partial class CustomPunchCount : Form
    {
        int numOfPlayers = 1; //set to one as default 
        int initalForce = 200;
        int timeIntervalSec = 30;
        int timeIntervalMin = 0;
        public CustomPunchCount()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //utton2.ForeColor =#4682b4;
            button2.ForeColor = System.Drawing.Color.CadetBlue;
            button1.ForeColor = System.Drawing.Color.DimGray;
            numOfPlayers = 1;

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

            if (numOfPlayers == 1)
            {
                PunchCount PunchCountt = new PunchCount(timeIntervalMin, timeIntervalSec, initalForce);
                PunchCountt.Show();
            }
            else
            {
                PunchCountComp PunchCountComp = new Forms.PunchCountComp();
                PunchCountComp.Show();


            }

            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            button1.ForeColor = System.Drawing.Color.CadetBlue;
            button2.ForeColor = System.Drawing.Color.DimGray;
            numOfPlayers = 2;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            initalForce = initalForce + 50;
            textBox1.Text = "" + initalForce;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (initalForce == 0)
            {
                //dont do anything
            }
            else
            {
                initalForce = initalForce - 50;
                textBox1.Text = "" + initalForce;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (timeIntervalSec < 50)
            {
                timeIntervalSec = timeIntervalSec + 10;
                seconds.Text = Convert.ToString(timeIntervalSec);
            }
            else
            {
                timeIntervalMin = timeIntervalMin + 1;
                timeIntervalSec = 0;
                seconds.Text = "00";
                if (timeIntervalMin > 9)
                {
                    minutes.Text = Convert.ToString(timeIntervalMin);
                }
                else
                {
                    minutes.Text = "0" + Convert.ToString(timeIntervalMin);
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (timeIntervalMin == 0 & timeIntervalSec == 0)
            {
                // do nothing
            }
            else
            {

                if (timeIntervalSec == 0)
                {
                    timeIntervalMin = timeIntervalMin - 1;
                    timeIntervalSec = 50;
                    seconds.Text = Convert.ToString(timeIntervalSec);
                }
                else
                {
                    timeIntervalSec = timeIntervalSec - 10;
                    if (timeIntervalSec == 0)
                    seconds.Text = "00";
                    else
                    seconds.Text = "" + timeIntervalSec;
                }

                if (timeIntervalMin < 9)
                {
                    minutes.Text = "0" + Convert.ToString(timeIntervalMin);
                }
                else
                {
                    minutes.Text = Convert.ToString(timeIntervalMin);
                    //setTime.Text = Convert.ToString(timeIntervalSec);
                }
            }
        }

        private void CustomPunchCount_Load(object sender, EventArgs e)
        {

        }
    }
}
