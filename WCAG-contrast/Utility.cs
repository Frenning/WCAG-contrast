using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WCAG_contrast
{
    class Utility
    {
        public void SetTextBoxBGColor(TextBox textBox, Color color)
        {
            textBox.BackColor = color;
        }
        public string ColorToHex(Color color)
        {
            string hex;

            color = Color.FromArgb(color.R, color.G, color.B);

            hex = "#" + color.R.ToString("X2") + color.G.ToString("X2") + color.B.ToString("X2");
            return hex;
        }

        public Color HexToColor(string hex)
        {
            ColorConverter colorConverter = new ColorConverter();
            Color color = (Color)colorConverter.ConvertFromString(hex);
            return color;
        }

        public double Luminanace(double v)
        {
            v /= 255;
            return v <= 0.03928 ? v / 12.92 : Math.Pow((v + 0.055) / 1.055, 2.4);
        }

        public double GetContrast(Color color, Color color2)
        {
            var L1 = (Luminanace(color.R) * 0.2126 +
                      Luminanace(color.G) * 0.7152 +
                      Luminanace(color.B) * 0.0722) + 0.05;

            var L2 = (Luminanace(color2.R) * 0.2126 +
                      Luminanace(color2.G) * 0.7152 +
                      Luminanace(color2.B) * 0.0722) + 0.05;
            if (L1 > L2)
                return (L1 / L2);
            else
                return (L2 / L1);
        }
    }
}
