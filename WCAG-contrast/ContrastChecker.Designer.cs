namespace WCAG_contrast
{
    partial class ContrastForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.numericRed1 = new System.Windows.Forms.NumericUpDown();
            this.numericGreen1 = new System.Windows.Forms.NumericUpDown();
            this.numericBlue1 = new System.Windows.Forms.NumericUpDown();
            this.textBoxContrast1 = new System.Windows.Forms.TextBox();
            this.textBoxColor = new System.Windows.Forms.RichTextBox();
            this.textBoxContrastColor = new System.Windows.Forms.TextBox();
            this.labelRed1 = new System.Windows.Forms.Label();
            this.labelGreen1 = new System.Windows.Forms.Label();
            this.labelBlue1 = new System.Windows.Forms.Label();
            this.labelRedTrackbar = new System.Windows.Forms.Label();
            this.labelGreenTrackbar = new System.Windows.Forms.Label();
            this.labelBlueTrackbar = new System.Windows.Forms.Label();
            this.textBoxHex1 = new System.Windows.Forms.TextBox();
            this.labelHex1 = new System.Windows.Forms.Label();
            this.labelContrast1 = new System.Windows.Forms.Label();
            this.labelContrastColor = new System.Windows.Forms.Label();
            this.trackbarRed = new System.Windows.Forms.TrackBar();
            this.trackbarGreen = new System.Windows.Forms.TrackBar();
            this.trackbarBlue = new System.Windows.Forms.TrackBar();
            this.addColorButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericRed1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericGreen1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericBlue1)).BeginInit();
            this.SuspendLayout();

            // 
            // labelHex1
            // 
            this.labelHex1.AutoSize = true;
            this.labelHex1.Location = new System.Drawing.Point(20, 40);
            this.labelHex1.Name = "labelHex1";
            this.labelHex1.Size = new System.Drawing.Size(32, 13);
            this.labelHex1.Text = "Hex1";
            // 
            // textBoxHex1
            // 
            this.textBoxHex1.Location = new System.Drawing.Point(20, 60);
            this.textBoxHex1.Name = "textBoxHex1";
            this.textBoxHex1.Size = new System.Drawing.Size(50, 20);
            this.textBoxHex1.Text = "#000000";
            this.textBoxHex1.TabIndex = 1;
            this.textBoxHex1.Leave += ConvertHexToInt;
            // 
            // labelRed1
            // 
            this.labelRed1.AutoSize = true;
            this.labelRed1.Location = new System.Drawing.Point(80, 40);
            this.labelRed1.Name = "labelRed1";
            this.labelRed1.Size = new System.Drawing.Size(27, 13);
            this.labelRed1.Text = "Red";
            // 
            // labelGreen1
            // 
            this.labelGreen1.AutoSize = true;
            this.labelGreen1.Location = new System.Drawing.Point(140, 40);
            this.labelGreen1.Name = "labelGreen1";
            this.labelGreen1.Size = new System.Drawing.Size(36, 13);
            this.labelGreen1.Text = "Green";
            // 
            // labelBlue1
            // 
            this.labelBlue1.AutoSize = true;
            this.labelBlue1.Location = new System.Drawing.Point(200, 40);
            this.labelBlue1.Name = "labelBlue1";
            this.labelBlue1.Size = new System.Drawing.Size(28, 13);
            this.labelBlue1.Text = "Blue";
            // 
            // numericRed1
            // 
            this.numericRed1.Location = new System.Drawing.Point(80, 60);
            this.numericRed1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericRed1.Name = "numericRed1";
            this.numericRed1.Size = new System.Drawing.Size(55, 20);
            this.numericRed1.TabIndex = 2;
            this.numericRed1.ValueChanged += ConvertIntToHex;
            // 
            // numericGreen1
            // 
            this.numericGreen1.Location = new System.Drawing.Point(140, 60);
            this.numericGreen1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericGreen1.Name = "numericGreen1";
            this.numericGreen1.Size = new System.Drawing.Size(53, 20);
            this.numericGreen1.TabIndex = 3;
            this.numericGreen1.ValueChanged += ConvertIntToHex;
            // 
            // numericBlue1
            // 
            this.numericBlue1.Location = new System.Drawing.Point(200, 60);
            this.numericBlue1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericBlue1.Name = "numericBlue1";
            this.numericBlue1.Size = new System.Drawing.Size(53, 20);
            this.numericBlue1.TabIndex = 4;
            this.numericBlue1.ValueChanged += ConvertIntToHex;
            // 
            // labelContrast1
            // 
            this.labelContrast1.AutoSize = true;
            this.labelContrast1.Location = new System.Drawing.Point(360, 40);
            this.labelContrast1.Name = "labelContrast1";
            this.labelContrast1.Size = new System.Drawing.Size(32, 13);
            this.labelContrast1.Text = "Contrast";
            // 
            // textBoxContrast1
            // 
            this.textBoxContrast1.Location = new System.Drawing.Point(360, 60);
            this.textBoxContrast1.Name = "textBoxContrast1";
            this.textBoxContrast1.Size = new System.Drawing.Size(100, 20);
            this.textBoxContrast1.TabIndex = 5;
            this.textBoxContrast1.ReadOnly = true;

            // 
            // labelRedTrackbar
            // 
            this.labelRedTrackbar.AutoSize = true;
            this.labelRedTrackbar.Location = new System.Drawing.Point(520, 230);
            this.labelRedTrackbar.Name = "labelRedTrackbar";
            this.labelRedTrackbar.Size = new System.Drawing.Size(27, 13);
            this.labelRedTrackbar.Text = "Red: 0";
            // 
            // labelGreenTrackbar
            // 
            this.labelGreenTrackbar.AutoSize = true;
            this.labelGreenTrackbar.Location = new System.Drawing.Point(520, 300);
            this.labelGreenTrackbar.Name = "labelGreenTrackbar";
            this.labelGreenTrackbar.Size = new System.Drawing.Size(36, 13);
            this.labelGreenTrackbar.Text = "Green: 0";
            // 
            // labelBlueTrackbar
            // 
            this.labelBlueTrackbar.AutoSize = true;
            this.labelBlueTrackbar.Location = new System.Drawing.Point(520, 370);
            this.labelBlueTrackbar.Name = "labelBlueTrackbar";
            this.labelBlueTrackbar.Size = new System.Drawing.Size(28, 13);
            this.labelBlueTrackbar.Text = "Blue: 0";
            // 
            // trackbarRed
            // 
            this.trackbarRed.AutoSize = true;
            this.trackbarRed.Location = new System.Drawing.Point(520, 250);
            this.trackbarRed.Name = "trackbarRed";
            this.trackbarRed.Size = new System.Drawing.Size(200, 25);
            this.trackbarRed.Maximum = 255;
            this.trackbarRed.Minimum = 0;
            this.trackbarRed.TabIndex = 8;
            this.trackbarRed.ValueChanged += ChangeBgColor;
            // 
            // trackbarGreen
            // 
            this.trackbarGreen.AutoSize = true;
            this.trackbarGreen.Location = new System.Drawing.Point(520, 320);
            this.trackbarGreen.Name = "trackbarGreen";
            this.trackbarGreen.Size = new System.Drawing.Size(200, 25);
            this.trackbarGreen.Maximum = 255;
            this.trackbarGreen.Minimum = 0;
            this.trackbarGreen.TabIndex = 8;
            this.trackbarGreen.ValueChanged += ChangeBgColor;
            // 
            // trackbarBlue
            // 
            this.trackbarBlue.AutoSize = true;
            this.trackbarBlue.Location = new System.Drawing.Point(520, 390);
            this.trackbarBlue.Name = "trackbarBlue";
            this.trackbarBlue.Size = new System.Drawing.Size(200, 25);
            this.trackbarBlue.Maximum = 255;
            this.trackbarBlue.Minimum = 0;
            this.trackbarBlue.TabIndex = 8;
            this.trackbarBlue.ValueChanged += ChangeBgColor;
            // 
            // textBoxColor
            // 
            this.textBoxColor.Location = new System.Drawing.Point(520, 60);
            this.textBoxColor.Name = "textBoxColor";
            this.textBoxColor.Size = new System.Drawing.Size(200, 150);
            this.textBoxColor.TabStop = false;
            this.textBoxColor.ReadOnly = true;
            // 
            // labelContrastColor
            // 
            this.labelContrastColor.AutoSize = true;
            this.labelContrastColor.Location = new System.Drawing.Point(780, 40);
            this.labelContrastColor.Name = "labelContrastColor";
            this.labelContrastColor.Size = new System.Drawing.Size(32, 13);
            this.labelContrastColor.Text = "Contrast Color";
            // 
            // textBoxContrastColor
            // 
            this.textBoxContrastColor.Location = new System.Drawing.Point(780, 60);
            this.textBoxContrastColor.Name = "textBoxContrastColor";
            this.textBoxContrastColor.Size = new System.Drawing.Size(100, 20);
            this.textBoxContrastColor.TabIndex = 9;
            this.textBoxContrastColor.ReadOnly = true;

            // 
            // addColorButton
            // 
            this.addColorButton.Location = new System.Drawing.Point(Left + 20, this.Bottom + 105);
            this.addColorButton.Name = "addColorButton";
            this.addColorButton.Size = new System.Drawing.Size(75, 25);
            this.addColorButton.TabIndex = 7;
            this.addColorButton.Text = "Add Color";
            this.addColorButton.Click += AddColorBoxes;

            // 
            // ContrastForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.labelContrast1);
            this.Controls.Add(this.labelContrastColor);
            this.Controls.Add(this.labelHex1);
            this.Controls.Add(this.textBoxHex1);
            this.Controls.Add(this.labelBlue1);
            this.Controls.Add(this.labelGreen1);
            this.Controls.Add(this.labelRed1);
            this.Controls.Add(this.textBoxContrast1);
            this.Controls.Add(this.textBoxColor);
            this.Controls.Add(this.textBoxContrastColor);
            this.Controls.Add(this.numericBlue1);
            this.Controls.Add(this.numericGreen1);
            this.Controls.Add(this.numericRed1);
            this.Controls.Add(this.trackbarRed);
            this.Controls.Add(this.trackbarGreen);
            this.Controls.Add(this.trackbarBlue);
            this.Controls.Add(this.labelRedTrackbar);
            this.Controls.Add(this.labelGreenTrackbar);
            this.Controls.Add(this.labelBlueTrackbar);
            this.Controls.Add(this.addColorButton);
            this.Name = "ContrastForm";
            this.Text = "ContrastForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericRed1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericGreen1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericBlue1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addColorButton;
        private System.Windows.Forms.NumericUpDown numericRed1;
        private System.Windows.Forms.NumericUpDown numericGreen1;
        private System.Windows.Forms.NumericUpDown numericBlue1;
        private System.Windows.Forms.TextBox textBoxContrast1;
        private System.Windows.Forms.RichTextBox textBoxColor;
        private System.Windows.Forms.TextBox textBoxContrastColor;
        private System.Windows.Forms.Label labelRed1;
        private System.Windows.Forms.Label labelGreen1;
        private System.Windows.Forms.Label labelBlue1;
        private System.Windows.Forms.Label labelRedTrackbar;
        private System.Windows.Forms.Label labelGreenTrackbar;
        private System.Windows.Forms.Label labelBlueTrackbar;
        private System.Windows.Forms.TextBox textBoxHex1;
        private System.Windows.Forms.Label labelHex1;
        private System.Windows.Forms.Label labelContrast1;
        private System.Windows.Forms.Label labelContrastColor;
        private System.Windows.Forms.TrackBar trackbarRed;
        private System.Windows.Forms.TrackBar trackbarGreen;
        private System.Windows.Forms.TrackBar trackbarBlue;
    }
}

