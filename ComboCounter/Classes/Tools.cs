using System;
using System.Drawing;

namespace ComboCounter.Classes
{
    class Tools
    {
        struct HSVColor
        {
            public float H, S, V;
            public HSVColor(float h = 1.0f, float s = 1.0f, float v = 1.0f) {
                H = h;
                S = s;
                V = v;
            }

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

            public Color GetColor()
            {
                return GetColor(255);
            }

        }

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
            //int red =   (int)((c2.R - c1.R) * val + c1.R);
            //int green = (int)((c2.G - c1.G) * val + c1.G);
            //int blue =  (int)((c2.B - c1.B) * val + c1.B);
            //int alpha = (int)((c2.A - c1.A) * val + c1.A);

            HSVColor color1 = new HSVColor(c1.R, c1.G, c1.B);
            HSVColor color2 = new HSVColor(c2.R, c2.G, c2.B);

            float h;
            float d = color2.H - color1.H;
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
