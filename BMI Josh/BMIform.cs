﻿using System;
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
        #region Constructor

        /// <summary>
        /// Default Constructor
        /// </summary>

        public BMIform()
        {
            InitializeComponent();
        }
        #endregion
        
        #region Calculate Button
        private void SevenButton_Click(object sender, EventArgs e)
        {

        }

        private void EightButton_Click(object sender, EventArgs e)
        {

        }

        private void NineButton_Click(object sender, EventArgs e)
        {

        }

        private void FourButton_Click(object sender, EventArgs e)
        {

        }

        private void FiveButton_Click(object sender, EventArgs e)
        {

        }

        private void SixButton_Click(object sender, EventArgs e)
        {

        }

        private void OneButton_Click(object sender, EventArgs e)
        {

        }

        private void TwoButton_Click(object sender, EventArgs e)
        {

        }

        private void ThreeButton_Click(object sender, EventArgs e)
        {

        }

        private void ZeroButton_Click(object sender, EventArgs e)
        {

        }

        private void PeriodButton_Click(object sender, EventArgs e)
        {

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

        private void MyWeightTextBox_TextChanged(object sender, EventArgs e)
        {

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

        private void ResetButton_Click(object sender, EventArgs e)
        {
            this.MyWeightTextBox.Text = string.Empty;
            this.MyHeightTextBox.Text = string.Empty;
            this.ImperialRadioButton.Checked = false;
            this.MetricToggleButton.Checked = false;

        }
    }
}
