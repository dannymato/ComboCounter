using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ComboCounter.Classes
{
    class History
    {
        //set variables for connection
        /*private const String SERVER = "127.0.0.1";
        private const String DATABASE = "project";
        private const String UID = "root";
        private const String PASSWORD = "692Trrbw83";
        private static MySqlConnection dbConn;
        private string hardest_hit;
        private string fastest_hit;
        private string average_hit;
        private DateTime date;*/

        private static List<Session> Sessions;

        private static void CreateSessions()
        {
            Sessions = DBConnection.getInstance()
                .GetSessions(UserManager.GetId());
        }

        /// <summary>
        /// Creates the sessions array if it has not yet been created.
        /// Allows the sessions to be shared by many pages without
        /// being garbage collected
        /// </summary>
        /// <returns>The current state of the Session list</returns>
        public static List<Session> GetSessions()
        {
            if (Sessions == null)
            {
                CreateSessions();
            }
            return Sessions;
        }


        public static void InsertSession(Session newSession)
        {

            if (Sessions == null)
            {
                CreateSessions();
            }

            DBConnection db = DBConnection.getInstance();

            db.InsertSession(UserManager.GetId(), newSession);

            Sessions.Add(newSession);

        }

        // Leftover code from previous group where the database was being called by each page.
        // Now defuct as the history is 
        /*public static void InitializeDB()
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
        }*/


        /*public DateTime getDate()
        {
            String query = "SELECT date FROM project.history WHERE id = 0";

            MySqlCommand cmd = new MySqlCommand(query, dbConn);

            dbConn.Open();

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                date = Convert.ToDateTime(reader["date"]);

            }
            reader.Close();

            dbConn.Close();

            return date;
        }


        public string gethardestHit()
        {
            DateTime currDate = new DateTime(2020, 3, 1, 7, 47, 0);

            String query = "SELECT hardest_hit FROM project.history WHERE id = 0 AND date ='" + currDate + "';";

            MySqlCommand cmd = new MySqlCommand(query, dbConn);

            dbConn.Open();

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                hardest_hit = (reader["hardest_hit"]).ToString();

            }
            reader.Close();

            dbConn.Close();

            return hardest_hit;
        }

        public string getfastestHit()
        {
            DateTime currDate = new DateTime(2020, 3, 1, 7, 47, 0);

            String query = "SELECT fastest_hit FROM project.history WHERE id = 0 AND date ='" + currDate + "';";

            MySqlCommand cmd = new MySqlCommand(query, dbConn);

            dbConn.Open();

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                fastest_hit = (reader["fastest_hit"]).ToString();

            }
            reader.Close();

            dbConn.Close();

            return fastest_hit;
        }

        public string getaverageHit()
        {
            DateTime currDate = new DateTime(2020, 3, 1, 7, 47, 0);

            String query = "SELECT average_hit FROM project.history WHERE id = 0 AND date ='" + currDate + "';";

            MySqlCommand cmd = new MySqlCommand(query, dbConn);

            dbConn.Open();

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                average_hit = (reader["Average_hit"]).ToString();

            }
            reader.Close();

            dbConn.Close();

            return average_hit;
        }*/

    }
}
