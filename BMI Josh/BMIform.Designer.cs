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
            this.SuspendLayout();
            // 
            // MyHeightLabel
            // 
            this.MyHeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.MyHeightLabel.Location = new System.Drawing.Point(12, 9);
            this.MyHeightLabel.Name = "MyHeightLabel";
            this.MyHeightLabel.Size = new System.Drawing.Size(278, 28);
            this.MyHeightLabel.TabIndex = 0;
            this.MyHeightLabel.Text = "My Height";
            this.MyHeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MyHeightTextBox
            // 
            this.MyHeightTextBox.AcceptsTab = true;
            this.MyHeightTextBox.Location = new System.Drawing.Point(16, 40);
            this.MyHeightTextBox.Multiline = true;
            this.MyHeightTextBox.Name = "MyHeightTextBox";
            this.MyHeightTextBox.Size = new System.Drawing.Size(274, 22);
            this.MyHeightTextBox.TabIndex = 1;
            this.MyHeightTextBox.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // BMIform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 433);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MyHeightLabel;
        private System.Windows.Forms.TextBox MyHeightTextBox;
    }
}

