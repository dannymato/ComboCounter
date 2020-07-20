using System;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace ComboCounter.Classes
{
    class UserManager
    {
        /**

        private static int id;
        private static string username;
        private static string password;
        private static string fname;
        private static string lname;
        private static string sex;
        private static int height;
        private static int weight;
        private static int year;

            **/

        private static UserSettings _UserSettings;
        private static UsrAccount _UsrAccount;
        //private static User _UsrAccount;

        public static void setUser(User user)
        {
            _UsrAccount.Id = user.Id;
            _UsrAccount.UserName = user.Username;
            _UsrAccount.Password = user.Password;
            _UsrAccount.FirstName = user.fname;
            _UsrAccount.LastName = user.lname;
            _UsrAccount.Sex = user.sex;
            _UsrAccount.UserHeight = user.height;
            _UsrAccount.UserWeight = user.weight;
        }

        // GETTER SETTER ID
        public static int GetId() { return _UsrAccount.Id; }

        private static void SetId(int value)
        { _UsrAccount.Id = value; }

        public static User currentUser { get; set; }



        // GETTER SETTER USERNAME
        public static string GetUsername()
        {
            return _UsrAccount.UserName;
        }

        private static void SetUsername(string value)
        {
            _UsrAccount.UserName = value;
        }


        // GETTER SETTER PASSWORD
        public static string GetPassword()
        {
            return _UsrAccount.Password;
        }

        private static void SetPassword(string value)
        {
            _UsrAccount.Password = value;
        }

        // GETTER SETTER FNAME

        public static string GetFname()
        {
            return _UsrAccount.FirstName;
        }

        public static void SetFname(string value)
        {
            _UsrAccount.FirstName = value;
        }

        public static string GetLname()
        {
            return _UsrAccount.LastName;
        }

        public static void SetLname(string value)
        {
            _UsrAccount.LastName = value;
        }

        // GETTER SETTER SEX
        public static string GetSex()
        {
            return _UsrAccount.Sex;
        }

        /**
        public static void SetSex(string value)
        {
            _UsrAccount.Sex = value;
        }

        public static void SetHeight(int value)
        {
            _UsrAccount.UserHeight = value;
        }
        **/
        public static int GetHeight() { return _UsrAccount.UserHeight; }

        public static void SetWeight(int value) { _UsrAccount.UserWeight = value; }

        public static int GetWeight() { return _UsrAccount.UserWeight; }

        public static int GetYear() { return _UsrAccount.UserYear; }

        public static void SetYear(int value) { _UsrAccount.UserYear = value; }

        public static void ChangeAscendingClock(bool ascendingClock)
        {
            _UserSettings.AscendingClock = ascendingClock;
            DBConnection.getInstance().UpdateUserSettings(_UsrAccount.Id, _UserSettings);
        }
        public static void ChangeTurnOffTimer(bool turnOffTimer)
        {
            _UserSettings.TurnOffTimers = turnOffTimer;
            DBConnection.getInstance().UpdateUserSettings(_UsrAccount.Id, _UserSettings);
        }
        public static void ChangeTurnOffVisualFeedback(bool visualFeedback)
        {
            _UserSettings.TurnOffVisualFeedback = visualFeedback;
            DBConnection.getInstance().UpdateUserSettings(_UsrAccount.Id, _UserSettings);
        }
        public static void ChangeHitSounds(bool hitSounds)
        {
            _UserSettings.TurnOffHitSounds = hitSounds;
            DBConnection.getInstance().UpdateUserSettings(_UsrAccount.Id, _UserSettings);
        }
        public static void ChangeMissSounds(bool missSounds)
        {
            _UserSettings.TurnOffMissSounds = missSounds;
            DBConnection.getInstance().UpdateUserSettings(_UsrAccount.Id, _UserSettings);
        }
        public static void ChangeColorScheme(int colorScheme)
        {
            _UserSettings.ColorScheme = colorScheme;
            DBConnection.getInstance().UpdateUserSettings(_UsrAccount.Id, _UserSettings);
        }

        public static void ChangeClockToggle(bool toggleClock)
        {
            _UserSettings.ToggleClock = toggleClock;
            DBConnection.getInstance().UpdateUserSettings(_UsrAccount.Id, _UserSettings);
        }

        // USER ACCCOUNT SETTERS
       
       

        public static void ChangeUserName(string username)
        {
            _UsrAccount.UserName = username;
            DBConnection.getInstance().UpdateUserAccount(_UsrAccount.Id, _UsrAccount);
        }

        public static void ChangeFirstName(string firstname)
        {
            _UsrAccount.FirstName = firstname;
            DBConnection.getInstance().UpdateUserAccount(_UsrAccount.Id, _UsrAccount);
        }

        public static void ChangeLastName(string lastname)
        {
            _UsrAccount.LastName = lastname;
            DBConnection.getInstance().UpdateUserAccount(_UsrAccount.Id, _UsrAccount);
        }


        public static void ChangeWeight(int weight)
        {
            _UsrAccount.UserWeight = weight;
            DBConnection.getInstance().UpdateUserAccount(_UsrAccount.Id, _UsrAccount);
        }

        public static void ChangeHeight(int height)
        {
            _UsrAccount.UserHeight = height;
            DBConnection.getInstance().UpdateUserAccount(_UsrAccount.Id, _UsrAccount);
        }

        public static void ChangeSex(string sex)
        {
            _UsrAccount.Sex = sex.ToUpper();
            DBConnection.getInstance().UpdateUserAccount(_UsrAccount.Id, _UsrAccount);
        }



        public static bool AscendingClockSetting() { return _UserSettings.AscendingClock; }
        public static bool TimerSetting() { return _UserSettings.TurnOffTimers; }
        public static bool HitSoundOff() { return _UserSettings.TurnOffHitSounds; }
        public static bool MissSoundOff() { return _UserSettings.TurnOffMissSounds; }
        public static bool VisualFeedbackOff() { return _UserSettings.TurnOffVisualFeedback; }
        public static bool ClockFormat() { return _UserSettings.ToggleClock; }
        public static int ThemeSetting() { return _UserSettings.ColorScheme; }



        public static void SetUserSettings(UserSettings userSettings) { _UserSettings = userSettings; }

     
        



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

        public bool ToggleClock;

        public UserSettings(int colorScheme, bool ascendingClock, bool turnOffTimers,
            bool turnOffVisualFeedback, bool turnOffHitSounds, bool turnOffMissSounds, bool toggleClock)
        {
            AscendingClock = ascendingClock;
            ColorScheme = colorScheme;
            TurnOffTimers = turnOffTimers;
            TurnOffVisualFeedback = turnOffVisualFeedback;
            TurnOffHitSounds = turnOffHitSounds;
            TurnOffMissSounds = turnOffMissSounds;
            ToggleClock = toggleClock;
        }
    }

    struct UsrAccount
    {
        public int Id;

        public string UserName;

        public string Password;

        public string FirstName;

        public string LastName;

        public string Sex;

        public int UserHeight;

        public int UserWeight;

        public int UserYear;


        public UsrAccount(int idd, string username, string password, string firstname,
            string lastname, string sex, int userheight, int userweight, int useryear)
        {
            Id = idd;
            UserName = username;
            Password = password;
            FirstName = firstname;
            LastName = lastname;
            Sex = sex;
            UserHeight = userheight;
            UserWeight = userweight;
            UserYear = useryear;
        }
    }

}
