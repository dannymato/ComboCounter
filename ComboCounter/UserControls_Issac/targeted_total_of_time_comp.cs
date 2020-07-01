using System;
using System.Windows.Forms;

namespace ComboCounter.UserControls
{
    public partial class targeted_total_of_time_comp : UserControl
    {
        int totalForceNumPlay1, totalForceNumPlay2;

        int quickTotalPlayer1, quickTotalPlayer2;

        int numSecsPlay1 = 30;
        int numSecsPlay2 = 30;

        public targeted_total_of_time_comp()
        {
            InitializeComponent();
            header.Left = (Width - header.Width) / 2;
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        // This is the player 1 start button
        private void startButton_Click(object sender, EventArgs e)
        {
            timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 100;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Enabled = true;
            quickTotalPlayer1 = numSecsPlay1 * 1000;
            totalForceNumPlay1 = 0;
            totalForceNumPlay2 = 0;
            togglePlayer1SetTime();
        }

        // Player 1 Reset
        private void resetButton_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            updateTimeText(setTimePlayer1, numSecsPlay1);
            currentTimePlayer1.Text = "00:00.0";
            totalForceNumPlay2 = 0;
            totalForcePlayer1.Text = "0";
            togglePlayer1SetTime();
        }

        // Player 2 Start
        private void startButton1_Click(object sender, EventArgs e)
        {
            timer2 = new System.Windows.Forms.Timer();
            timer2.Interval = 100;
            timer2.Tick += new EventHandler(timer2_Tick);
            timer2.Enabled = true;
            quickTotalPlayer2 = numSecsPlay2 * 1000;
            togglePlayer2SetTime();
        }

        // Player 2 Stop
        private void stopButton1_Click(object sender, EventArgs e)
        {
            timer2.Stop();
        }

        // Player 2 Reset
        private void resetButton1_Click(object sender, EventArgs e)
        {
            timer2.Stop();
            setTimePlayer1.Text = "00:00.0";
            updateTimeText(setTimePlayer1, numSecsPlay2);
            totalForceNumPlay2 = 0;
            totalForcePlayer2.Text = "0";
            togglePlayer2SetTime();
        }

        // What happens when player 1's time ticks
        private void timer1_Tick(object sender, EventArgs e)
        {
            quickTotalPlayer1 -= 100;

            currentTimePlayer1.Text = currentTimeLabelText(quickTotalPlayer1);
            if (quickTotalPlayer1 <= 0)
            {
                timer1.Stop();
            }
            totalForceNumPlay1 = totalForceNumPlay1 + 50;
            totalForcePlayer1.Text = totalForceNumPlay1.ToString();

        }

        // What happens when player 2's time ticks
        private void timer2_Tick(object sender, EventArgs e)
        {
            quickTotalPlayer2 -= 100;
            currTimePlayer2.Text = currentTimeLabelText(quickTotalPlayer2);
            if (quickTotalPlayer2 <= 0)
            {
                timer2.Stop();
            }
            totalForceNumPlay2 = totalForceNumPlay2 + 50;
            totalForcePlayer2.Text = totalForceNumPlay2.ToString();

        }

        private string currentTimeLabelText(int msecs)
        {
            int numMins = msecs / 1000 / 60;
            int numSecs = msecs / 1000 % 60;
            int fracSecs = (msecs % 1000) / 100;

            return String.Format("{0:00}:{1:00}.{2:0}", numMins, numSecs, fracSecs);
        }

        private void togglePlayer1SetTime()
        {
            plusIconPlayer1.Enabled = !plusIconPlayer1.Enabled;
            minusIconPlayer1.Enabled = !minusIconPlayer1.Enabled;
        }

        private void togglePlayer2SetTime()
        {
            plusIconPlayer2.Enabled = !plusIconPlayer2.Enabled;
            minusIconPlayer2.Enabled = !minusIconPlayer2.Enabled;
        }




        private void updateTimeText(Label timeLabel, int numSecs)
        {
            timeLabel.Text = String.Format("{0:00}:{1:00}", numSecs / 60, numSecs % 60);
        }

        // Player 1 Minus Icon
        private void minusIcon_Click(object sender, EventArgs e)
        {
            numSecsPlay1 -= 15;
            if (numSecsPlay1 < 15) {
                numSecsPlay1 = 15;
            }

            updateTimeText(setTimePlayer1, numSecsPlay1);
        }

        // Player 1 Plus Icon
        private void plusIcon_Click(object sender, EventArgs e)
        {
            numSecsPlay1 += 15;

            updateTimeText(setTimePlayer1, numSecsPlay1);
        }

        private void targeted_total_of_time_comp_Load(object sender, EventArgs e)
        {

        }



        // Player 2 Minus Icon
        private void minusIcon1_Click(object sender, EventArgs e)
        {
            numSecsPlay2 -= 15;
            if (numSecsPlay2 < 15)
            {
                numSecsPlay2 = 15;
            }

            updateTimeText(setTimePlayer2, numSecsPlay2);
        }

        // Player 2 Plus Icon
        private void plusIcon1_Click(object sender, EventArgs e)
        {
            numSecsPlay2 += 15;
            if (numSecsPlay2 < 15)
            {
                numSecsPlay2 = 15;
            }

            updateTimeText(setTimePlayer2, numSecsPlay2);
        }
    }
}
