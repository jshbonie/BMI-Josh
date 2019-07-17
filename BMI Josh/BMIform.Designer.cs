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
            this.MyHeightLabel = new System.Windows.Forms.Label();
            this.MyHeightTextBox = new System.Windows.Forms.TextBox();
            this.MyWeightLabel = new System.Windows.Forms.Label();
            this.MyWeightTextBox = new System.Windows.Forms.TextBox();
            this.ImperialRadioButton = new System.Windows.Forms.RadioButton();
            this.MetricToggleButton = new System.Windows.Forms.RadioButton();
            this.CalculationResultText = new System.Windows.Forms.Label();
            this.ButtonsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.SevenButton = new System.Windows.Forms.Button();
            this.EightButton = new System.Windows.Forms.Button();
            this.NineButton = new System.Windows.Forms.Button();
            this.FourButton = new System.Windows.Forms.Button();
            this.FiveButton = new System.Windows.Forms.Button();
            this.SixButton = new System.Windows.Forms.Button();
            this.OneButton = new System.Windows.Forms.Button();
            this.TwoButton = new System.Windows.Forms.Button();
            this.ThreeButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ZeroButton = new System.Windows.Forms.Button();
            this.PeriodButton = new System.Windows.Forms.Button();
            this.ButtonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MyHeightLabel
            // 
            this.MyHeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.MyHeightLabel.Location = new System.Drawing.Point(12, 54);
            this.MyHeightLabel.Name = "MyHeightLabel";
            this.MyHeightLabel.Size = new System.Drawing.Size(278, 28);
            this.MyHeightLabel.TabIndex = 0;
            this.MyHeightLabel.Text = "My Height";
            this.MyHeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MyHeightTextBox
            // 
            this.MyHeightTextBox.AcceptsTab = true;
            this.MyHeightTextBox.Location = new System.Drawing.Point(16, 85);
            this.MyHeightTextBox.Multiline = true;
            this.MyHeightTextBox.Name = "MyHeightTextBox";
            this.MyHeightTextBox.Size = new System.Drawing.Size(274, 22);
            this.MyHeightTextBox.TabIndex = 1;
            this.MyHeightTextBox.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // MyWeightLabel
            // 
            this.MyWeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.MyWeightLabel.Location = new System.Drawing.Point(12, 110);
            this.MyWeightLabel.Name = "MyWeightLabel";
            this.MyWeightLabel.Size = new System.Drawing.Size(271, 28);
            this.MyWeightLabel.TabIndex = 2;
            this.MyWeightLabel.Text = "My Weight";
            this.MyWeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MyWeightTextBox
            // 
            this.MyWeightTextBox.AcceptsTab = true;
            this.MyWeightTextBox.Location = new System.Drawing.Point(16, 141);
            this.MyWeightTextBox.Multiline = true;
            this.MyWeightTextBox.Name = "MyWeightTextBox";
            this.MyWeightTextBox.Size = new System.Drawing.Size(274, 22);
            this.MyWeightTextBox.TabIndex = 3;
            // 
            // ImperialRadioButton
            // 
            this.ImperialRadioButton.AutoSize = true;
            this.ImperialRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ImperialRadioButton.Location = new System.Drawing.Point(16, 17);
            this.ImperialRadioButton.Name = "ImperialRadioButton";
            this.ImperialRadioButton.Size = new System.Drawing.Size(89, 24);
            this.ImperialRadioButton.TabIndex = 4;
            this.ImperialRadioButton.TabStop = true;
            this.ImperialRadioButton.Text = "Imperial";
            this.ImperialRadioButton.UseVisualStyleBackColor = true;
            // 
            // MetricToggleButton
            // 
            this.MetricToggleButton.AutoSize = true;
            this.MetricToggleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.MetricToggleButton.Location = new System.Drawing.Point(121, 17);
            this.MetricToggleButton.Name = "MetricToggleButton";
            this.MetricToggleButton.Size = new System.Drawing.Size(77, 24);
            this.MetricToggleButton.TabIndex = 5;
            this.MetricToggleButton.TabStop = true;
            this.MetricToggleButton.Text = "Metric";
            this.MetricToggleButton.UseVisualStyleBackColor = true;
            this.MetricToggleButton.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // CalculationResultText
            // 
            this.CalculationResultText.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.CalculationResultText.Location = new System.Drawing.Point(16, 184);
            this.CalculationResultText.Name = "CalculationResultText";
            this.CalculationResultText.Size = new System.Drawing.Size(274, 24);
            this.CalculationResultText.TabIndex = 6;
            this.CalculationResultText.Text = "Please enter your height and weight and press enter or =";
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
            this.ButtonsPanel.Size = new System.Drawing.Size(260, 197);
            this.ButtonsPanel.TabIndex = 7;
            // 
            // SevenButton
            // 
            this.SevenButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SevenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SevenButton.Location = new System.Drawing.Point(3, 3);
            this.SevenButton.Name = "SevenButton";
            this.SevenButton.Size = new System.Drawing.Size(80, 43);
            this.SevenButton.TabIndex = 0;
            this.SevenButton.Text = "7";
            this.SevenButton.UseVisualStyleBackColor = true;
            // 
            // EightButton
            // 
            this.EightButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.EightButton.Location = new System.Drawing.Point(89, 3);
            this.EightButton.Name = "EightButton";
            this.EightButton.Size = new System.Drawing.Size(80, 43);
            this.EightButton.TabIndex = 1;
            this.EightButton.Text = "8";
            this.EightButton.UseVisualStyleBackColor = true;
            // 
            // NineButton
            // 
            this.NineButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NineButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.NineButton.Location = new System.Drawing.Point(175, 3);
            this.NineButton.Name = "NineButton";
            this.NineButton.Size = new System.Drawing.Size(82, 43);
            this.NineButton.TabIndex = 2;
            this.NineButton.Text = "9";
            this.NineButton.UseVisualStyleBackColor = true;
            // 
            // FourButton
            // 
            this.FourButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FourButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FourButton.Location = new System.Drawing.Point(3, 52);
            this.FourButton.Name = "FourButton";
            this.FourButton.Size = new System.Drawing.Size(80, 43);
            this.FourButton.TabIndex = 3;
            this.FourButton.Text = "4";
            this.FourButton.UseVisualStyleBackColor = true;
            // 
            // FiveButton
            // 
            this.FiveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FiveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FiveButton.Location = new System.Drawing.Point(89, 52);
            this.FiveButton.Name = "FiveButton";
            this.FiveButton.Size = new System.Drawing.Size(80, 43);
            this.FiveButton.TabIndex = 4;
            this.FiveButton.Text = "5";
            this.FiveButton.UseVisualStyleBackColor = true;
            // 
            // SixButton
            // 
            this.SixButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SixButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SixButton.Location = new System.Drawing.Point(175, 52);
            this.SixButton.Name = "SixButton";
            this.SixButton.Size = new System.Drawing.Size(82, 43);
            this.SixButton.TabIndex = 5;
            this.SixButton.Text = "6";
            this.SixButton.UseVisualStyleBackColor = true;
            // 
            // OneButton
            // 
            this.OneButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.OneButton.Location = new System.Drawing.Point(3, 101);
            this.OneButton.Name = "OneButton";
            this.OneButton.Size = new System.Drawing.Size(80, 43);
            this.OneButton.TabIndex = 6;
            this.OneButton.Text = "1";
            this.OneButton.UseVisualStyleBackColor = true;
            // 
            // TwoButton
            // 
            this.TwoButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TwoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TwoButton.Location = new System.Drawing.Point(89, 101);
            this.TwoButton.Name = "TwoButton";
            this.TwoButton.Size = new System.Drawing.Size(80, 43);
            this.TwoButton.TabIndex = 7;
            this.TwoButton.Text = "2";
            this.TwoButton.UseVisualStyleBackColor = true;
            // 
            // ThreeButton
            // 
            this.ThreeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ThreeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ThreeButton.Location = new System.Drawing.Point(175, 101);
            this.ThreeButton.Name = "ThreeButton";
            this.ThreeButton.Size = new System.Drawing.Size(82, 43);
            this.ThreeButton.TabIndex = 8;
            this.ThreeButton.Text = "3";
            this.ThreeButton.UseVisualStyleBackColor = true;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DeleteButton.Location = new System.Drawing.Point(3, 150);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(80, 44);
            this.DeleteButton.TabIndex = 9;
            this.DeleteButton.Text = "Del";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.Button4_Click);
            // 
            // ZeroButton
            // 
            this.ZeroButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ZeroButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ZeroButton.Location = new System.Drawing.Point(89, 150);
            this.ZeroButton.Name = "ZeroButton";
            this.ZeroButton.Size = new System.Drawing.Size(80, 44);
            this.ZeroButton.TabIndex = 10;
            this.ZeroButton.Text = "0";
            this.ZeroButton.UseVisualStyleBackColor = true;
            // 
            // PeriodButton
            // 
            this.PeriodButton.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.PeriodButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PeriodButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.PeriodButton.Location = new System.Drawing.Point(175, 150);
            this.PeriodButton.Name = "PeriodButton";
            this.PeriodButton.Size = new System.Drawing.Size(82, 44);
            this.PeriodButton.TabIndex = 11;
            this.PeriodButton.Text = ".";
            this.PeriodButton.UseVisualStyleBackColor = true;
            // 
            // BMIform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 433);
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
    }
}

