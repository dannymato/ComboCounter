using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace ComboCounter
{
    public partial class force_tracker_form : Form
    {
        #region Global Data
        //global varibles
        string in_data;
        SerialPort port;
        DateTime milli;
        TimeSpan time;

        public force_tracker_form()
        { InitializeComponent(); }
        #endregion

        #region Load Arduino Sensor
        //Connect to arduino sensor on load.
        private void force_tracker_form_Load(object sender, EventArgs e)
        {
            port = new SerialPort();
            port.BaudRate = 9600;
            port.PortName = "COM3";
            port.Parity = Parity.None;
            port.DataBits = 8;
            port.StopBits = StopBits.One;
            port.DataReceived += getData;

            try
            {
                port.Open();
                //force_textbox.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        #endregion

        #region Capture and Display Data
        //Capture data from arduino and trigger new event
        public void getData(object sender, SerialDataReceivedEventArgs e)
        {
            in_data = port.ReadLine();
            this.Invoke(new EventHandler(displaydata_event));
        }

        //Event to display data captures from arduino
        void displaydata_event(object sender, EventArgs e)
        {
            force_textbox.Text = in_data;
            milli = DateTime.Now;
            time_textbox.Text = milli.ToString("fff");

        }
        #endregion


    }
}
