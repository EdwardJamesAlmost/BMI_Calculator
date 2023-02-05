using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_Calculator
{
    public partial class BMICalculatorForm : Form
    {
        public BMICalculatorForm()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void calculateBMIButtion_Click(object sender, EventArgs e)
        {
            interpretedBMILabel.Text = " ";
            double enteredWeight = Convert.ToDouble(enteredWeightTextBox.Text);
            double enteredHeight = Convert.ToDouble(enteredHeightTextBox.Text);

            double calculatedBMI = (enteredWeight * 703) / (enteredHeight * enteredHeight);

            String outputBMIValue = calculatedBMI.ToString("F2");
            
            String outputMsg = "Your BMI is " + outputBMIValue;
            calculatedBMILabel.Text = outputMsg;
            //calculatedBMILabel.Text = String.Format("BMI is {0,12:C2}",outputString1);

            interpretBMIButton.Enabled = true;
        }

        private double calculateBMI(double height, double weight)
        {
            return (weight * 703) / (Math.Pow(Convert.ToDouble(height),2));
        }
        private void interpretBMIButton_Click(object sender, EventArgs e)
        {
            interpretBMIButton.Enabled = false;

            double enteredWeight = Convert.ToDouble(enteredWeightTextBox.Text);
            double enteredHeight = Convert.ToDouble(enteredHeightTextBox.Text);

            double calculatedBMI = calculateBMI(enteredHeight,enteredWeight);

            switch (calculatedBMI)
            {
                default:
                    break;
                case var n when n <= 18.5:
                    interpretedBMILabel.Text = "underweight";
                    break;
                case var n when (n > 18.5 && n <= 25):
                    interpretedBMILabel.Text = "normal";
                    break;
                case var n when (n > 25 && n <= 29.9):
                    interpretedBMILabel.Text = "overweight";
                    break;
                case var n when n >= 30.0:
                    interpretedBMILabel.Text = "obese";
                    break;

            }

        }
    }
}
