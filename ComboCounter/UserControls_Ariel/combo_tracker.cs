using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ComboCounter.Forms
{
    public partial class combo_tracker : UserControl
    {

        double max;
        double min;
        double avg;

        #region Global Data
        int transferId;
        string username;
        public int comboScore = 0;
        public double desiredLBS = 110.00;
        public double desiredTime = 500;
        public double combo_target;
        int countHits = 0;
        int guestCount = 1;
        int id;
        List<double> allhits = new List<double>();
        List<double> alltimes = new List<double>();


        //global varibles
        public string in_data;
        SerialPort port;
        DateTime milli;
        TimeSpan time;

        //set variables for connection
        private const String SERVER = "127.0.0.1";
        private const String DATABASE = "project";
        private const String UID = "root";
        private const String PASSWORD = "692Trrbw83";
        private static MySqlConnection dbConn;
        private string hardest_hit;
        private string fastest_hit;
        private string average_hit;
        DateTime selDate = new DateTime();
        string date;

        int combo_points = 1;

        double combo = 0;
        double force = 0;
        double time_m = 0;

        public combo_tracker()
        {
            InitializeComponent();
            InitializeDB();

        }

        public static void InitializeDB()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = SERVER;
            builder.UserID = UID;
            builder.Password = PASSWORD;
            builder.Database = DATABASE;
            builder.SslMode = MySqlSslMode.None;

            String connString = builder.ToString();

            builder = null;

            Console.WriteLine(connString);

            dbConn = new MySqlConnection(connString);

            Application.ApplicationExit += (sender, args) =>
            {
                if (dbConn != null)
                {
                    dbConn.Dispose();
                    dbConn = null;
                }
            };
        }

        private void combo_tracker_Load(object sender, EventArgs e)
        {
            getName();
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
            catch
            {

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

            //time_m = Convert.ToDouble(milli);
            force = Convert.ToDouble(in_data);

            double convertedToDouble = Convert.ToDouble(milli.ToString("fff"));

            combo_target = 80.00;

            if (force >= combo_target || force <= 1000)
            {
                countHits = countHits + 1;
                hits_tb.Text = countHits.ToString();
                allhits.Add(Convert.ToDouble(in_data));
                alltimes.Add(convertedToDouble);
                force_textbox.ForeColor = Color.FromArgb(0, 255, 0);
            }

            else if (force < combo_target)
            {
                force_textbox.ForeColor = Color.FromArgb(255, 0, 0);
            }

            if (force >= desiredLBS && convertedToDouble <= desiredTime)
            {
                comboScore++;

            }
            combo_tb.Text = comboScore.ToString();

        }

        #endregion

        private void save_session_btn_Click(object sender, EventArgs e)
        {
            String query6 = "SELECT id FROM project.users WHERE isloggedin=1;";

            MySqlCommand cmd6 = new MySqlCommand(query6, dbConn);
            dbConn.Open();

            MySqlDataReader reader = cmd6.ExecuteReader();

            while (reader.Read())
            {
                id = Convert.ToInt32((reader["id"]));

            }
            reader.Close();

            dbConn.Close();

            if (players_cb.SelectedItem.Equals(username))
            {
                try
                {
                    max = allhits.Max();
                    min = alltimes.Min();
                    avg = allhits.Average();
                    date = DateTime.Now.ToString("yyyyMMdd");
                }
                catch
                {
                    MessageBox.Show("No hits to record!");
                }


                String query = "INSERT INTO project.history(hits,date,hardest_hit,average_hit, id) VALUES(@hits,'" + date + "','" + max + "','" + avg + "','" + id + "');";
                String query2 = "INSERT INTO project.history2(time,date, fastest_hit, id) VALUES(@time,'" + date + "','" + min + "','" + id + "');";

                MySqlCommand cmd = new MySqlCommand(query, dbConn);
                MySqlCommand cmd2 = new MySqlCommand(query2, dbConn);


                dbConn.Open();

                cmd.Parameters.Add("@hits", MySqlDbType.VarChar);
                cmd2.Parameters.Add("@time", MySqlDbType.VarChar);

                foreach (object value in allhits)
                {
                    cmd.Parameters["@hits"].Value = value;
                    cmd.ExecuteNonQuery();
                }

                foreach (var value2 in alltimes)
                {
                    cmd2.Parameters["@time"].Value = value2;
                    cmd2.ExecuteNonQuery();
                }

                dbConn.Close();
            }

            else
            {
                MessageBox.Show("Guest user does not have a save function!");
            }

        }

        private void reset_player_btn_Click(object sender, EventArgs e)
        {
            countHits = 0;
            hits_tb.Clear();
            force_textbox.Clear();
            time_textbox.Clear();
            combo_tb.Clear();
            allhits.Clear();
            alltimes.Clear();

        }

        private void add_btn_Click(object sender, EventArgs e)
        {

            players_cb.Items.Add("Guest " + guestCount.ToString());
            players_cb.SelectedIndex = guestCount;

            guestCount = guestCount + 1;

        }
        public void getName()
        {
            String query = "SELECT username FROM project.users WHERE isloggedin=1;";

            MySqlCommand cmd = new MySqlCommand(query, dbConn);
            dbConn.Open();

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                username = (reader["username"]).ToString();

            }
            reader.Close();

            dbConn.Close();

            players_cb.Items.Add(username);
            players_cb.SelectedIndex = 0;
        }

        public int getID()
        {

            return id;
        }

        private void players_cb_SelectedIndexChanged(object sender, EventArgs e)
        {

            countHits = 0;
            hits_tb.Clear();
            force_textbox.Clear();
            time_textbox.Clear();
            combo_tb.Clear();
        }
    }

}
