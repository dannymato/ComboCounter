﻿using System.Drawing;

namespace ComboCounter.Classes
{
    class UserManager
    {

        private static int id;
        private static string username;
        private static string password;
        private static string fname;
        private static string lname;
        private static string sex;
#if !NEW_DB
        private static string c_lass;
        private static string height;
        private static string weight;
        private static int age;
#else
        private static int height;
        private static int weight;
        private static int year;
#endif


#if NEW_DB
        public static UserSettings UserSettings { get; set; }
#endif

        public static void setUser(User user)
        {
            id = user.Id;
            username = user.Username;
            password = user.Password;
            fname = user.fname;
            lname = user.lname;
            sex = user.sex;
#if !NEW_DB
            c_lass = user.c_lass;
            age = user.age;
#endif
            height = user.height;
            weight = user.weight;
        }

        // GETTER SETTER ID
        public static int GetId()
        {
            return id;
        }

        private static void SetId(int value)
        {
            id = value;
        }

        public static User currentUser { get; set; }



        // GETTER SETTER USERNAME
        public static string GetUsername()
        {
            return username;
        }

        private static void SetUsername(string value)
        {
            username = value;
        }


        // GETTER SETTER PASSWORD
        public static string GetPassword()
        {
            return password;
        }

        private static void SetPassword(string value)
        {
            password = value;
        }

        // GETTER SETTER FNAME

        public static string GetFname()
        {
            return fname;
        }

        public static void SetFname(string value)
        {
            fname = value;
        }

        public static string GetLname()
        {
            return lname;
        }

        public static void SetLname(string value)
        {
            lname = value;
        }

        // GETTER SETTER SEX
        public static string GetSex()
        {
            return sex;
        }

        public static void SetSex(string value)
        {
            sex = value;
        }
#if !NEW_DB
        // GETTER SETTER CLASS
        public static string GetClass()
        {
            return c_lass;
        }

        public static void SetClass(string value)
        {
            c_lass = value;
        }

        // GETTER SETTER HEIGHT
        public static string GetHeight()
        {
            return height;
        }

        public static void SetHeight(string value)
        {
            height = value;
        }


        // GETTER SETTER WEIGHT
        public static string GetWeight()
        {
            return weight;
        }

        public static void SetWeight(string value)
        {
            weight = value;
        }


        // GETTER SETTER AGE
        public static int GetAge()
        {
            return age;
        }

        public static void SetAge(int value)
        {
            age = value;
        }
#else
        public static void SetHeight(int value)
        {
            height = value;
        }

        public static int GetHeight() { return height; }

        public static void SetWeight(int value) { weight = value; }

        public static int GetWeight() { return weight; }

        public static int GetYear() { return year; }

        public static void SetYear(int value) { year = value; }

#endif

    }

    struct UserSettings
    {
        public bool AscendingClock;
        public int ColorScheme;
        public bool TurnOffTimers;
        public bool TurnOffVisualFeedback;
        public bool TurnOffHitSounds;
        public bool TurnOffMissSounds;

        public UserSettings(int colorScheme, bool ascendingClock, bool turnOffTimers,
            bool turnOffVisualFeedback, bool turnOffHitSounds, bool turnOffMissSounds)
        {
            AscendingClock = ascendingClock;
            ColorScheme = colorScheme;
            TurnOffTimers = turnOffTimers;
            TurnOffVisualFeedback = turnOffVisualFeedback;
            TurnOffHitSounds = turnOffHitSounds;
            TurnOffMissSounds = turnOffMissSounds;
        }
    }

}
