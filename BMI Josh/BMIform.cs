using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_Josh
{
    /// <summary>
    /// BMI Calculator
    /// </summary>
    public partial class BMIform : Form
    {
        /// TextBox to store lasted focused item
        private TextBox _focusedControl;

        #region Constructor

        /// <summary>
        /// Default Constructor
        /// </summary>

        public BMIform()
        {
            InitializeComponent();
            ImperialRadioButton.Checked = true;
            // Automatically sets selector in my height textbox
            this.ActiveControl = MyHeightTextBox;
            // initializes focusedcontrol as my height textbox
            _focusedControl = this.MyHeightTextBox;
        }
        #endregion
        
        #region Number Buttons
        private void SevenButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("7");

            //Focus on the user input text
            FocusInputText();
        }

        private void EightButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("8");

            //Focus on the user input text
            FocusInputText();

        }

        private void NineButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("9");

            //Focus on the user input text
            FocusInputText();
        }

        private void FourButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("4");

            //Focus on the user input text
            FocusInputText();

        }

        private void FiveButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("5");

            //Focus on the user input text
            FocusInputText();

        }

        private void SixButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("6");

            //Focus on the user input text
            FocusInputText();

        }

        private void OneButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("1");

            //Focus on the user input text
            FocusInputText();

        }

        private void TwoButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("2");

            //Focus on the user input text
            FocusInputText();

        }

        private void ThreeButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("3");

            //Focus on the user input text
            FocusInputText();

        }

        private void ZeroButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("0");

            //Focus on the user input text
            FocusInputText();
        }

        private void PeriodButton_Click(object sender, EventArgs e)
        {
            InsertTextValue(".");

            //Focus on the user input text
            FocusInputText();
        }
        #endregion

        #region Calculate and Delete Button
        private void CalculateButton_Click(object sender, EventArgs e)
        {

        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            // fist if statement checks to see which textbox is active
            if (_focusedControl == this.MyHeightTextBox)
            {
                // second if statement ensures delete doesnt delete what isnt there and crashed the app
                if (this.MyHeightTextBox.Text.Length >= this.MyHeightTextBox.SelectionStart + 1)
                {
                    //selectionStart keeps track of where the cursor is
                    var selectionStart = this.MyHeightTextBox.SelectionStart;
                    // Deletes number before cursor 
                    this.MyHeightTextBox.Text = this.MyHeightTextBox.Text.Remove(this.MyHeightTextBox.SelectionStart, 1);
                    // keeps cursor in the correct position 
                    this.MyHeightTextBox.SelectionStart = selectionStart;
                    // resets selectionStart
                    selectionStart = 0;
                }
            }
            // fist if statement checks to see which textbox is active
            else if (_focusedControl == this.MyWeightTextBox)
            {
                // second if statement ensures delete doesnt delete what isnt there and crashed the app
                if (this.MyWeightTextBox.Text.Length >= this.MyWeightTextBox.SelectionStart+ 1)
                {
                    //selectionStart keeps track of where the cursor is
                    var selectionStart = this.MyHeightTextBox.SelectionStart;
                    // Deletes number before cursor 
                    this.MyWeightTextBox.Text = this.MyWeightTextBox.Text.Remove(this.MyWeightTextBox.SelectionStart, 1);
                    // keeps cursor in the correct position
                    this.MyHeightTextBox.SelectionStart = selectionStart;
                    // resets selectionStart
                    selectionStart = 0;
                }
            }
        }
        #endregion

        #region Input Forms
        private void MyHeightTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void MyHeightTextBox_Click(object sender, EventArgs e)
        {
            //Sets _focusControl to current active textbox to be used in FocusedInputText()
            _focusedControl = (TextBox)sender;
        }
        private void MyWeightTextBox_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        
        private void MyWeightTextBox_Click(object sender, EventArgs e)
        {
            //Sets _focusControl to current active textbox to be used in FocusedInputText()
            _focusedControl = (TextBox)sender;
        }

        #endregion

        #region radio buttons
        private void ImperialRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void MetricToggleButton_CheckedChanged(object sender, EventArgs e)
        {

        }
        #endregion

        #region ShowResultsBox
        private void CalculationResultText_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Reset button
        /// <summary>
        /// Clears users input
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguements</param>
        private void ResetButton_Click(object sender, EventArgs e)
        {
            // Clear the text from the user input text box
            this.MyWeightTextBox.Text = string.Empty;
            this.MyHeightTextBox.Text = string.Empty;
            this.ImperialRadioButton.Checked = true;
            this.MetricToggleButton.Checked = false;

        }
        #endregion

        #region Private Helpers
       
        private void FocusInputText()
        {
            /// Check which text box has focus and keep focus on it
            if (_focusedControl != null)
            {
                _focusedControl.Focus();
            }
        }

        private void InsertTextValue(string value)
        {
            // Check which text box is active and inserts the value of the number
            if (_focusedControl == this.MyHeightTextBox)
            {
                //Uses SelectionStart to remember position of cursor
                var selectionStart = this.MyHeightTextBox.SelectionStart;
                // inputs selected value
                this.MyHeightTextBox.Text = this.MyHeightTextBox.Text.Insert(this.MyHeightTextBox.SelectionStart, value);
                // keeps cursor at correct position
                this.MyHeightTextBox.SelectionStart = selectionStart + value.Length;

            } else if(_focusedControl == this.MyWeightTextBox){

                //Uses SelectionStart to remember position of cursor
                var selectionStart = this.MyWeightTextBox.SelectionStart;
                // inputs selected value
                this.MyWeightTextBox.Text = this.MyWeightTextBox.Text.Insert(this.MyWeightTextBox.SelectionStart, value);
                // keeps cursor at correct position
                this.MyWeightTextBox.SelectionStart = selectionStart + value.Length;

            }

            
        }

        #endregion
    }
}
