using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using ComboCounter.Classes;
using MySql.Data.MySqlClient;

namespace ComboCounter.UserControls
{
    public partial class histogram : UserControl
    {
        //set variables for connection
        // List<string> allhits = new List<string>();
        //List<string> alltimes = new List<string>();
        List<string> allhits = new List<string>();
        DataSet ds = new DataSet();
        DataSet ds2 = new DataSet();

        int id;
        private const String SERVER = "127.0.0.1";
        private const String DATABASE = "project";
        private const String UID = "root";
        private const String PASSWORD = "";
        private static MySqlConnection dbConn;
        private string hardest_hit;
        private string fastest_hit;
        private string average_hit;
        DateTime selDate = new DateTime();
        DateTime date = new DateTime();

        public histogram()
        {
            InitializeComponent();

            InitializeDB();

            selDate = dateTimePicker1.Value;

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            hardest_hit = null;
            fastest_hit = null;
            average_hit = null;
            hitsTime_tb.Clear();
            time_tb.Clear();
            ds.Clear();
            ds2.Clear();

            getID();
            selDate = dateTimePicker1.Value;
            getStats();
            textBox2.Text = hardest_hit;
            textBox3.Text = fastest_hit;
            textBox4.Text = average_hit;

            if (date.ToString("yyyyMMdd").Equals(getDateTime()))
            {
                //MessageBox.Show("THIS DATE HAS DATA");     
                int rowsCount = ds.Tables[0].Rows.Count;
                int rowsCount2 = ds2.Tables[0].Rows.Count;

                for (int i = 0; i < rowsCount; i++)
                {
                    this.hitsTime_tb.Text = this.hitsTime_tb.Text + ds.Tables[0].Rows[i][0].ToString() + Environment.NewLine;
                }
                for (int i = 0; i < rowsCount2; i++)
                {
                    this.time_tb.Text = this.time_tb.Text + ds2.Tables[0].Rows[i][0].ToString() + Environment.NewLine;
                }
            }
            else
            {
                hardest_hit = null;
                fastest_hit = null;
                average_hit = null;
                hitsTime_tb.Clear();
                time_tb.Clear();
                ds.Dispose();
                ds2.Dispose();
            }


        }

        public string getDateTime()
        {
            string date;
            selDate = dateTimePicker1.Value;
            date = selDate.ToString("yyyyMMdd");
            return date;
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

        public void getID()
        {
            String query = "SELECT id FROM project.users WHERE isloggedin=1;";

            MySqlCommand cmd = new MySqlCommand(query, dbConn);
            dbConn.Open();

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                id = Convert.ToInt32((reader["id"]));

            }
            reader.Close();

            dbConn.Close();

        }


        public void getStats()
        {

            String query = "SELECT hardest_hit, average_hit, date FROM project.history WHERE id ='" + id + "' AND date ='" + getDateTime() + "';";
            String query2 = "SELECT fastest_hit, date FROM project.history2 WHERE id ='" + id + "' AND date ='" + getDateTime() + "';";

            MySqlCommand cmd = new MySqlCommand(query, dbConn);
            MySqlCommand cmd2 = new MySqlCommand(query2, dbConn);

            dbConn.Open();


            MySqlDataReader reader2 = cmd2.ExecuteReader();

            while (reader2.Read())
            {
                fastest_hit = (reader2["fastest_hit"]).ToString();
            }
            reader2.Close();

            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {

                hardest_hit = (reader["hardest_hit"]).ToString();
                average_hit = (reader["average_hit"]).ToString();
                date = (Convert.ToDateTime(reader["date"]));


            }

            reader.Close();
            dbConn.Close();

            using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT hits FROM project.history WHERE id ='" + id + "' AND date ='" + getDateTime() + "';", dbConn))
            {
                dataAdapter.Fill(ds);
            }

            using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT time FROM project.history2 WHERE id ='" + id + "' AND date ='" + getDateTime() + "';", dbConn))
            {
                dataAdapter.Fill(ds2);
            }


        }

        private void histogram_Load(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            var chartSeries = new Series
            {
                Name = "Linechart",
                Color = System.Drawing.Color.CadetBlue,
                IsVisibleInLegend = false,
                IsXValueIndexed = false,
                ChartType = SeriesChartType.Line
            };

            this.chart1.Series.Add(chartSeries);

            Session session = History.GetSessions()[0];

            for (int i = 0; i < Math.Min(session.Forces.Count, session.Times.Count); i++)
            {
                chartSeries.Points.AddXY(session.Times[i], session.Forces[i]);
            }

            chartSeries.BorderWidth = 2;

            chart1.Invalidate();

            chart1.ChartAreas[0].BackColor = System.Drawing.Color.Transparent;

        }
    }
}
