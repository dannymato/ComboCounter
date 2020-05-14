using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ComboCounter
{
    public partial class home_user : UserControl
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

        public home_user()
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

        public void getName()
        {
            String query = "SELECT username, password, fname, lname FROM project.users WHERE isloggedin=1;";

            MySqlCommand cmd = new MySqlCommand(query, dbConn);
            dbConn.Open();

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                username = (reader["username"]).ToString();
                password = (reader["password"]).ToString();
                fname = (reader["fname"]).ToString();
                lname = (reader["lname"]).ToString();
            }
            reader.Close();

            dbConn.Close();

            name_lb.Text = fname + " " + lname;
        }

        private void home_user_Load(object sender, EventArgs e)
        {
            getName();
        }
    }
}
