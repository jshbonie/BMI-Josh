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
        /// <summary>
        /// Control to check lasted focused item
        /// </summary>
        private TextBox _focusedControl;

        #region Constructor

        /// <summary>
        /// Default Constructor
        /// </summary>

        public BMIform()
        {
            InitializeComponent();
            ImperialRadioButton.Checked = true;
            this.ActiveControl = MyHeightTextBox;
            _focusedControl = this.MyHeightTextBox;
        }
        #endregion
        
        #region Number Buttons
        private void SevenButton_Click(object sender, EventArgs e)
        {
            FocusInputText();
        }

        private void EightButton_Click(object sender, EventArgs e)
        {
            FocusInputText();

        }

        private void NineButton_Click(object sender, EventArgs e)
        {
            FocusInputText();

        }

        private void FourButton_Click(object sender, EventArgs e)
        {
            FocusInputText();

        }

        private void FiveButton_Click(object sender, EventArgs e)
        {
            FocusInputText();

        }

        private void SixButton_Click(object sender, EventArgs e)
        {
            FocusInputText();

        }

        private void OneButton_Click(object sender, EventArgs e)
        {
            FocusInputText();

        }

        private void TwoButton_Click(object sender, EventArgs e)
        {
            FocusInputText();

        }

        private void ThreeButton_Click(object sender, EventArgs e)
        {
            FocusInputText();

        }

        private void ZeroButton_Click(object sender, EventArgs e)
        {
            FocusInputText();
        }

        private void PeriodButton_Click(object sender, EventArgs e)
        {
            FocusInputText();
        }
        #endregion

        #region Calculate and Delete Button
        private void CalculateButton_Click(object sender, EventArgs e)
        {

        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Input Forms
        private void MyHeightTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        //Sets _focusControl to current active textbox to be used in FocusedInputText()
        private void MyHeightTextBox_Click(object sender, EventArgs e)
        {
                _focusedControl = (TextBox)sender;
        }
        private void MyWeightTextBox_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        //Sets _focusControl to current active textbox to be used in FocusedInputText()
        private void MyWeightTextBox_Click(object sender, EventArgs e)
        {
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
            this.ImperialRadioButton.Checked = false;
            this.MetricToggleButton.Checked = false;

        }
        #endregion

        #region Private Helpers
        /// <summary>
        /// Check which text box has focus and keep focus on it
        /// </summary>
        private void FocusInputText()
        {
            if (_focusedControl != null)
            {
                _focusedControl.Focus();
            }
        }

        #endregion
    }
}
