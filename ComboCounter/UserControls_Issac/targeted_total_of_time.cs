using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComboCounter.Classes;

namespace ComboCounter.UserControls
{
    public partial class home_user2 : UserControl
    {

        const int timeIntervalDefault = 30;

        int quickTotal;
        int totalForceBox;

        int timeIntervalSecs = 30;

        Session session;

        public home_user2()
        {
            InitializeComponent();
        }

        // Start Button
        private void button1_Click(object sender, EventArgs e)
        {
            timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 100;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Enabled = true;
            quickTotal = timeIntervalSecs * 1000;
            totalForceBox = 0;
            session = new Session(DateTime.Now);

        }

        // Reset Button
        private void resetButton_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timeIntervalSecs = timeIntervalDefault;
            updateTimeSetter();
            currentTime.Text = "00:00.0";
            totalForceBox = 0;
            totalForce.Text = "0";
        }

        private void updateTimeSetter()
        {
            setTimeMins.Text = String.Format("{0:00}", (timeIntervalSecs / 60));
            setTimeSec.Text = String.Format("{0:00}", (timeIntervalSecs % 60));
        }

        private void setTimeSec_Click(object sender, EventArgs e)
        {

        }

        private void home_user2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            quickTotal -= 100;
            int secs = (quickTotal / 1000);
            int mins = (secs / 60);
            int mSecs = (quickTotal % 1000) / 100;

            currentTime.Text = String.Format("{0:00}:{1:00}.{2:0}", mins, secs, mSecs);
            
            totalForceBox = totalForceBox + 50;
            totalForce.Text = totalForceBox.ToString();
            session.insertHit(50, quickTotal / 60.0);

            if (quickTotal == 0)
            {
                timer1.Stop();
                History.GetSessions().Add(session);
            }
        }

        private void minusIcon_Click(object sender, EventArgs e)
        {
            timeIntervalSecs -= 15;
            if (timeIntervalSecs < 0)
            {
                timeIntervalSecs = 0;
            }
            updateTimeSetter();
        }

        private void plusIcon_Click(object sender, EventArgs e)
        {
            timeIntervalSecs += 15;
            if (timeIntervalSecs < 0)
            {
                timeIntervalSecs = 0;
            }
            updateTimeSetter();
        }
    }
}
