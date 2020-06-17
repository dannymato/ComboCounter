using System;
using System.Windows.Forms;


namespace ComboCounter.Forms
{
    public partial class PunchCount : Form
    {
        int min;
        int sec = 30;
        int forcee = 200;
        public PunchCount()
        {
            InitializeComponent();
            
        }

        public PunchCount(Int32 minutes, Int32 seconds, Int32 force)
        {
            InitializeComponent();
            min = minutes;
            sec = seconds;
            forcee = force;
           
        }
        
        private void punch_count1_Load(object sender, EventArgs e)
        {

        }

        public string force
        {
            get { return (min + ""); }
        }



    }
}

