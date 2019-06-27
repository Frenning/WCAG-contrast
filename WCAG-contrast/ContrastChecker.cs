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
        private Utility utility = new Utility();

        private List<Color> rgbList = new List<Color>();
        private List<Label> labelList = new List<Label>();
        private List<TextBox> textBoxList = new List<TextBox>();
        private List<TextBox> textBoxContrastList = new List<TextBox>();
        private List<TextBox> textBoxColorList = new List<TextBox>();
        private List<TextBox> textBoxContrastColorList = new List<TextBox>();
        private List<NumericUpDown> numericRedList = new List<NumericUpDown>();
        private List<NumericUpDown> numericGreenList = new List<NumericUpDown>();
        private List<NumericUpDown> numericBlueList = new List<NumericUpDown>();
        private double contrast;
        public ContrastForm()
        {
            InitializeComponent();
            labelList.Add(labelHex1);
            textBoxList.Add(textBoxHex1);
            textBoxColorList.Add(textBoxColor1);
            textBoxContrastList.Add(textBoxContrast1);
            textBoxContrastColorList.Add(textBoxContrastColor1);
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
                textBoxList.Add(textBoxHex1);
                textBoxColorList.Add(textBoxColor1);
                textBoxContrastList.Add(textBoxContrast1);
                textBoxContrastColorList.Add(textBoxContrastColor1);
                numericRedList.Add(numericRed1);
                numericGreenList.Add(numericGreen1);
                numericBlueList.Add(numericBlue1);
                rgbList.Add(new Color());
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
                    new Size(50, 20), ConvertHexToColor);

                AddLabel(new Point(labelList.Last().Location.X + 60, labelList.Last().Location.Y), "labelRed", "Red",
                    new Size(27, 13));
                AddNumericUpDown(new Point(labelList.Last().Location.X + 60, labelList.Last().Location.Y + 20), "numericRed", 
                    new Size(55, 20), ConvertColorToHex);
                AddLabel(new Point(labelList.Last().Location.X + 120, labelList.Last().Location.Y), "labelGreen", "Green",
                    new Size(27, 13));
                AddNumericUpDown(new Point(labelList.Last().Location.X + 120, labelList.Last().Location.Y + 20), "numericGreen",
                    new Size(55, 20), ConvertColorToHex);
                AddLabel(new Point(labelList.Last().Location.X + 180, labelList.Last().Location.Y), "labelBlue", "Blue",
                    new Size(27, 13));
                AddNumericUpDown(new Point(labelList.Last().Location.X + 180, labelList.Last().Location.Y + 20), "numericBlue",
                    new Size(55, 20), ConvertColorToHex);

                AddLabel(new Point(labelList.Last().Location.X + 250, labelList.Last().Location.Y), "labelColor", "Color",
                    new Size(27, 13));
                AddTextBoxColor(new Point(labelList.Last().Location.X + 250, labelList.Last().Location.Y + 20), "textBoxColor" + (labelList.IndexOf(labelList.Last()) + 2), "",
                    new Size(75, 20));

                AddLabel(new Point(labelList.Last().Location.X + 360, labelList.Last().Location.Y), "labelContrastColor", "Contrast " + (labelList.IndexOf(labelList.Last()) + 1),
                    new Size(27, 13));
                AddTextBoxContrastColor(new Point(labelList.Last().Location.X + 360, labelList.Last().Location.Y + 20), "textBoxContrastColor" + (labelList.IndexOf(labelList.Last()) + 2), "",
                    new Size(75, 20));

                AddLabel(new Point(labelList.Last().Location.X + 780, labelList.Last().Location.Y), "labelContrast", "Manual Contrast " + (labelList.IndexOf(labelList.Last()) + 1),
                    new Size(27, 13));
                AddTextBoxContrast(new Point(labelList.Last().Location.X + 780, labelList.Last().Location.Y + 20), "textBoxContrast" + (labelList.IndexOf(labelList.Last()) + 2), "",
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
        private void AddTextBoxColor(Point point, string name, string text, Size size)
        {
            TextBox textBox = new TextBox();
            textBox.Location = point;
            textBox.Name = name;
            textBox.Size = size;
            textBox.Text = text;
            textBox.TabIndex = 6;
            Controls.Add(textBox);
            textBox.ReadOnly = true;
            textBoxColorList.Add(textBox);
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
            textBoxContrastColorList.Add(textBox);
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
        private void ConvertHexToColor(Object sender, EventArgs e)
        {
            Regex re = new Regex(@"^#[A-Fa-f0-9]{6}$");
            int index = textBoxList.IndexOf((TextBox)sender);
            Color color = new Color();
            if (!re.IsMatch(textBoxList[index].Text)) return;
            color = utility.HexToColor(textBoxList[index].Text);

            numericRedList[index].Value = color.R;
            numericGreenList[index].Value = color.G;
            numericBlueList[index].Value = color.B;
            rgbList[index] = Color.FromArgb(color.R, color.G, color.B);
            CalculateContrast();
            TestContrastColor(index);
        }
        private void ConvertColorToHex(object sender, EventArgs e)
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
            var hex = utility.ColorToHex(rgbList[index]);
            textBoxList[index].Text = hex;
            CalculateContrast();
            TestContrastColor(index);
        }
        private void ChangeBgColor(object sender, EventArgs e)
        {
            Color color = Color.FromArgb(trackbarRed.Value, trackbarGreen.Value, trackbarBlue.Value);
            labelRedTrackbar.Text = "Red: " + trackbarRed.Value;
            labelGreenTrackbar.Text = "Green: " + trackbarGreen.Value;
            labelBlueTrackbar.Text = "Blue: " + trackbarBlue.Value;
            utility.SetTextBoxBGColor(textBoxColor, color);
            CalculateContrast();
        }

        public void SetContrastColor()
        {
            int index = 0;
            foreach (Color color in rgbList)
            {
                textBoxColorList[index].BackColor = color;
                index++;
            }

        }
        public void TestContrastColor(int index)
        {
            Random rand = new Random();
            Color color = new Color();

            int x = (int)numericRedList[index].Value + (int)numericGreenList[index].Value + (int)numericBlueList[index].Value;
            int i = 0;
            double contrast2 = 0;
            if (x < 765 / 2)
            {
                while (contrast2 < 4.5 && i < 100)
                {
                    color = Color.FromArgb(rand.Next(100, 255), rand.Next(100, 255), rand.Next(100, 255));
                    contrast2 = utility.GetContrast(rgbList[index], color);
                    if (contrast2 > 4.5) break;
                    i++;
                }
                textBoxContrastColorList[index].ForeColor = Color.Black;
            }
            else
            {
                while (contrast2 < 4.5 && i < 100)
                {
                    color = Color.FromArgb(rand.Next(0, 100), rand.Next(0, 100), rand.Next(0, 100));
                    contrast2 = utility.GetContrast(rgbList[0], color);
                    if (contrast2 > 4.5) break;
                    i++;
                }
                textBoxContrastColorList[index].ForeColor = Color.White;
            }
            textBoxContrastColorList[index].BackColor = color;
            textBoxContrastColorList[index].Text = contrast2.ToString();

            
        }
        public void CalculateContrast()
        {
            var index = 0;
            foreach (TextBox contrastBox in textBoxContrastList)
            {
                rgbList[index] = Color.FromArgb((int)numericRedList[index].Value, (int)numericGreenList[index].Value, (int)numericBlueList[index].Value);
                Color color = Color.FromArgb(trackbarRed.Value, trackbarGreen.Value, trackbarBlue.Value);
                this.contrast = utility.GetContrast(rgbList[index], color);
                textBoxContrastList[index].Text = contrast.ToString();
                index++;
            }
            SetContrastColor();
        }
    }
}
