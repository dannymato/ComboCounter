using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace ComboCounter.Classes
{
    class ThemeManager
    {
        private static int DBThemeNum = 1;
        private static int ThemeNum = 2;
        //Boolean ThemeBoolean;


        public static Color initBackground()
        {
            // COMPARE WITH NEW
            // Boolean ThemeBoolean = Verify();
            if (Verify())
            {
                // DEFINE METOD FOR RETURNING ISHHH
                return ChangeBackground(GetDBThemeNum());

            }
            else
            {
                return ChangeBackground(GetThemeNum());
            }
            
            //IF FALSE APPLY NEW THEME
        
        }
        public static Boolean Verify()
        {
            // GET LAST THEME NUMBER
            if(GetThemeNum() == GetDBThemeNum())
            {
                return true;
            }
            else
            {
                return false;
               //ChangeBackground(t);
            }
        }

        //RETRIEVES THEME NUMBER
        private static int GetThemeNum()
        {
            return ThemeNum;
        }

        private static int GetDBThemeNum()
        {
            return DBThemeNum;
        }
    

        private static Color ChangeBackground(int t)
        {
         
          
            if(t == 1)
            {
                return ThemeConstants.white;
            }
            else if(t == 2)
            {
                return ThemeConstants.red;
            }
            else if (t == 3)
            {
                return ThemeConstants.green;
            }
            else
            {
                return ThemeConstants.white;
            }
        }





       

    }
}
