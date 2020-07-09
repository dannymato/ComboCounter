using System.Drawing;
using System.Runtime.CompilerServices;

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
        private static UserSettings _UserSettings;
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
        public static int GetId() { return id; }

        private static void SetId(int value)
        { id = value; }

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

        public static void ChangeAscendingClock(bool ascendingClock)
        {
            _UserSettings.AscendingClock = ascendingClock;
            DBConnection.getInstance().UpdateUserSettings(id, _UserSettings);
        }
        public static void ChangeTurnOffTimer(bool turnOffTimer)
        {
            _UserSettings.TurnOffTimers = turnOffTimer;
            DBConnection.getInstance().UpdateUserSettings(id, _UserSettings);
        }
        public static void ChangeTurnOffVisualFeedback(bool visualFeedback)
        {
            _UserSettings.TurnOffVisualFeedback = visualFeedback;
            DBConnection.getInstance().UpdateUserSettings(id, _UserSettings);
        }
        public static void ChangeHitSounds(bool hitSounds)
        {
            _UserSettings.TurnOffHitSounds = hitSounds;
            DBConnection.getInstance().UpdateUserSettings(id, _UserSettings);
        }
        public static void ChangeMissSounds(bool missSounds)
        {
            _UserSettings.TurnOffMissSounds = missSounds;
            DBConnection.getInstance().UpdateUserSettings(id, _UserSettings);
        }
        public static void ChangeColorScheme(int colorScheme)
        {
            _UserSettings.ColorScheme = colorScheme;
            DBConnection.getInstance().UpdateUserSettings(id, _UserSettings);
        }

        public static bool AscendingClockSetting() { return _UserSettings.AscendingClock; }
        public static bool TimerSetting() { return _UserSettings.TurnOffTimers; }
        public static bool HitSoundSetting() { return _UserSettings.TurnOffHitSounds; }
        public static bool MissSoundSetting() { return _UserSettings.TurnOffMissSounds; }
        public static bool VisualFeedbackOff() { return _UserSettings.TurnOffVisualFeedback; }
        public static void SetUserSettings(UserSettings userSettings) { _UserSettings = userSettings; }
        

#endif

    }

    struct UserSettings
    {
        // If true the clock for the different mode will tick upwards from zero
        // Otherwise the clock will go down from the target towards zero
        public bool AscendingClock;
        public int ColorScheme;
        // If it is true the timers will stop when the page is no longer displayed
        public bool TurnOffTimers;
        // If true the screen will not show visual feedback when there is a punch
        public bool TurnOffVisualFeedback;
        // If true the sounds for hitting will be disabled
        public bool TurnOffHitSounds;
        // If true the sounds for missing will be disabled
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
