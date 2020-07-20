using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ComboCounter.Classes
{
    class DBConnection
    {
        private const String SERVER = "localhost";
        private const String DATABASE = "combo_counter";
        private const String UID = "root";
        private const String PASSWORD = "1234";
        private static MySqlConnection dbConn;

        private static DBConnection instance;


        /// <summary>
        /// Returns an instance of DBConnection if it has been created
        /// Creates a new instance using the private constructor and returns otherwise
        /// </summary>
        /// <returns></returns>
        public static DBConnection getInstance()
        {
            if (instance == null)
            {
                instance = new DBConnection();
            }
            return instance;
        }

        private DBConnection()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder()
            {
                Server = SERVER,
                UserID = UID,
                Password = PASSWORD,
                Database = DATABASE,
                SslMode = MySqlSslMode.None
            };

            String connString = builder.ToString();
         
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

        /// <summary>
        /// insertUser takes the inputs and inserts the user information into the database 
        /// If it is successful it returns a new User otherwise it returns null
        /// </summary>
        /// <param name="id"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="fName"></param>
        /// <param name="lName"></param>
        /// <param name="sex"></param>
        /// <param name="height"></param>
        /// <param name="weight"></param>
        /// <param name="year"></param>
        /// <returns>If successful the new user, null otherwise</returns>
        public User insertUser(int id, String username, String password, String fName, String lName, String sex,
            int height, int weight, int year)
        { 
            String query = "INSERT into " + DATABASE + ".user(user_id, username, password, first_name," +
                " last_name, sex, height, weight, birth_year) values (@id, @username, @password, @fname, @lname, @sex, @height, @weight, @year);";

            MySqlCommand cmd = new MySqlCommand(query, dbConn);
            dbConn.Open();

            cmd.Parameters.AddWithValue("id", id);
            cmd.Parameters.AddWithValue("username", username);
            cmd.Parameters.AddWithValue("password", password);
            cmd.Parameters.AddWithValue("fname", fName);
            cmd.Parameters.AddWithValue("lname", lName);
            cmd.Parameters.AddWithValue("sex", sex.ToUpper());
            cmd.Parameters.AddWithValue("height", height);
            cmd.Parameters.AddWithValue("weight", weight);
            cmd.Parameters.AddWithValue("year", year);

            int success = cmd.ExecuteNonQuery();
            dbConn.Close();

            if (success == 1)
            {
                User newUser = new User(id, username, password, fName, lName, sex, height, weight, year);

                return newUser;
            }
            return null;

        }

        /// <summary>
        /// getLogin checks the login information against the information stored in the database
        /// If the login info is correct the user's information is pulled from the database and is returned
        /// If the login info is incorrect a null value is returned
        /// </summary>
        /// <param name="uName">The username provided in the login form</param>
        /// <param name="pWord">The password provided in the login form</param>
        /// <returns></returns>
        public User getLogin(string uName, string pWord)
        {
            String query = "SELECT username, password FROM " + DATABASE + ".user WHERE username=@username";

            MySqlCommand verifyCmd = new MySqlCommand(query, dbConn);
            dbConn.Open();
            verifyCmd.Parameters.AddWithValue("username", uName);

            MySqlDataReader reader = verifyCmd.ExecuteReader();

            bool isCorrect = false;

            while (reader.Read())
            {
                isCorrect = pWord == (reader["password"].ToString());
            }

            reader.Close();

            if (isCorrect)
            {
                String getUserQuery = "SELECT * FROM " + DATABASE + ".user WHERE username = @username";

                MySqlCommand getUserCmd = new MySqlCommand(getUserQuery, dbConn);

                getUserCmd.Parameters.AddWithValue("username", uName);
                MySqlDataReader userReader = getUserCmd.ExecuteReader();

                User newUser;

                if (userReader.Read())
                {
                    newUser = new User(
                        userReader.GetInt32("user_id"),
                        userReader.GetString("username"),
                        userReader.GetString("password"),
                        userReader.GetString("first_name"),
                        userReader.GetString("last_name"),
                        userReader.GetString("sex"),
                        userReader.GetInt32("height"),
                        userReader.GetInt32("weight"),
                        userReader.GetInt32("birth_year")
                        );
                    dbConn.Close();
                    return newUser;
                }
                dbConn.Close();
                return null;

            }
            dbConn.Close();
            return null;
        }
        /// <summary>
        /// Creates a new UserSettings row for the new user with the default values
        /// </summary>
        /// <param name="UserID">The user that the UserSettings applies to</param>
        /// <returns>Return the newly created UserSettings</returns>
        public UserSettings CreateNewUserSettings(int UserID)
        {
            dbConn.Open();
            string Query = "INSERT INTO " + DATABASE + ".user_settings" +
                " (`fk_user_id`) VALUES (@userID);";

            MySqlCommand cmd = new MySqlCommand(Query, dbConn);

            cmd.Parameters.AddWithValue("userID", UserID);
            int success = cmd.ExecuteNonQuery();

            dbConn.Close();
            
            if (success >= 0)
            {
                return ReadUserSettings(UserID);
            }
            return new UserSettings();

        }

        /// <summary>
        /// Read the specified user settings from the database
        /// </summary>
        /// <param name="userID">The userID of the user we want UserSettings for</param>
        /// <returns>The UserSettings retrieved from the database or a blank UserSettings if it is not successful</returns>
        public UserSettings ReadUserSettings(int userID) {

            dbConn.Open();

            string Query = "SELECT color_scheme, AscendingClock, TurnOffTimers, TurnOffVisualFeedback," +
                    "TurnOffHitSounds, TurnOffMissSounds, Use24HourClock FROM " + DATABASE + ".user_settings " +
                    "WHERE fk_user_id = @userID;";

            MySqlCommand readSettingsCmd = new MySqlCommand(Query, dbConn);
            readSettingsCmd.Parameters.AddWithValue("userID", userID);

            MySqlDataReader reader = readSettingsCmd.ExecuteReader();

            

            if (reader.Read())
            {
                UserSettings settings = new UserSettings(
                    reader.GetInt32("color_scheme"),
                    reader.GetBoolean("AscendingClock"),
                    reader.GetBoolean("TurnOffTimers"),
                    reader.GetBoolean("TurnOffVisualFeedback"),
                    reader.GetBoolean("TurnOffHitSounds"),
                    reader.GetBoolean("TurnOffMissSounds"),
                    reader.GetBoolean("Use24HourClock")
                    );
                dbConn.Close();
                return settings;
            }
            dbConn.Close();
            return new UserSettings();

        }

        /// <summary>
        /// Sends an update query to the database to update the specified user's user settings
        /// Currently all the settings are push at the same time regardless of how many settings are
        /// updated
        /// </summary>
        /// <param name="userID">ID for the user who's settings are being updated</param>
        /// <param name="userSettings">Setting data to be pushed to the database</param>
        /// <returns>Returns a new usersettings if the database query is unsuccessful</returns>
        public UserSettings UpdateUserSettings (int userID, UserSettings userSettings)
        {
            string Query = "UPDATE " + DATABASE + ".user_settings " +
                "SET color_scheme = @colorScheme, AscendingClock = @ascendingClock, " +
                "TurnOffTimers = @turnOffTimers, TurnOffVisualFeedback = @TurnOffVisualFeedback, " +
                "TurnOffHitSounds = @turnOffHitSounds, TurnOffMissSounds = @turnOffMissSounds ," +
                "Use24HourClock = @use24hClock WHERE fk_user_id = @userID";

            dbConn.Open();
            MySqlCommand cmd = new MySqlCommand(Query, dbConn);

            cmd.Parameters.AddWithValue("colorScheme", userSettings.ColorScheme);
            cmd.Parameters.AddWithValue("ascendingClock", userSettings.AscendingClock);
            cmd.Parameters.AddWithValue("turnOffTimers", userSettings.TurnOffTimers);
            cmd.Parameters.AddWithValue("TurnOffVisualFeedback", userSettings.TurnOffVisualFeedback);
            cmd.Parameters.AddWithValue("turnOffHitSounds", userSettings.TurnOffHitSounds);
            cmd.Parameters.AddWithValue("turnOffMissSounds", userSettings.TurnOffMissSounds);
            cmd.Parameters.AddWithValue("use24hClock", userSettings.ToggleClock);
            cmd.Parameters.AddWithValue("userID", userID);

            int success = cmd.ExecuteNonQuery();
            dbConn.Close();
            if (success >= 0)
            {
                return userSettings;
            }
            return new UserSettings();

        }


        public UsrAccount UpdateUserAccount(int userID, UsrAccount userAccount)
        {
            string Query = "UPDATE " + DATABASE + ".user " +
                "SET username = @userName, password = @password, " +
                "first_name = @firstName, last_name = @lastName, " +
                "sex = @sex, birth_year = @year , height = @height ," +
                "weight = @weight WHERE user_id = @userID";

            dbConn.Open();
            MySqlCommand cmd = new MySqlCommand(Query, dbConn);

            cmd.Parameters.AddWithValue("userName", userAccount.UserName);
            cmd.Parameters.AddWithValue("password", userAccount.Password);
            cmd.Parameters.AddWithValue("firstName", userAccount.FirstName);
            cmd.Parameters.AddWithValue("lastName", userAccount.LastName);
            cmd.Parameters.AddWithValue("sex", userAccount.Sex);
            cmd.Parameters.AddWithValue("height", userAccount.UserHeight);
            cmd.Parameters.AddWithValue("weight", userAccount.UserWeight);
            cmd.Parameters.AddWithValue("userID", userID);
            cmd.Parameters.AddWithValue("year", userAccount.UserYear);

            int success = cmd.ExecuteNonQuery();
            dbConn.Close();
            if (success >= 0)
            {
                return userAccount;
            }
            return new UsrAccount();

        }




        /// <summary>
        /// Retrieves all the Sessions for the specified user
        /// This includes an additional DB call for each session to retrieve the data
        /// </summary>
        /// <param name="userID">User who's sessions we want to retrieve</param>
        /// <returns>List of the Sessions that belong to the specified user</returns>
        public List<Session> GetSessions(int userID)
        {

            string Query = "SELECT workout_sessionid, date, workout_application " +
                "FROM " + DATABASE + ".workout_sessions " +
                "WHERE user_id = @user_id";

            dbConn.Open();

            MySqlCommand command = new MySqlCommand(Query, dbConn);
            command.Parameters.AddWithValue("user_id", userID);

            MySqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                
                List<Session> sessions = new List<Session>();
                while (reader.Read())
                {
                    sessions.Add(new Session(reader.GetDateTime("date"), reader.GetInt32("workout_sessionid"), (WorkoutApplication)reader.GetInt16("workout_application")));
                }

                dbConn.Close();

                for (int i = 0; i < sessions.Count; i++)
                {
                    sessions[i] = AddDataToSession(sessions[i]);
                    if (sessions[i].Forces.Count == 0 || sessions[i].Times.Count == 0)
                        sessions.RemoveAt(i);
                    
                }

                return sessions;

            }
            dbConn.Close();
            return new List<Session>();

        }

        /// <summary>
        /// Gets all the data from the specific session and adds it to the session
        /// The sessionID variable is required to be set if not the session will retrieve the wrong data
        /// </summary>
        /// <param name="session">The session we want to add the data to</param>
        /// <returns>The session with the correct data or null if the DB read was unsuccessful</returns>
        public Session AddDataToSession(Session session)
        {
            string Query = "SELECT `index`, `force`, `time_interval` " +
                "FROM " + DATABASE + ".hit_data " +
                "WHERE session_id = @sessionID " +
                "ORDER BY `index`";

            dbConn.Open();

            MySqlCommand sqlCommand = new MySqlCommand(Query, dbConn);
            sqlCommand.Parameters.AddWithValue("sessionID", session.SessionID);

            MySqlDataReader reader = sqlCommand.ExecuteReader();

            if (reader.HasRows)
            {
                while(reader.Read())
                {
                    session.insertHit(
                        reader.GetFloat("force"),
                        reader.GetFloat("time_interval"));
                }

                dbConn.Close();
                return session;

            }
            dbConn.Close();
            return null;

        }
        
        /// <summary>
        /// Retrieves a session from the database from the sessionID and sessionStart
        /// </summary>
        /// <param name="sessionID">The sessionID of the requested session</param>
        /// <param name="sessionStart">Start date of the session</param>
        /// <returns></returns>
        public Session GetSession(int sessionID, DateTime sessionStart)
        {
            string Query = "SELECT index, force, time_interval " +
                "FROM " + DATABASE + ".hit_data " +
                "WHERE session_id = @sessionID " +
                "ORDER BY index";

            dbConn.Open();

            MySqlCommand sessionCommand = new MySqlCommand(Query, dbConn);

            sessionCommand.Parameters.AddWithValue("sessionID", sessionID);

            MySqlDataReader reader = sessionCommand.ExecuteReader();

            if (reader.HasRows)
            {
                
                Session session = new Session(sessionStart);
                while (reader.Read())
                {
                    session.insertHit(reader.GetFloat("force"), 
                        reader.GetFloat("time_interval"));   

                }

                dbConn.Close();
                return session;

            }
            return null;

        }

        public Session GetSession(int sessionID, DateTime sessionStart, bool isAlreadyOpen)
        {
            string Query = "SELECT index, force, time_interval " +
                "FROM " + DATABASE + ".hit_data " +
                "WHERE session_id = @sessionID " +
                "ORDER BY index";

            if (!isAlreadyOpen)
                dbConn.Open();

            MySqlCommand sessionCommand = new MySqlCommand(Query, dbConn);

            sessionCommand.Parameters.AddWithValue("sessionID", sessionID);

            MySqlDataReader reader = sessionCommand.ExecuteReader();

            if (reader.HasRows)
            {

                Session session = new Session(sessionStart);
                while (reader.Read())
                {
                    session.insertHit(reader.GetFloat("force"),
                        reader.GetFloat("time_interval"));

                }

                dbConn.Close();
                return session;

            }
            return null;

        }

        /// <summary>
        /// Inserts a new workout session into the database to be associated to the specific user
        /// </summary>
        /// <param name="userID">The userID of the user that the session belongs to</param>
        /// <param name="session">The session that is to be pushed to the database</param>
        public void InsertSession(int userID, Session session)
        {
            // Inserts the session to the workout_sessions table
            string Query = "INSERT INTO " + DATABASE + ".workout_sessions (user_id, date, workout_application)" +
                "VALUES (@userID, @date @workoutApplication);" +
                "SELECT LAST_INSERT_ID();";

            dbConn.Open();

            MySqlCommand cmd = new MySqlCommand(Query, dbConn);

            cmd.Parameters.AddWithValue("userID", userID);
            cmd.Parameters.AddWithValue("date", session.StartDate);
            cmd.Parameters.AddWithValue("workoutApplication", session.application);

            int newSessionID;

            object result = cmd.ExecuteScalar();

            if (result != null)
            {
                newSessionID = Convert.ToInt32(result);
            }
            else
            {
                return;
            }

            // Inserts the hit data to the hit_data table
            string InsertHitQuery = "INSERT INTO " + DATABASE + ".hit_data (`index`, `force`, `time_interval`, `session_id`) " +
                "VALUES (@index, @force, @time_interval, @sessionID);";

            cmd = new MySqlCommand(InsertHitQuery, dbConn);

            cmd.Parameters.Add("index", MySqlDbType.Int32);
            cmd.Parameters.Add("force", MySqlDbType.Float);
            cmd.Parameters.Add("time_interval", MySqlDbType.Float);
            cmd.Parameters.AddWithValue("sessionID", newSessionID);

            for (int i = 0; i < session.Forces.Count; i++)
            {
                cmd.Parameters[0].Value = i;
                cmd.Parameters[1].Value = session.Forces[i];
                cmd.Parameters[2].Value = session.Times[i];

                cmd.ExecuteNonQuery();
            }

            dbConn.Close();
        }
    }
}