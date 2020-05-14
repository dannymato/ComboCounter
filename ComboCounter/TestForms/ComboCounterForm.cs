using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Windows.Forms;

namespace ComboCounter
{
    public partial class ComboCounterForm : Form
    {

        private static SerialPort port;
        private DateTime datetime;
        private string in_data;
        private int punchCounter;
        // private int punch;
        private int max;
        private List<int> allForces = new List<int>();
        private int targetForce = 0;
        private string userInput;
        private string var;
        private int userInputConversion;


        public ComboCounterForm()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            port = new SerialPort();

            port.BaudRate = 9600;
            port.PortName = "COM3";
            port.Parity = Parity.None;
            port.DataBits = 8;
            port.StopBits = StopBits.One;
            port.DataReceived += Port_DataReceived;

            try
            {
                port.Open();
                resultBox.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

        }

        private void Port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            in_data = port.ReadLine();
            //punch = Convert.ToInt32(in_data);
            this.Invoke(new EventHandler(displaydata_event));
        }

        private void displaydata_event(object sender, EventArgs e)
        {

            datetime = DateTime.Now;
            string time = datetime.Millisecond + " Millisecond";

            punchCounter++;
            resultBox.AppendText(time + " <--Time / Force--> " + in_data + " lbs" + "\n");
            //resultBox.Text = in_data;


        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            resultBox.Clear();
            counterDisplay.Clear();
            hardestPunch.Clear();

            max = 0;
            punchCounter = 0;
        }

        private void resultBox_TextChanged(object sender, EventArgs e)
        {

        }
    }



}
