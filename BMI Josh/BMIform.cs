using System;
using System.Windows.Forms;

namespace BMI_Josh
{
    /// <summary>
    /// BMI Calculator
    /// </summary>
    public partial class BMIform : Form
    {
        //Class properties
        public string outputString { get; set; }
        public float outputValue { get; set; }
        public bool decimalExists { get; set; }

        /// TextBox to store last focused textbox
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
            outputString = "0";

            MyHeightTextBox.Text = "0";
            MyWeightTextBox.Text = "0";
            _focusedControl = this.MyHeightTextBox;

            FocusInputText();
        }
        #endregion
        
        #region Number Buttons
        private void SevenButton_Click(object sender, EventArgs e)
        {
            //Insert the value in the user input text boxes at the currently selected position
            InsertTextValue("7");

            //Focus on the user input text
            FocusInputText();
        }

        private void EightButton_Click(object sender, EventArgs e)
        {
            //Insert the value in the user input text boxes at the currently selected position
            InsertTextValue("8");

            //Focus on the user input text
            FocusInputText();

        }

        private void NineButton_Click(object sender, EventArgs e)
        {
            //Insert the value in the user input text boxes at the currently selected position
            InsertTextValue("9");

            //Focus on the user input text
            FocusInputText();
        }

        private void FourButton_Click(object sender, EventArgs e)
        {
            //Insert the value in the user input text boxes at the currently selected position
            InsertTextValue("4");

            //Focus on the user input text
            FocusInputText();

        }

        private void FiveButton_Click(object sender, EventArgs e)
        {
            //Insert the value in the user input text boxes at the currently selected position
            InsertTextValue("5");

            //Focus on the user input text
            FocusInputText();

        }

        private void SixButton_Click(object sender, EventArgs e)
        {
            //Insert the value in the user input text boxes at the currently selected position
            InsertTextValue("6");

            //Focus on the user input text
            FocusInputText();

        }

        private void OneButton_Click(object sender, EventArgs e)
        {
            //Insert the value in the user input text boxes at the currently selected position
            InsertTextValue("1");

            //Focus on the user input text
            FocusInputText();

        }

        private void TwoButton_Click(object sender, EventArgs e)
        {
            //Insert the value in the user input text boxes at the currently selected position
            InsertTextValue("2");

            //Focus on the user input text
            FocusInputText();

        }

        private void ThreeButton_Click(object sender, EventArgs e)
        {
            //Insert the value in the user input text boxes at the currently selected position
            InsertTextValue("3");

            //Focus on the user input text
            FocusInputText();

        }

        private void ZeroButton_Click(object sender, EventArgs e)
        {
            
                if (outputString != "0")
                {
                InsertTextValue("0");   
                }
            //Focus on the user input text
            FocusInputText();
        }

        private void PeriodButton_Click(object sender, EventArgs e)
        {
            if (decimalExists != true)
            {
              InsertTextValue(".");
                 

                decimalExists = true;
            }
            //Focus on the user input text
            FocusInputText();
        }
        #endregion

        #region Calculate and Delete Button
        /// <summary>
        /// Used to calculate the BMI of the user using the information from the height, weight textboxes and the imperial/metric radiobutton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculateButton_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Button used to delete number
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                if (this.MyWeightTextBox.Text.Length >= this.MyWeightTextBox.SelectionStart + 1)
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
            /// keeps the cursor in the correct selected text box
            FocusInputText();
        }
        #endregion

        #region Input Text Boxes
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
           



            FocusInputText();
        }
        #endregion

        #region Reset button
        /// <summary>
        /// Clears users input and resets radio button to imperial 
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
            outputString = "0";
            decimalExists = false;
            MyHeightTextBox.Text = "0";
            MyWeightTextBox.Text = "0";
        }
        #endregion

        #region Private Helpers
       
        /// <summary>
        /// Keeps the cursor in the right textbox as values are inputted and another button is selected
        /// </summary>
        private void FocusInputText()
        {
            /// Check which text box has focus and keep focus on it
            if (_focusedControl != null)
            {
                _focusedControl.Focus();
            }
        }
        
        /// <summary>
        /// Inserts the value of the button in correct textbox
        /// </summary>
        /// <param name="value">Value to be inserted into the correct selected position</param>
        private void InsertTextValue(string value)
        {
            // Check which text box is active and inserts the value of the number
            if (_focusedControl == this.MyHeightTextBox)
            {
                if (MyHeightTextBox.Text.StartsWith("0"))
                {
                    var selectionStart = this.MyHeightTextBox.SelectionStart;
                    // inputs selected value
                    this.MyHeightTextBox.Text = value;
                    // keeps cursor at correct position
                    this.MyHeightTextBox.SelectionStart = selectionStart + value.Length;
                    outputString = " ";

                }
                else
                {
                    //Uses SelectionStart to remember position of cursor
                    var selectionStart = this.MyHeightTextBox.SelectionStart;
                    // inputs selected value
                    this.MyHeightTextBox.Text = this.MyHeightTextBox.Text.Insert(this.MyHeightTextBox.SelectionStart, value);
                    // keeps cursor at correct position
                    this.MyHeightTextBox.SelectionStart = selectionStart + value.Length;
                    outputString = " ";
                }
            } else if(_focusedControl == this.MyWeightTextBox){
                if (MyWeightTextBox.Text.StartsWith("0"))
                {
                
                    //Uses SelectionStart to remember position of cursor
                    var selectionStart = this.MyWeightTextBox.SelectionStart;
                    // inputs selected value
                    this.MyWeightTextBox.Text = value;                    
                    // keeps cursor at correct position
                    this.MyWeightTextBox.SelectionStart = selectionStart + value.Length;
                    outputString = " ";
                }
                else
                {
                    //Uses SelectionStart to remember position of cursor
                    var selectionStart = this.MyWeightTextBox.SelectionStart;
                    // inputs selected value
                    this.MyWeightTextBox.Text = this.MyWeightTextBox.Text.Insert(this.MyWeightTextBox.SelectionStart, value);
                    // keeps cursor at correct position
                    this.MyWeightTextBox.SelectionStart = selectionStart + value.Length;
                    outputString = " ";
                }
            }

            
        }

        private void CalculateBMIMetric()
        {
            //Assigns user input from the height box to this variable
            var userInput_Height = this.MyHeightTextBox.Text;
            //Assigns user input from the weight box to this variable
            var userInput_Weight = this.MyWeightTextBox.Text;

            float bmiTotal = 0;

            if (MetricToggleButton.Checked)
            {

               // bmiTotal = userInput_Weight / (userInput_Height * userInput_Height);
            }
        }

        #endregion
    }
}
