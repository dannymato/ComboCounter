using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ComboCounter
{
    public partial class user_control : UserControl
    {
        private const String SERVER = "127.0.0.1";
        private const String DATABASE = "project";
        private const String UID = "root";
        private const String PASSWORD = "692Trrbw83";
        private static MySqlConnection dbConn;
        private string username;
        private string password;
        public string fname;
        public string lname;

        public user_control()
        {
            //InitializeComponent();
            // InitializeDB();
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

        public void getInfo()
        {
            String query = "SELECT username, password, fname, lname, age,sex,class, height, weight,id FROM project.users WHERE isloggedin=1;";

            MySqlCommand cmd = new MySqlCommand(query, dbConn);
            dbConn.Open();

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                username = (reader["username"]).ToString();
                password = (reader["password"]).ToString();
                fname = (reader["fname"]).ToString();
                lname = (reader["lname"]).ToString();
                // age_tb.Text = (reader["age"]).ToString();
                //  id.Text = (reader["id"]).ToString();
                //  height_tb.Text = (reader["height"]).ToString();
                //  weight_tb.Text = (reader["weight"]).ToString();
                // cl.Text = (reader["class"]).ToString();
                //   sex_tb.Text = (reader["age"]).ToString();

            }
            reader.Close();

            dbConn.Close();

            //  name_tb.Text = fname + " " + lname;
        }

        private void user_control_Load(object sender, EventArgs e)
        {
            // getInfo();
        }
    }
}
