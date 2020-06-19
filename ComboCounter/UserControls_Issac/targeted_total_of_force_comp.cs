using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Media;

namespace ComboCounter.UserControls
{
    public partial class targeted_total_of_force_comp : UserControl
    {
        System.Timers.Timer t;
        System.Timers.Timer t1;
        int s, totalForceBoxPlayer1;
        int s1, totalForceBoxPlayer2;
        int forceGoalNumPlayer1 = 15000;
        int forceGoalNumPlayer2 = 15000;

        public targeted_total_of_force_comp()
        {
            InitializeComponent();
        }

        // Player 1 Start
        private void startButton_Click_1(object sender, EventArgs e)
        {
            t.Start();
        }

        // Player 1 Stop
        private void stopButton_Click_1(object sender, EventArgs e)
        {
            t.Stop();
        }

        // Player 1 Reset
        private void resetButton_Click_1(object sender, EventArgs e)
        {
            t.Stop();
            s = 0;
            totalForceBoxPlayer1 = 0;
            totalForcePlayer1.Text = "N/A";
            totalForcePlayer1.ForeColor = System.Drawing.Color.DimGray;
            currTimePlayer1.Text = "00:00.0";
        }

        // Minus Button Player 2
        private void minusIcon_Player2_Click(object sender, EventArgs e)
        {
            if (forceGoalNumPlayer2 != 0)
            {
                forceGoalNumPlayer2 -= 1000;
            }
            forceGoalPlayer2.Text = String.Format("{0:n0}", forceGoalPlayer2);
        }

        // Minus Button Player 1
        private void minusIcon_Player1_Click(object sender, EventArgs e)
        {
            if (forceGoalNumPlayer1 != 0)
            {
                forceGoalNumPlayer1 -= 1000;
            }

            forceGoalPlayer1.Text = String.Format("{0:n0}", forceGoalNumPlayer1);
        }

        // Plus Button Player 1
        private void plus_icon_player_1_click(object sender, EventArgs e)
        {
            forceGoalNumPlayer1 += 1000;

            forceGoalPlayer1.Text = String.Format("{0:n0}", forceGoalNumPlayer1);
        }

        // Plus Button Player 2
        private void plus_icon_player_2_click(object sender, EventArgs e)
        {
            forceGoalNumPlayer2 += 1000;

            forceGoalPlayer2.Text = String.Format("{0:n0}", forceGoalNumPlayer2);
        }

        // Player 2 Reset
        private void resetButton1_Click_1(object sender, EventArgs e)
        {
            t1.Stop();
            s1 = 0;
            totalForceBoxPlayer2 = 0;
            totalForcePlayer2.Text = "N/A";
            totalForcePlayer2.ForeColor = System.Drawing.Color.DimGray;
            currTimePlayer2.Text = "00:00.0";
        }

        // Player 2 Stop
        private void stopButton1_Click_1(object sender, EventArgs e)
        {
            t1.Stop();
        }

        // Player 2 Start
        private void startButton1_Click_1(object sender, EventArgs e)
        {
            t1.Start();
        }

        private void targeted_total_of_force_comp_Load(object sender, EventArgs e)
        {
            // Initialize the timer for player 1
            t = new System.Timers.Timer();
            t.Interval = 100;
            t.Elapsed += OnTimeEvent;

            // Initialize the timer for player 2
            t1 = new System.Timers.Timer();
            t1.Interval = 100;
            t1.Elapsed += OnTimeEvent1;

        }

        private string FormatTimeString(int msecs)
        {
            int secs = msecs / 1000;
            int mins = msecs / 1000 / 60;
            int fracSecs = msecs % 1000 / 100;
            return String.Format("{0:00}:{1:00}.{2:0}", mins, secs, fracSecs);

        }

        private void OnTimeEvent(object sender, ElapsedEventArgs e)
        {

            SoundPlayer bellRing = new SoundPlayer(@"soundEffect\old-fashioned-bell.wav");
            Invoke(new Action(() =>
            {
                s += 100;
                currTimePlayer1.Text = FormatTimeString(s);
                if (totalForceBoxPlayer1 == forceGoalNumPlayer1)
                {
                    totalForcePlayer1.ForeColor = System.Drawing.Color.Green;
                    bellRing.Play();
                    t.Stop();
                }
                else
                {
                    totalForceBoxPlayer1 = totalForceBoxPlayer1 + 50;
                    totalForcePlayer1.Text = totalForceBoxPlayer1.ToString();
                }
            }));
        }

        private void OnTimeEvent1(object sender, ElapsedEventArgs e)
        {
            SoundPlayer bellRing = new SoundPlayer(@"soundEffect\old-fashioned-bell.wav");
            Invoke(new Action(() =>
            {
                s1 += 100;
                currTimePlayer2.Text = FormatTimeString(s1);
                
                if (totalForceBoxPlayer2 == forceGoalNumPlayer2)
                {
                    totalForcePlayer2.ForeColor = System.Drawing.Color.Green;
                    bellRing.Play();
                    t1.Stop();
                }
                else
                {
                    totalForceBoxPlayer2 = totalForceBoxPlayer2 + 50;
                    totalForcePlayer2.Text = totalForceBoxPlayer2.ToString();

                }
            }));
        }

    }
}
