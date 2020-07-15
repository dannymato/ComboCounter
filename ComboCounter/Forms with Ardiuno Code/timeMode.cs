using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Windows.Forms;
using ComboCounter.Forms;

namespace ComboCounter.UserControls
{
    public partial class timeMode : UserControl
    {
        //combo_tracker ct = new combo_tracker();

        bool timeButtonClicked = false;
        bool forceButtonClicked = false;

        int targetTime = 0;
        double targetForce = 0;
        double currentTime;
        double currentForce = 0;

        List<double> allhits = new List<double>();
        List<double> alltimes = new List<double>();

        //global varibles
        string in_data;
        SerialPort port;
        DateTime milli;

        public timeMode()
        {
            InitializeComponent();
        }

        private void vstimeBtn_Click(object sender, EventArgs e)
        {

        }

        private void vsforceBtn_Click(object sender, EventArgs e)
        {

        }
        /*
private void vstimeBtn_Click_1(object sender, EventArgs e)
{
targetTime = Convert.ToInt32(time_textbox.Text);
int n = 0;

while (n < targetTime)
{
currentTime_tb.Text = n.ToString();
System.Threading.Thread.Sleep(10);

n++;
}
}

private void vsforceBtn_Click(object sender, EventArgs e)
{
targetForce = Convert.ToDouble(force_textbox.Text);
forceButtonClicked = true;
}

private void timeMode_Load(object sender, EventArgs e)
{
in_data = ct.in_data;
}


private void vsforceBtn_Click_1(object sender, EventArgs e)
{
currentForce = Convert.ToDouble(in_data);
if (currentForce >= 80.00)
{
currentForce_tb.Text = currentForce.ToString();

if (currentForce >= targetForce)
{
  MessageBox.Show("Stop Target Reached");
}





}
}*/
    }

}
