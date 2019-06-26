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
        private List<Color> rgbList = new List<Color>();
        private List<Label> labelList = new List<Label>();
        private List<Label> labelContrastList = new List<Label>();
        private List<TextBox> textBoxList = new List<TextBox>();
        private List<TextBox> textBoxContrastList = new List<TextBox>();
        private List<NumericUpDown> numericRedList = new List<NumericUpDown>();
        private List<NumericUpDown> numericGreenList = new List<NumericUpDown>();
        private List<NumericUpDown> numericBlueList = new List<NumericUpDown>();
        private double contrast;
        public ContrastForm()
        {
            InitializeComponent();
            labelList.Add(labelHex1);
            labelContrastList.Add(labelContrast1);
            textBoxList.Add(textBoxHex1);
            textBoxContrastList.Add(textBoxContrast1);
            numericRedList.Add(numericRed1);
            numericGreenList.Add(numericGreen1);
            numericBlueList.Add(numericBlue1);
            rgbList.Add(new Color());
        }
        private void AddColorBoxes(object sender, EventArgs e)
        {
            if (labelList.Count == 0)
            {
                labelList.Add(labelHex1);
                labelContrastList.Add(labelContrast1);
                textBoxList.Add(textBoxHex1);
                textBoxContrastList.Add(textBoxContrast1);
                numericRedList.Add(numericRed1);
                numericGreenList.Add(numericGreen1);
                numericBlueList.Add(numericBlue1);
            }
            if (labelList.Count < 6)
            {
                Label labelHex = new Label();
                labelHex.AutoSize = true;
                labelHex.Location = new Point(20, labelList.Last().Location.Y + 60);
                labelHex.Name = "labelHex" + (labelList.IndexOf(labelList.Last())+2); //
                labelHex.Size = new Size(32, 13);
                labelHex.TabIndex = 13;
                labelHex.Text = "Hex" + (labelList.IndexOf(labelList.Last()) + 2);
                Controls.Add(labelHex);
                labelList.Add(labelHex);

                AddTextBox(new Point(20, labelList.Last().Location.Y + 20), "textBoxHex" + (labelList.IndexOf(labelList.Last()) + 2), "#000000", 
                    new Size(50, 20), ConvertHexToInt);

                AddLabel(new Point(labelList.Last().Location.X + 60, labelList.Last().Location.Y), "labelRed", "Red",
                    new Size(27, 13));
                AddNumericUpDown(new Point(labelList.Last().Location.X + 60, labelList.Last().Location.Y + 20), "numericRed", 
                    new Size(55, 20), ConvertIntToHex);
                AddLabel(new Point(labelList.Last().Location.X + 120, labelList.Last().Location.Y), "labelGreen", "Green",
                    new Size(27, 13));
                AddNumericUpDown(new Point(labelList.Last().Location.X + 120, labelList.Last().Location.Y + 20), "numericGreen",
                    new Size(55, 20), ConvertIntToHex);
                AddLabel(new Point(labelList.Last().Location.X + 180, labelList.Last().Location.Y), "labelBlue", "Blue",
                    new Size(27, 13));
                AddNumericUpDown(new Point(labelList.Last().Location.X + 180, labelList.Last().Location.Y + 20), "numericBlue",
                    new Size(55, 20), ConvertIntToHex);

                AddLabel(new Point(labelList.Last().Location.X + 340, labelList.Last().Location.Y), "labelContrast", "Contrast", 
                    new Size(27, 13));
                AddTextBoxContrast(new Point(labelList.Last().Location.X + 340, labelList.Last().Location.Y + 20), "textBoxContrast" + (labelList.IndexOf(labelList.Last()) + 2), "",
                    new Size(100, 20));

                AddLabel(new Point(labelList.Last().Location.X + 760, labelList.Last().Location.Y), "labelContrastColor", "Contrast Color",
                    new Size(27, 13));
                AddTextBoxContrastColor(new Point(labelList.Last().Location.X + 760, labelList.Last().Location.Y + 20), "textBoxContrastColor" + (labelList.IndexOf(labelList.Last()) + 2), "",
                    new Size(100, 20));
                rgbList.Add(new Color());
            }
        }
        private void AddLabel(Point point, string name, string text, Size size)
        {
            Label label = new Label();
            label.AutoSize = true;
            label.Location = point;
            label.Name = name;
            label.Size = size;
            label.Text = text;
            Controls.Add(label);
            if (text == "Contrast")
                labelContrastList.Add(label);               
        }
        private void AddTextBox(Point point, string name, string text, Size size, EventHandler functionName)
        {
            TextBox textBox = new TextBox();
            textBox.Location = point;
            textBox.Name = name;
            textBox.Size = size;
            textBox.Text = text;
            textBox.TabIndex = 6;
            textBox.Leave += functionName;
            Controls.Add(textBox);
            textBoxList.Add(textBox); 
        }
        private void AddTextBoxContrast(Point point, string name, string text, Size size)
        {
            TextBox textBox = new TextBox();
            textBox.Location = point;
            textBox.Name = name;
            textBox.Size = size;
            textBox.Text = text;
            textBox.TabIndex = 6;
            Controls.Add(textBox);
            textBox.ReadOnly = true;
            textBoxContrastList.Add(textBox);
        }
        private void AddTextBoxContrastColor(Point point, string name, string text, Size size)
        {
            TextBox textBox = new TextBox();
            textBox.Location = point;
            textBox.Name = name;
            textBox.Size = size;
            textBox.Text = text;
            textBox.TabIndex = 6;
            Controls.Add(textBox);
            textBox.ReadOnly = true;
        }
        private void AddNumericUpDown(Point point, string name, Size size, EventHandler functionName)
        {
            NumericUpDown numericUpDown = new NumericUpDown();
            numericUpDown.Location = point;
            numericUpDown.Maximum = new decimal(new int[] {
                                                        255,
                                                        0,
                                                        0,
                                                        0});
            numericUpDown.Name = name;
            numericUpDown.Size = size;
            numericUpDown.TabIndex = 6;
            numericUpDown.ValueChanged += functionName;
            Controls.Add(numericUpDown);
            if (name.Contains("numericRed")) numericRedList.Add(numericUpDown);
            else if (name.Contains("numericGreen")) numericGreenList.Add(numericUpDown);
            else if (name.Contains("numericBlue")) numericBlueList.Add(numericUpDown); 
        }
        private void ChangeBgColor(object sender, EventArgs e)
        {
            Color color = Color.FromArgb(trackbarRed.Value, trackbarGreen.Value, trackbarBlue.Value);
            labelRedTrackbar.Text = "Red: " + trackbarRed.Value;
            labelGreenTrackbar.Text = "Green: " + trackbarGreen.Value;
            labelBlueTrackbar.Text = "Blue: " + trackbarBlue.Value;
            SetBGColor(color);
            CalculateContrast();
        }
        private void SetBGColor(Color color)
        {
            textBoxColor.BackColor = color;
        }
        private void ConvertIntToHex(object sender, EventArgs e)
        {
            int index = 0;
            NumericUpDown temp = (NumericUpDown)sender;
            if (temp.Name == "numericRed")
                index = numericRedList.IndexOf(temp);
            else if (temp.Name == "numericGreen")
                index = numericGreenList.IndexOf(temp);
            else if (temp.Name == "numericBlue")
                index = numericBlueList.IndexOf(temp);


            rgbList[index] = Color.FromArgb((int)numericRedList[index].Value, (int)numericGreenList[index].Value, (int)numericBlueList[index].Value);
            IntToHex(index);
            
            CalculateContrast();
        }
        private void IntToHex(int index)
        {
            Color color = new Color();
            string hex;

            color = Color.FromArgb(rgbList[index].R, rgbList[index].G, rgbList[index].B);

            hex = "#" + color.R.ToString("X2") + color.G.ToString("X2") + color.B.ToString("X2");
            textBoxList[index].Text = hex;
        }
        private void CalculateContrast()
        {
            var index = 0;
            foreach (TextBox contrastBox in textBoxContrastList)
            {
                rgbList[index] = Color.FromArgb((int)numericRedList[index].Value, (int)numericGreenList[index].Value, (int)numericBlueList[index].Value);

                GetContrast(rgbList[index]);
                textBoxContrastList[index].Text = contrast.ToString();
                index++;
            }
        }
        private void ConvertHexToInt(Object sender, EventArgs e)
        {
            Regex re = new Regex(@"^#[A-Fa-f0-9]{6}$");
            int index = textBoxList.IndexOf((TextBox)sender);

            if (!re.IsMatch(textBoxList[index].Text)) return;
            HexToInt(index);

            CalculateContrast();
        }
        private void HexToInt(int index)
        {
            ColorConverter colorConverter = new ColorConverter();
            Color color = new Color();
                       
            color = (Color)colorConverter.ConvertFromString(textBoxList[index].Text);
            rgbList[index] = Color.FromArgb(color.R, color.G, color.B);
            numericRedList[index].Value = color.R;
            numericGreenList[index].Value = color.G;
            numericBlueList[index].Value = color.B;
        }
        private double Luminanace(double v)
        {
            v /= 255;
            return v <= 0.03928 ? v / 12.92 : Math.Pow((v + 0.055) / 1.055, 2.4);            
        }

        private void GetContrast(Color color)
        {
            var L1 = (Luminanace(color.R) * 0.2126 +
                      Luminanace(color.G) * 0.7152 +
                      Luminanace(color.B) * 0.0722) + 0.05;

            var L2 = (Luminanace(trackbarRed.Value) * 0.2126 +
                      Luminanace(trackbarGreen.Value) * 0.7152 +
                      Luminanace(trackbarBlue.Value) * 0.0722) + 0.05;
            if(L1 > L2)
                this.contrast = (L1 / L2);
            else
                this.contrast = (L2 / L1);
        }

    }
}
