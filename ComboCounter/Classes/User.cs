using System;

namespace ComboCounter
{
    /// <summary>
    /// Represents the user as it is shown in the database
    /// </summary>
    class User
    {

        public int Id { get; private set; }
        public String Username { get; private set; }
        public String Password { get; private set; }
        public String fname { get; set; }
        public String lname { get; set; }
        public String sex { get; set; }

#if NEW_DB 

        public int year { get; set; }
        public int height { get; set; }
        public int weight { get; set; }
#else
        public String c_lass { get; set; }

        public String height { get; set; }
        public String weight { get; set; }

        public int age { get; set; }
#endif

#if NEW_DB
        /// <summary>
        /// Initializes a new user with the paramaters shown
        /// </summary>
        /// <param name="id">Individual user ID</param>
        /// <param name="u">Username</param>
        /// <param name="p">Password</param>
        /// <param name="f">First Name</param>
        /// <param name="l">Last Name</param>
        /// <param name="s">Sex</param>
        /// <param name="c">Weight Class</param>
        /// <param name="h">Height</param>
        /// <param name="w">Weight</param>
        /// <param name="a">Age</param>
        public User(int id, String u, String p, String f, String l, 
            String s, int h, int w, int y)
        {
            Id = id;
            Username = u;
            Password = p;
            fname = f;
            lname = l;
            sex = s;
            height = h;
            weight = w;
            year = y;
        }


#else
        /// <summary>
        /// Initializes a new user with the paramaters shown
        /// </summary>
        /// <param name="id">Individual user ID</param>
        /// <param name="u">Username</param>
        /// <param name="p">Password</param>
        /// <param name="f">First Name</param>
        /// <param name="l">Last Name</param>
        /// <param name="s">Sex</param>
        /// <param name="c">Weight Class</param>
        /// <param name="h">Height</param>
        /// <param name="w">Weight</param>
        /// <param name="a">Age</param>
        public User(int id, String u, String p, String f, String l, String s, String c, String h, String w, int a)
        {
            Id = id;
            Username = u;
            Password = p;
            fname = f;
            lname = l;
            sex = s;
            c_lass = c;
            height = h;
            weight = w;
            age = a;
        }

#endif




    }
}
