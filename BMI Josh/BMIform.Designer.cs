namespace BMI_Josh
{
    partial class BMIform
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BMIform));
            this.MyHeightLabel = new System.Windows.Forms.Label();
            this.MyHeightTextBox = new System.Windows.Forms.TextBox();
            this.MyWeightLabel = new System.Windows.Forms.Label();
            this.MyWeightTextBox = new System.Windows.Forms.TextBox();
            this.ImperialRadioButton = new System.Windows.Forms.RadioButton();
            this.MetricToggleButton = new System.Windows.Forms.RadioButton();
            this.CalculationResultText = new System.Windows.Forms.Label();
            this.ButtonsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.PeriodButton = new System.Windows.Forms.Button();
            this.ZeroButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ThreeButton = new System.Windows.Forms.Button();
            this.TwoButton = new System.Windows.Forms.Button();
            this.OneButton = new System.Windows.Forms.Button();
            this.SixButton = new System.Windows.Forms.Button();
            this.FiveButton = new System.Windows.Forms.Button();
            this.FourButton = new System.Windows.Forms.Button();
            this.NineButton = new System.Windows.Forms.Button();
            this.EightButton = new System.Windows.Forms.Button();
            this.SevenButton = new System.Windows.Forms.Button();
            this.CalculateBMIButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ResetButton = new System.Windows.Forms.Button();
            this.ButtonsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MyHeightLabel
            // 
            this.MyHeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.MyHeightLabel.Location = new System.Drawing.Point(14, 75);
            this.MyHeightLabel.Name = "MyHeightLabel";
            this.MyHeightLabel.Size = new System.Drawing.Size(278, 28);
            this.MyHeightLabel.TabIndex = 0;
            this.MyHeightLabel.Text = "My Height";
            this.MyHeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MyHeightTextBox
            // 
            this.MyHeightTextBox.AcceptsTab = true;
            this.MyHeightTextBox.Location = new System.Drawing.Point(15, 106);
            this.MyHeightTextBox.Multiline = true;
            this.MyHeightTextBox.Name = "MyHeightTextBox";
            this.MyHeightTextBox.Size = new System.Drawing.Size(274, 22);
            this.MyHeightTextBox.TabIndex = 1;
            this.MyHeightTextBox.TextChanged += new System.EventHandler(this.MyHeightTextBox_TextChanged);
            // 
            // MyWeightLabel
            // 
            this.MyWeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.MyWeightLabel.Location = new System.Drawing.Point(13, 131);
            this.MyWeightLabel.Name = "MyWeightLabel";
            this.MyWeightLabel.Size = new System.Drawing.Size(271, 28);
            this.MyWeightLabel.TabIndex = 2;
            this.MyWeightLabel.Text = "My Weight";
            this.MyWeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MyWeightTextBox
            // 
            this.MyWeightTextBox.AcceptsTab = true;
            this.MyWeightTextBox.Location = new System.Drawing.Point(16, 162);
            this.MyWeightTextBox.Multiline = true;
            this.MyWeightTextBox.Name = "MyWeightTextBox";
            this.MyWeightTextBox.Size = new System.Drawing.Size(274, 22);
            this.MyWeightTextBox.TabIndex = 3;
            this.MyWeightTextBox.TextChanged += new System.EventHandler(this.MyWeightTextBox_TextChanged);
            // 
            // ImperialRadioButton
            // 
            this.ImperialRadioButton.AutoSize = true;
            this.ImperialRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ImperialRadioButton.Location = new System.Drawing.Point(5, 17);
            this.ImperialRadioButton.Name = "ImperialRadioButton";
            this.ImperialRadioButton.Size = new System.Drawing.Size(75, 21);
            this.ImperialRadioButton.TabIndex = 4;
            this.ImperialRadioButton.TabStop = true;
            this.ImperialRadioButton.Text = "Imperial";
            this.ImperialRadioButton.UseVisualStyleBackColor = true;
            this.ImperialRadioButton.CheckedChanged += new System.EventHandler(this.ImperialRadioButton_CheckedChanged);
            // 
            // MetricToggleButton
            // 
            this.MetricToggleButton.AutoSize = true;
            this.MetricToggleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.MetricToggleButton.Location = new System.Drawing.Point(77, 17);
            this.MetricToggleButton.Name = "MetricToggleButton";
            this.MetricToggleButton.Size = new System.Drawing.Size(64, 21);
            this.MetricToggleButton.TabIndex = 5;
            this.MetricToggleButton.TabStop = true;
            this.MetricToggleButton.Text = "Metric";
            this.MetricToggleButton.UseVisualStyleBackColor = true;
            this.MetricToggleButton.CheckedChanged += new System.EventHandler(this.MetricToggleButton_CheckedChanged);
            // 
            // CalculationResultText
            // 
            this.CalculationResultText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.CalculationResultText.Location = new System.Drawing.Point(16, 197);
            this.CalculationResultText.Name = "CalculationResultText";
            this.CalculationResultText.Size = new System.Drawing.Size(274, 24);
            this.CalculationResultText.TabIndex = 6;
            this.CalculationResultText.Text = "Please enter your height and weight and press calculate";
            this.CalculationResultText.Click += new System.EventHandler(this.CalculationResultText_Click);
            // 
            // ButtonsPanel
            // 
            this.ButtonsPanel.ColumnCount = 3;
            this.ButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsPanel.Controls.Add(this.PeriodButton, 2, 3);
            this.ButtonsPanel.Controls.Add(this.ZeroButton, 1, 3);
            this.ButtonsPanel.Controls.Add(this.DeleteButton, 0, 3);
            this.ButtonsPanel.Controls.Add(this.ThreeButton, 2, 2);
            this.ButtonsPanel.Controls.Add(this.TwoButton, 1, 2);
            this.ButtonsPanel.Controls.Add(this.OneButton, 0, 2);
            this.ButtonsPanel.Controls.Add(this.SixButton, 2, 1);
            this.ButtonsPanel.Controls.Add(this.FiveButton, 1, 1);
            this.ButtonsPanel.Controls.Add(this.FourButton, 0, 1);
            this.ButtonsPanel.Controls.Add(this.NineButton, 2, 0);
            this.ButtonsPanel.Controls.Add(this.EightButton, 1, 0);
            this.ButtonsPanel.Controls.Add(this.SevenButton, 0, 0);
            this.ButtonsPanel.Location = new System.Drawing.Point(23, 224);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.RowCount = 4;
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPanel.Size = new System.Drawing.Size(260, 167);
            this.ButtonsPanel.TabIndex = 7;
            // 
            // PeriodButton
            // 
            this.PeriodButton.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.PeriodButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PeriodButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.PeriodButton.Location = new System.Drawing.Point(175, 126);
            this.PeriodButton.Name = "PeriodButton";
            this.PeriodButton.Size = new System.Drawing.Size(82, 38);
            this.PeriodButton.TabIndex = 11;
            this.PeriodButton.Text = ".";
            this.PeriodButton.UseVisualStyleBackColor = true;
            this.PeriodButton.Click += new System.EventHandler(this.PeriodButton_Click);
            // 
            // ZeroButton
            // 
            this.ZeroButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ZeroButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ZeroButton.Location = new System.Drawing.Point(89, 126);
            this.ZeroButton.Name = "ZeroButton";
            this.ZeroButton.Size = new System.Drawing.Size(80, 38);
            this.ZeroButton.TabIndex = 10;
            this.ZeroButton.Text = "0";
            this.ZeroButton.UseVisualStyleBackColor = true;
            this.ZeroButton.Click += new System.EventHandler(this.ZeroButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.DeleteButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DeleteButton.Location = new System.Drawing.Point(3, 126);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(80, 38);
            this.DeleteButton.TabIndex = 9;
            this.DeleteButton.Text = "Del";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ThreeButton
            // 
            this.ThreeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ThreeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ThreeButton.Location = new System.Drawing.Point(175, 85);
            this.ThreeButton.Name = "ThreeButton";
            this.ThreeButton.Size = new System.Drawing.Size(82, 35);
            this.ThreeButton.TabIndex = 8;
            this.ThreeButton.Text = "3";
            this.ThreeButton.UseVisualStyleBackColor = true;
            this.ThreeButton.Click += new System.EventHandler(this.ThreeButton_Click);
            // 
            // TwoButton
            // 
            this.TwoButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TwoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TwoButton.Location = new System.Drawing.Point(89, 85);
            this.TwoButton.Name = "TwoButton";
            this.TwoButton.Size = new System.Drawing.Size(80, 35);
            this.TwoButton.TabIndex = 7;
            this.TwoButton.Text = "2";
            this.TwoButton.UseVisualStyleBackColor = true;
            this.TwoButton.Click += new System.EventHandler(this.TwoButton_Click);
            // 
            // OneButton
            // 
            this.OneButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.OneButton.Location = new System.Drawing.Point(3, 85);
            this.OneButton.Name = "OneButton";
            this.OneButton.Size = new System.Drawing.Size(80, 35);
            this.OneButton.TabIndex = 6;
            this.OneButton.Text = "1";
            this.OneButton.UseVisualStyleBackColor = true;
            this.OneButton.Click += new System.EventHandler(this.OneButton_Click);
            // 
            // SixButton
            // 
            this.SixButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SixButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SixButton.Location = new System.Drawing.Point(175, 44);
            this.SixButton.Name = "SixButton";
            this.SixButton.Size = new System.Drawing.Size(82, 35);
            this.SixButton.TabIndex = 5;
            this.SixButton.Text = "6";
            this.SixButton.UseVisualStyleBackColor = true;
            this.SixButton.Click += new System.EventHandler(this.SixButton_Click);
            // 
            // FiveButton
            // 
            this.FiveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FiveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FiveButton.Location = new System.Drawing.Point(89, 44);
            this.FiveButton.Name = "FiveButton";
            this.FiveButton.Size = new System.Drawing.Size(80, 35);
            this.FiveButton.TabIndex = 4;
            this.FiveButton.Text = "5";
            this.FiveButton.UseVisualStyleBackColor = true;
            this.FiveButton.Click += new System.EventHandler(this.FiveButton_Click);
            // 
            // FourButton
            // 
            this.FourButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FourButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FourButton.Location = new System.Drawing.Point(3, 44);
            this.FourButton.Name = "FourButton";
            this.FourButton.Size = new System.Drawing.Size(80, 35);
            this.FourButton.TabIndex = 3;
            this.FourButton.Text = "4";
            this.FourButton.UseVisualStyleBackColor = true;
            this.FourButton.Click += new System.EventHandler(this.FourButton_Click);
            // 
            // NineButton
            // 
            this.NineButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NineButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.NineButton.Location = new System.Drawing.Point(175, 3);
            this.NineButton.Name = "NineButton";
            this.NineButton.Size = new System.Drawing.Size(82, 35);
            this.NineButton.TabIndex = 2;
            this.NineButton.Text = "9";
            this.NineButton.UseVisualStyleBackColor = true;
            this.NineButton.Click += new System.EventHandler(this.NineButton_Click);
            // 
            // EightButton
            // 
            this.EightButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.EightButton.Location = new System.Drawing.Point(89, 3);
            this.EightButton.Name = "EightButton";
            this.EightButton.Size = new System.Drawing.Size(80, 35);
            this.EightButton.TabIndex = 1;
            this.EightButton.Text = "8";
            this.EightButton.UseVisualStyleBackColor = true;
            this.EightButton.Click += new System.EventHandler(this.EightButton_Click);
            // 
            // SevenButton
            // 
            this.SevenButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SevenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SevenButton.Location = new System.Drawing.Point(3, 3);
            this.SevenButton.Name = "SevenButton";
            this.SevenButton.Size = new System.Drawing.Size(80, 35);
            this.SevenButton.TabIndex = 0;
            this.SevenButton.Text = "7";
            this.SevenButton.UseVisualStyleBackColor = true;
            this.SevenButton.Click += new System.EventHandler(this.SevenButton_Click);
            // 
            // CalculateBMIButton
            // 
            this.CalculateBMIButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.CalculateBMIButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CalculateBMIButton.Location = new System.Drawing.Point(204, 397);
            this.CalculateBMIButton.Name = "CalculateBMIButton";
            this.CalculateBMIButton.Size = new System.Drawing.Size(80, 37);
            this.CalculateBMIButton.TabIndex = 8;
            this.CalculateBMIButton.Text = "Calculate BMI";
            this.CalculateBMIButton.UseVisualStyleBackColor = true;
            this.CalculateBMIButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(147, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // ResetButton
            // 
            this.ResetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ResetButton.Location = new System.Drawing.Point(23, 398);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(80, 36);
            this.ResetButton.TabIndex = 12;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // BMIform
            // 
            this.AcceptButton = this.CalculateBMIButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.DeleteButton;
            this.ClientSize = new System.Drawing.Size(304, 441);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CalculateBMIButton);
            this.Controls.Add(this.ButtonsPanel);
            this.Controls.Add(this.CalculationResultText);
            this.Controls.Add(this.MetricToggleButton);
            this.Controls.Add(this.ImperialRadioButton);
            this.Controls.Add(this.MyWeightTextBox);
            this.Controls.Add(this.MyWeightLabel);
            this.Controls.Add(this.MyHeightTextBox);
            this.Controls.Add(this.MyHeightLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(7);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(320, 480);
            this.MinimumSize = new System.Drawing.Size(320, 480);
            this.Name = "BMIform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator";
            this.ButtonsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MyHeightLabel;
        private System.Windows.Forms.TextBox MyHeightTextBox;
        private System.Windows.Forms.Label MyWeightLabel;
        private System.Windows.Forms.TextBox MyWeightTextBox;
        private System.Windows.Forms.RadioButton ImperialRadioButton;
        private System.Windows.Forms.RadioButton MetricToggleButton;
        private System.Windows.Forms.Label CalculationResultText;
        private System.Windows.Forms.TableLayoutPanel ButtonsPanel;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button ThreeButton;
        private System.Windows.Forms.Button TwoButton;
        private System.Windows.Forms.Button OneButton;
        private System.Windows.Forms.Button SixButton;
        private System.Windows.Forms.Button FiveButton;
        private System.Windows.Forms.Button FourButton;
        private System.Windows.Forms.Button NineButton;
        private System.Windows.Forms.Button EightButton;
        private System.Windows.Forms.Button SevenButton;
        private System.Windows.Forms.Button PeriodButton;
        private System.Windows.Forms.Button ZeroButton;
        private System.Windows.Forms.Button CalculateBMIButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.Button ResetButton;
    }
}

