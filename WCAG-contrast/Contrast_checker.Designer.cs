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
            this.numericRed2 = new System.Windows.Forms.NumericUpDown();
            this.numericGreen2 = new System.Windows.Forms.NumericUpDown();
            this.numericBlue2 = new System.Windows.Forms.NumericUpDown();
            this.textBoxContrast1 = new System.Windows.Forms.TextBox();
            this.textBoxContrast2 = new System.Windows.Forms.TextBox();
            this.textBoxColor = new System.Windows.Forms.RichTextBox();
            this.labelRed1 = new System.Windows.Forms.Label();
            this.labelGreen1 = new System.Windows.Forms.Label();
            this.labelBlue1 = new System.Windows.Forms.Label();
            this.labelRed2 = new System.Windows.Forms.Label();
            this.labelGreen2 = new System.Windows.Forms.Label();
            this.labelBlue2 = new System.Windows.Forms.Label();
            this.labelRedTrackbar = new System.Windows.Forms.Label();
            this.labelGreenTrackbar = new System.Windows.Forms.Label();
            this.labelBlueTrackbar = new System.Windows.Forms.Label();
            this.textBoxHex1 = new System.Windows.Forms.TextBox();
            this.textBoxHex2 = new System.Windows.Forms.TextBox();
            this.labelHex1 = new System.Windows.Forms.Label();
            this.labelHex2 = new System.Windows.Forms.Label();
            this.labelContrast1 = new System.Windows.Forms.Label();
            this.labelContrast2 = new System.Windows.Forms.Label();
            this.trackbarRed = new System.Windows.Forms.TrackBar();
            this.trackbarGreen = new System.Windows.Forms.TrackBar();
            this.trackbarBlue = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.numericRed1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericGreen1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericBlue1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericRed2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericGreen2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericBlue2)).BeginInit();
            this.SuspendLayout();
            // 
            // labelHex1
            // 
            this.labelHex1.AutoSize = true;
            this.labelHex1.Location = new System.Drawing.Point(20, 40);
            this.labelHex1.Name = "labelHex1";
            this.labelHex1.Size = new System.Drawing.Size(32, 13);
            this.labelHex1.TabIndex = 13;
            this.labelHex1.Text = "Hex1";
            // 
            // textBoxHex1
            // 
            this.textBoxHex1.Location = new System.Drawing.Point(20, 60);
            this.textBoxHex1.Name = "textBoxHex1";
            this.textBoxHex1.Size = new System.Drawing.Size(50, 20);
            this.textBoxHex1.Text = "#000000";
            this.textBoxHex1.TabIndex = 11;
            this.textBoxHex1.Leave += convertHexToInt;
            // 
            // labelRed1
            // 
            this.labelRed1.AutoSize = true;
            this.labelRed1.Location = new System.Drawing.Point(80, 40);
            this.labelRed1.Name = "labelRed1";
            this.labelRed1.Size = new System.Drawing.Size(27, 13);
            this.labelRed1.TabIndex = 5;
            this.labelRed1.Text = "Red";
            // 
            // labelGreen1
            // 
            this.labelGreen1.AutoSize = true;
            this.labelGreen1.Location = new System.Drawing.Point(140, 40);
            this.labelGreen1.Name = "labelGreen1";
            this.labelGreen1.Size = new System.Drawing.Size(36, 13);
            this.labelGreen1.TabIndex = 4;
            this.labelGreen1.Text = "Green";
            // 
            // labelBlue1
            // 
            this.labelBlue1.AutoSize = true;
            this.labelBlue1.Location = new System.Drawing.Point(200, 40);
            this.labelBlue1.Name = "labelBlue1";
            this.labelBlue1.Size = new System.Drawing.Size(28, 13);
            this.labelBlue1.TabIndex = 3;
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
            this.numericRed1.TabIndex = 3;
            this.numericRed1.ValueChanged += convertIntToHex;
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
            this.numericGreen1.TabIndex = 4;
            this.numericGreen1.ValueChanged += convertIntToHex;
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
            this.numericBlue1.TabIndex = 5;
            this.numericBlue1.ValueChanged += convertIntToHex;
            // 
            // labelContrast1
            // 
            this.labelContrast1.AutoSize = true;
            this.labelContrast1.Location = new System.Drawing.Point(360, 40);
            this.labelContrast1.Name = "labelContrast1";
            this.labelContrast1.Size = new System.Drawing.Size(32, 13);
            this.labelContrast1.TabIndex = 15;
            this.labelContrast1.Text = "Contrast";
            // 
            // textBoxContrast1
            // 
            this.textBoxContrast1.Location = new System.Drawing.Point(360, 60);
            this.textBoxContrast1.Name = "textBoxContrast1";
            this.textBoxContrast1.Size = new System.Drawing.Size(100, 20);
            this.textBoxContrast1.TabIndex = 6;
            this.textBoxContrast1.ReadOnly = true;


            // 
            // labelHex2
            // 
            this.labelHex2.AutoSize = true;
            this.labelHex2.Location = new System.Drawing.Point(20, 100);
            this.labelHex2.Name = "labelHex2";
            this.labelHex2.Size = new System.Drawing.Size(32, 13);
            this.labelHex2.TabIndex = 14;
            this.labelHex2.Text = "Hex2";
            // 
            // textBoxHex2
            // 
            this.textBoxHex2.Location = new System.Drawing.Point(20, 120);
            this.textBoxHex2.Name = "textBoxHex2";
            this.textBoxHex2.Size = new System.Drawing.Size(50, 20);
            this.textBoxHex2.Text = "#000000";
            this.textBoxHex2.TabIndex = 12;
            this.textBoxHex2.Leave += convertHexToInt;
            // 
            // labelRed2
            // 
            this.labelRed2.AutoSize = true;
            this.labelRed2.Location = new System.Drawing.Point(80, 100);
            this.labelRed2.Name = "labelRed2";
            this.labelRed2.Size = new System.Drawing.Size(27, 13);
            this.labelRed2.TabIndex = 2;
            this.labelRed2.Text = "Red";
            // 
            // labelGreen2
            // 
            this.labelGreen2.AutoSize = true;
            this.labelGreen2.Location = new System.Drawing.Point(140, 100);
            this.labelGreen2.Name = "labelGreen2";
            this.labelGreen2.Size = new System.Drawing.Size(36, 13);
            this.labelGreen2.TabIndex = 1;
            this.labelGreen2.Text = "Green";
            // 
            // labelBlue2
            // 
            this.labelBlue2.AutoSize = true;
            this.labelBlue2.Location = new System.Drawing.Point(200, 100);
            this.labelBlue2.Name = "labelBlue2";
            this.labelBlue2.Size = new System.Drawing.Size(28, 13);
            this.labelBlue2.TabIndex = 0;
            this.labelBlue2.Text = "Blue";
            // 
            // numericRed2
            // 
            this.numericRed2.Location = new System.Drawing.Point(80, 120);
            this.numericRed2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericRed2.Name = "numericRed2";
            this.numericRed2.Size = new System.Drawing.Size(53, 20);
            this.numericRed2.TabIndex = 8;
            this.numericRed2.ValueChanged += convertIntToHex;
            // 
            // numericGreen2
            // 
            this.numericGreen2.Location = new System.Drawing.Point(140, 120);
            this.numericGreen2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericGreen2.Name = "numericGreen2";
            this.numericGreen2.Size = new System.Drawing.Size(53, 20);
            this.numericGreen2.TabIndex = 9;
            this.numericGreen2.ValueChanged += convertIntToHex;
            // 
            // numericBlue2
            // 
            this.numericBlue2.Location = new System.Drawing.Point(200, 120);
            this.numericBlue2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericBlue2.Name = "numericBlue2";
            this.numericBlue2.Size = new System.Drawing.Size(55, 20);
            this.numericBlue2.TabIndex = 10;
            this.numericBlue2.ValueChanged += convertIntToHex;
            // 
            // labelContrast2
            // 
            this.labelContrast2.AutoSize = true;
            this.labelContrast2.Location = new System.Drawing.Point(360, 100);
            this.labelContrast2.Name = "labelContrast2";
            this.labelContrast2.Size = new System.Drawing.Size(32, 13);
            this.labelContrast2.TabIndex = 15;
            this.labelContrast2.Text = "Contrast";
            // 
            // textBoxContrast2
            // 
            this.textBoxContrast2.Location = new System.Drawing.Point(360, 120);
            this.textBoxContrast2.Name = "textBoxContrast2";
            this.textBoxContrast2.Size = new System.Drawing.Size(100, 20);
            this.textBoxContrast2.TabIndex = 6;
            this.textBoxContrast2.ReadOnly = true;
            // 
            // labelRedTrackbar
            // 
            this.labelRedTrackbar.AutoSize = true;
            this.labelRedTrackbar.Location = new System.Drawing.Point(520, 230);
            this.labelRedTrackbar.Name = "labelRedTrackbar";
            this.labelRedTrackbar.Size = new System.Drawing.Size(27, 13);
            this.labelRedTrackbar.TabIndex = 2;
            this.labelRedTrackbar.Text = "Red: 0";
            // 
            // labelGreenTrackbar
            // 
            this.labelGreenTrackbar.AutoSize = true;
            this.labelGreenTrackbar.Location = new System.Drawing.Point(520, 300);
            this.labelGreenTrackbar.Name = "labelGreenTrackbar";
            this.labelGreenTrackbar.Size = new System.Drawing.Size(36, 13);
            this.labelGreenTrackbar.TabIndex = 1;
            this.labelGreenTrackbar.Text = "Green: 0";
            // 
            // labelBlueTrackbar
            // 
            this.labelBlueTrackbar.AutoSize = true;
            this.labelBlueTrackbar.Location = new System.Drawing.Point(520, 370);
            this.labelBlueTrackbar.Name = "labelBlueTrackbar";
            this.labelBlueTrackbar.Size = new System.Drawing.Size(28, 13);
            this.labelBlueTrackbar.TabIndex = 0;
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
            this.trackbarRed.TabIndex = 15;
            this.trackbarRed.ValueChanged += changeBgColor;
            // 
            // trackbarGreen
            // 
            this.trackbarGreen.AutoSize = true;
            this.trackbarGreen.Location = new System.Drawing.Point(520, 320);
            this.trackbarGreen.Name = "trackbarGreen";
            this.trackbarGreen.Size = new System.Drawing.Size(200, 25);
            this.trackbarGreen.Maximum = 255;
            this.trackbarGreen.Minimum = 0;
            this.trackbarGreen.TabIndex = 15;
            this.trackbarGreen.ValueChanged += changeBgColor;
            // 
            // trackbarBlue
            // 
            this.trackbarBlue.AutoSize = true;
            this.trackbarBlue.Location = new System.Drawing.Point(520, 390);
            this.trackbarBlue.Name = "trackbarBlue";
            this.trackbarBlue.Size = new System.Drawing.Size(200, 25);
            this.trackbarBlue.Maximum = 255;
            this.trackbarBlue.Minimum = 0;
            this.trackbarBlue.TabIndex = 15;
            this.trackbarBlue.ValueChanged += changeBgColor;
            // 
            // textBoxColor
            // 
            this.textBoxColor.Location = new System.Drawing.Point(520, 60);
            this.textBoxColor.Name = "textBoxColor";
            this.textBoxColor.Size = new System.Drawing.Size(200, 150);
            this.textBoxColor.TabIndex = 6;
            this.textBoxColor.ReadOnly = true;
            // 
            // ContrastForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelContrast1);
            this.Controls.Add(this.labelHex2);
            this.Controls.Add(this.labelHex1);
            this.Controls.Add(this.textBoxHex2);
            this.Controls.Add(this.textBoxHex1);
            this.Controls.Add(this.labelBlue2);
            this.Controls.Add(this.labelGreen2);
            this.Controls.Add(this.labelRed2);
            this.Controls.Add(this.labelBlue1);
            this.Controls.Add(this.labelGreen1);
            this.Controls.Add(this.labelRed1);
            this.Controls.Add(this.numericRed2);
            this.Controls.Add(this.numericGreen2);
            this.Controls.Add(this.numericBlue2);
            this.Controls.Add(this.textBoxContrast1);
            this.Controls.Add(this.textBoxColor);
            this.Controls.Add(this.numericBlue1);
            this.Controls.Add(this.numericGreen1);
            this.Controls.Add(this.numericRed1);
            this.Controls.Add(this.trackbarRed);
            this.Controls.Add(this.trackbarGreen);
            this.Controls.Add(this.trackbarBlue);
            this.Controls.Add(this.labelRedTrackbar);
            this.Controls.Add(this.labelGreenTrackbar);
            this.Controls.Add(this.labelBlueTrackbar);
            this.Controls.Add(this.labelContrast2);
            this.Controls.Add(this.textBoxContrast2);
            this.Name = "ContrastForm";
            this.Text = "ContrastForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericRed1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericGreen1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericBlue1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericRed2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericGreen2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericBlue2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown numericRed1;
        private System.Windows.Forms.NumericUpDown numericGreen1;
        private System.Windows.Forms.NumericUpDown numericBlue1;
        private System.Windows.Forms.NumericUpDown numericRed2;
        private System.Windows.Forms.NumericUpDown numericGreen2;
        private System.Windows.Forms.NumericUpDown numericBlue2;
        private System.Windows.Forms.TextBox textBoxContrast1;
        private System.Windows.Forms.TextBox textBoxContrast2;
        private System.Windows.Forms.RichTextBox textBoxColor;
        private System.Windows.Forms.Label labelRed1;
        private System.Windows.Forms.Label labelGreen1;
        private System.Windows.Forms.Label labelBlue1;
        private System.Windows.Forms.Label labelRed2;
        private System.Windows.Forms.Label labelGreen2;
        private System.Windows.Forms.Label labelBlue2;
        private System.Windows.Forms.Label labelRedTrackbar;
        private System.Windows.Forms.Label labelGreenTrackbar;
        private System.Windows.Forms.Label labelBlueTrackbar;
        private System.Windows.Forms.TextBox textBoxHex1;
        private System.Windows.Forms.TextBox textBoxHex2;
        private System.Windows.Forms.Label labelHex1;
        private System.Windows.Forms.Label labelHex2;
        private System.Windows.Forms.Label labelContrast1;
        private System.Windows.Forms.Label labelContrast2;
        private System.Windows.Forms.TrackBar trackbarRed;
        private System.Windows.Forms.TrackBar trackbarGreen;
        private System.Windows.Forms.TrackBar trackbarBlue;
    }
}

