using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ComboCounter.Classes
{
    class Tools
    {
        public static string FormatTimeSetter(int seconds)
        {
            return string.Format("{0:00}:{1:00}", seconds / 60, seconds % 60);
        }

        public static string FormatCurrentTime(long msecs)
        {
            long minutes = msecs / 1000 / 60;
            long seconds = msecs / 1000 % 60;
            long fracSecs = msecs % 1000 / 100;
            return string.Format("{0:00}:{1:00}.{2:0}", minutes, seconds, fracSecs);
        }

        // Interpolates between c1, c2, and c3
        // Val is a float between 0.0f and 1.0f
        public static Color Interpolate(Color c1, Color c2, Color c3, float val)
        {
            if (val <= 0.0f)
            {
                return c1;
            }
            if (val >= 1.0f)
            {
                return c3;
            }
            if (val < 0.5f)
            {
                return Interpolate(c1, c2, val / 0.5f);
            }

            return Interpolate(c2, c3, (val - 0.5f) / 0.5f);
        }

        public static Color Interpolate(Color c1, Color c2, float val)
        {
            int red =   (int)((c2.R - c1.R) * val + c1.R);
            int green = (int)((c2.G - c1.G) * val + c1.G);
            int blue =  (int)((c2.B - c1.B) * val + c1.B);
            int alpha = (int)((c2.A - c1.A) * val + c1.A);

            return Color.FromArgb(alpha, red, green, blue);
        }

    }
}
