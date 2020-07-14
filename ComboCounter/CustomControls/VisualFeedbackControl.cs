using ComboCounter.Classes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Timers;
using System.Windows.Forms;

namespace ComboCounter.CustomControls
{

    // This class will show a visual representation of the last hit
    // The low medium and high are the colors which are used for the bar
    // The hits are input with the PushPunch method
    // When using this class it is important that before the window is destroyed cleanup is called
    // If cleanup is not called an exception may occur since the timers would stil continue going
    // FinishSetup has to be called explicitly once the control size has been set
    class VisualFeedbackControl : UserControl
    {
        // Holds onto punches to queue up for animation
        // Most likely will only hold onto 1 punch at a time
        // Just in case the punches are coming faster than we can animate them
        private Queue<float> punchQueue = new Queue<float>(5);
        public float MaxForce { get; set; }
        const int MIN_LENGTH = 40;
        TimeSpan animationDuration = new TimeSpan(1000000);

        Color Low;
        Color Medium;
        Color High;

        // Essentially acts like a while loop checking for new punches to animate
        // Also has the duty of animating the retracting animation when not animating
        System.Timers.Timer InitializerTimer;

        // Animates the increasing bar when a new hit is input into the system
        System.Timers.Timer AnimationTimer;

        bool isRunning = false;

        // A reference point for the animationtimer to know how long it has been animating for
        DateTime animationStart;

        float current_Force = 0.0f;

        // A reference point to know how far the bar has to go to get to the next value
        int lastWidth = 0;
        int currWidth = 0;

        // Calculated at the end of an animation
        // Is calculated to be approx. 5 seconds to fully retract with a minimum of 1 per tick
        int decreasePerTick = 2;

        UserControl bar;

        List<UserControl> hashMarks;

        public VisualFeedbackControl()
            : this(Color.Red, Color.Yellow, Color.Green) {}

        public VisualFeedbackControl(Color low, Color medium, Color high)
        {
            Low = low;
            Medium = medium;
            High = high;

            MaxForce = 300.0f;

            punchQueue = new Queue<float>();

            bar = new UserControl();

            InitializerTimer = new System.Timers.Timer();
            InitializerTimer.Interval = 10;
            InitializerTimer.Elapsed += InitializerTimer_Tick;
            InitializerTimer.Start();
        }
        /// <summary>
        /// Adjusts the sizing of the elements depending on the size of the 
        /// entire control. Also creates the hashmarks
        /// </summary>
        public void FinishSetup()
        {
            BackColor = Color.Transparent;

            bar.Height = (int)(Height * 0.8);
            bar.Left = 0;
            bar.Anchor = AnchorStyles.Left | AnchorStyles.Top;
            bar.Width = 0;
            bar.Top = (Height - bar.Height) / 2;

            Controls.Add(bar);

            int numMarks = Width / 40;

            hashMarks = null;
            hashMarks = new List<UserControl>(numMarks);
            for (int i = 0; i < numMarks; i++)
            {
                hashMarks.Add(new UserControl());
                hashMarks[i].Width = 5;
                hashMarks[i].BackColor = ThemeManager.initTextColor();
                hashMarks[i].Height = Height;
                hashMarks[i].Anchor = AnchorStyles.Left;
                hashMarks[i].Left = 40 * i;
                Controls.Add(hashMarks[i]);
            }
        }

        /// <summary>
        /// Called on every tick of the initializer timer
        /// Reponsible for pushing new animation timers and for enacting the idle decrease animation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InitializerTimer_Tick(object sender, EventArgs e)
        {
            bar.Height = (int)(Height * 0.8);

            if (!isRunning && punchQueue.Count > 0)
            {
                current_Force = punchQueue.Dequeue();
                AnimationTimer = new System.Timers.Timer();
                AnimationTimer.Interval = 10;
                AnimationTimer.Elapsed += AnimationTimer_Tick;
                currWidth = (int)Math.Min(Width, Width * (current_Force / MaxForce) + MIN_LENGTH);
                AnimationTimer.Start();
                animationStart = DateTime.Now;
                isRunning = true;
            }
            else if (!isRunning && punchQueue.Count == 0 && lastWidth > 0)
            {
                lastWidth -= decreasePerTick;
                bar.BackColor = Tools.Interpolate(Low, Medium, High, (float)lastWidth / (float)Width);
                if (lastWidth <= 0)
                {
                    lastWidth = 0;
                }
                Invoke((MethodInvoker) delegate
                {
                    bar.Width = lastWidth;
                });
            }
        }

        /// <summary>
        /// Needs to be called before the window is destroyed
        /// Makes sure that the timers are disposed of before the window is destroyed
        /// If this method is not called there is an exception on exit
        /// </summary>
        public void Cleanup()
        {
            InitializerTimer.Stop();
            if (AnimationTimer != null)
            {
                AnimationTimer.Stop();
                AnimationTimer.Dispose();
            }
            InitializerTimer.Dispose();
        }

        /// <summary>
        /// Responsible for animating the bar between force values
        /// The method is called for every tick of the AnimationTimer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AnimationTimer_Tick(object sender, ElapsedEventArgs e)
        {
            TimeSpan span = e.SignalTime - animationStart;
            double percentTime = span.TotalMilliseconds / animationDuration.TotalMilliseconds;

            if (span >= animationDuration)
            {
                AnimationTimer.Stop();
                lastWidth = currWidth;
                isRunning = false;
            }

            float percentForce = current_Force / MaxForce;


            int width = (int)(lastWidth + (currWidth - lastWidth) * percentTime);
            
            Color forceColor = Tools.Interpolate(Low, Medium, High, (float)width / (float)Width);

            Invoke((MethodInvoker)delegate
            {
                bar.Width = width;
            });
            bar.BackColor = Color.FromArgb(255, forceColor.R, forceColor.G, forceColor.B);
        }

        /// <summary>
        /// Public method to add a new force to the queue to be animated
        /// </summary>
        /// <param name="force">The force of the last punch</param>
        public void PushPunch(float force)
        {
            punchQueue.Enqueue(force);
        }

    }
}
