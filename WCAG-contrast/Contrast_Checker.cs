using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WCAG_contrast
{
    public partial class ContrastForm : Form
    {
        private Color rgb1 = new Color();
        private Color rgb2 = new Color();
        private double contrast;
        public ContrastForm()
        {
            InitializeComponent();
        }
        private void calculateContrast()
        {
            rgb1 = Color.FromArgb((int)numericRed1.Value, (int)numericGreen1.Value, (int)numericBlue1.Value);
            rgb2 = Color.FromArgb((int)numericRed2.Value, (int)numericGreen2.Value, (int)numericBlue2.Value);

            getContrast(rgb1);
            textBoxContrast1.Text = contrast.ToString();
            getContrast(rgb2);
            textBoxContrast2.Text = contrast.ToString();
        }
        private void changeBgColor(object sender, EventArgs e)
        {
            Color color = Color.FromArgb(trackbarRed.Value, trackbarGreen.Value, trackbarBlue.Value);
            this.labelRedTrackbar.Text = "Red: " + trackbarRed.Value;
            this.labelGreenTrackbar.Text = "Green: " + trackbarGreen.Value;
            this.labelBlueTrackbar.Text = "Blue: " + trackbarBlue.Value;
            setBGColor(color);
            calculateContrast();
        }
        private void setBGColor(Color color)
        {
            textBoxColor.BackColor = color;
        }
        private void convertIntToHex(object sender, EventArgs e)
        {
            if (sender.Equals(numericRed1) || sender.Equals(numericGreen1) || sender.Equals(numericBlue1))
            {
                rgb1 = Color.FromArgb((int)numericRed1.Value, (int)numericGreen1.Value, (int)numericBlue1.Value);
                intToHex(1);
            }
            else
            {
                rgb2 = Color.FromArgb((int)numericRed2.Value, (int)numericGreen2.Value, (int)numericBlue2.Value);
                intToHex(2);
            }
            calculateContrast();
        }
        private void convertHexToInt(object sender, EventArgs e)
        {
            if (sender.Equals(textBoxHex1))
                hexToInt(1);
            else
                hexToInt(2);

            calculateContrast();
        }
        private void intToHex(int index)
        {
            Color color = new Color();
            string hex;
            if (index == 1)
            {
                color = Color.FromArgb(rgb1.R, rgb1.G, rgb1.B);

                hex = "#" + color.R.ToString("X2") + color.G.ToString("X2") + color.B.ToString("X2");
                textBoxHex1.Text = hex;
            }
            else
            {
                color = Color.FromArgb(rgb2.R, rgb2.G, rgb2.B);

                hex = "#" + color.R.ToString("X2") + color.G.ToString("X2") + color.B.ToString("X2");
                textBoxHex2.Text = hex;
            }
        }
        private void hexToInt(int index)
        {
            ColorConverter colorConverter = new ColorConverter();
            Color color = new Color();
            Regex re = new Regex(@"^#[A-Fa-f0-9]{6}$");
            if (index == 1)
            {             
                if (!re.IsMatch(textBoxHex1.Text)) return;

                color = (Color)colorConverter.ConvertFromString(textBoxHex1.Text);
                rgb1 = Color.FromArgb(color.R, color.G, color.B);
                numericRed1.Value = color.R;
                numericGreen1.Value = color.G;
                numericBlue1.Value = color.B;
            }
            else
            {
                if (!re.IsMatch(textBoxHex2.Text)) return;

                color = (Color)colorConverter.ConvertFromString(textBoxHex2.Text);
                rgb2 = Color.FromArgb(color.R, color.G, color.B);
                numericRed2.Value = color.R;
                numericGreen2.Value = color.G;
                numericBlue2.Value = color.B;
            }
        }
        private double luminanace(double v)
        {
            v /= 255;
            return v <= 0.03928 ? v / 12.92 : Math.Pow((v + 0.055) / 1.055, 2.4);            
        }

        private void getContrast(Color color)
        {
            var L1 = (luminanace(color.R) * 0.2126 +
                      luminanace(color.G) * 0.7152 +
                      luminanace(color.B) * 0.0722) + 0.05;

            var L2 = (luminanace(trackbarRed.Value) * 0.2126 +
                      luminanace(trackbarGreen.Value) * 0.7152 +
                      luminanace(trackbarBlue.Value) * 0.0722) + 0.05;
            if(L1 > L2)
                this.contrast = (L1 / L2);
            else
                this.contrast = (L2 / L1);
        }
    }
}
