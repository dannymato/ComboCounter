using System;
using System.Drawing;

namespace ComboCounter.Classes
{
    /// <summary>
    /// Contains static tools that are used throughout the program
    /// </summary>
    class Tools
    {
        /// <summary>
        /// Struct which holds a color in the HSV format
        /// Allows for easier interpolation between colors
        /// </summary>
        struct HSVColor
        {
            public float H, S, V;

            /// <summary>
            /// Constructor for creating an HSVColor from the Hue, Saturation, and Value settings
            /// </summary>
            /// <param name="h">Hue from 0.0f to 1.0f</param>
            /// <param name="s">Saturation from 0.0f to 1.0f</param>
            /// <param name="v">Value from 0.0f to 1.0f</param>
            public HSVColor(float h = 1.0f, float s = 1.0f, float v = 1.0f) {
                H = h;
                S = s;
                V = v;
            }


            /// <summary>
            /// Constructor for creating an HSVColor from an RGB color
            /// </summary>
            /// <param name="r">Red value of RGB from 0 to 255</param>
            /// <param name="g">Green value of RGB from 0 to 255</param>
            /// <param name="b">Blue value of RGB from 0 to 255</param>
            public HSVColor(int r, int g, int b)
            {

                float r1 = r / 255;
                float g1 = g / 255;
                float b1 = b / 255;

                var minRGB = Math.Min(r, Math.Min(g, b));
                var maxRGB = Math.Max(r, Math.Max(g, b));

                if (minRGB == maxRGB)
                {
                    H = 0;
                    S = 0;
                    V = minRGB;
                }
                else
                {
                    var d = (r == minRGB) ? g - b : ((b == minRGB) ? r - g : b - r);
                    var h = (r == minRGB) ? 3 : ((b == minRGB) ? 1 : 5);
                    H = (60 * (h - d / (maxRGB - minRGB))) / 360.0f;
                    S = (maxRGB - minRGB) / (float)maxRGB;
                    V = maxRGB / 255.0f;
                }
            }

            /// <summary>
            /// Returns the RGB value of the color as a Color struct using the specified alpha value
            /// </summary>
            /// <param name="alpha">Alpha value to attribute to the color</param>
            /// <returns>An RGB converted version of the color</returns>
            public Color GetColor(int alpha)
            {
                float r, g, b, f, p, q, t;
                
                int i;
                i = (int)Math.Floor(H * 6);
                f = H * 6 - i;
                p = V * (1 - S);
                q = V * (1 - f * S);
                t = V * (1 - (1 - f) * S);
                switch (i % 6)
                {
                    case 0: r = V; g = t; b = p; break;
                    case 1: r = q; g = V; b = p; break;
                    case 2: r = p; g = V; b = t; break;
                    case 3: r = p; g = q; b = V; break;
                    case 4: r = t; g = p; b = V; break;
                    case 5: r = V; g = p; b = q; break;
                    default: r = 0; g = 0; b = 0; break;
                }

                return Color.FromArgb(alpha, (int)Math.Round(r * 255), (int)Math.Round(g * 255), (int)Math.Round(b * 255));
            }

            /// <summary>
            /// Converts the HSVColor to an RGB Color struct using a default alpha of 255
            /// </summary>
            /// <returns>Returns a RGB Color struct with default alpha value</returns>
            public Color GetColor()
            {
                return GetColor(255);
            }

        }

        /// <summary>
        /// Formats the time setters in the application in the format of mm:ss
        /// </summary>
        /// <param name="seconds">Total second to input for the time setter</param>
        /// <returns>Formatted time string the format mm:ss</returns>
        public static string FormatTimeSetter(int seconds)
        {
            return string.Format("{0:00}:{1:00}", seconds / 60, seconds % 60);
        }

        /// <summary>
        /// Formats the current time info for the different pages
        /// </summary>
        /// <param name="msecs">Total number of msecs to display</param>
        /// <returns>Formatted time string in the format of MM:ss.m</returns>
        public static string FormatCurrentTime(long msecs)
        {
            long minutes = msecs / 1000 / 60;
            long seconds = msecs / 1000 % 60;
            long fracSecs = msecs % 1000 / 100;
            return string.Format("{0:00}:{1:00}.{2:0}", minutes, seconds, fracSecs);
        }


        /// <summary>
        /// Interpolates between c1, c2, and c3
        /// </summary>
        /// <param name="c1">The lowest value on the spectrum</param>
        /// <param name="c2">The middle value of the spectrum</param>
        /// <param name="c3">The highest value on the spectrum</param>
        /// <param name="val">Value between 0.0f and 1.0f to determine where on the range</param>
        /// <returns>The Color which is on the spectrum depending on the val</returns>
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

        /// <summary>
        /// Interpolates between 2 colors and returns a Color struct
        /// </summary>
        /// <param name="c1">The bottom value on the spectrum</param>
        /// <param name="c2">The top value on the spectrum</param>
        /// <param name="val">The place along the spectrum, value between 0.0f and 1.0f, with 0.0f being c1, and 1.0f being c2</param>
        /// <returns>Color struct which is along the hue spectrum according to val</returns>
        public static Color Interpolate(Color c1, Color c2, float val)
        {
            // The conversion to HSV makes the interpolation smoother
            HSVColor color1 = new HSVColor(c1.R, c1.G, c1.B);
            HSVColor color2 = new HSVColor(c2.R, c2.G, c2.B);

            float h;
            float d = color2.H - color1.H;
            // Depending on where the 2 colors are on the spectrum we may have to swap them
            float h1, h2;
            if (color1.H > color2.H)
            {
                h2 = color1.H;
                h1 = color2.H;
                d = -d;
                val = 1 - val;
            }
            else
            {
                h1 = color1.H;
                h2 = color2.H;
            }
            
            if (d > 0.5f)
            {
                h1 = h1 + 1;
                h = (h1 + val * (h2 - h1)) % 1;
            }
            else
            {
                h = h1 + val * d;
            }

            float s = color1.S + val * (color2.S - color1.S);
            float v = color1.V + val * (color2.V - color1.V);
            var finalColor = new HSVColor(h, s, v);


            return finalColor.GetColor((int)((c2.A - c1.A) * val + c1.A));
        }

    }
}
