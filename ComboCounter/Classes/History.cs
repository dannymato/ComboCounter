using System.Collections.Generic;

namespace ComboCounter.Classes
{
    class History
    {

        private static List<Session> Sessions;

        /// <summary>
        /// Private method to create the sessions list if it has not yet been created
        /// </summary>
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

        /// <summary>
        /// Inserts a session to the database and into the local list of workout sessions
        /// </summary>
        /// <param name="newSession"></param>
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

    }
}
