/*
 * Created by: John Ngundeng
 * Created on: November 19, 2018 
 * Created for: ICS3U Programming
 * Daily Assignment – Day #31 - Rounding Program
 * This program rounds a number to how many decimal places the user picks
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassByRefJohnN
{
    public partial class frmPassByRef : Form
    {
        public frmPassByRef()
        {
            InitializeComponent();
        }

        public void RoundDecimal(ref double decimalNumber, double decimalPlaces)
        {
            // Creating the formula to round a number
            decimalNumber = decimalNumber * Math.Pow(10, decimalPlaces) + 0.5;
            decimalNumber = Math.Truncate(decimalNumber);
            decimalNumber = decimalNumber / Math.Pow(10, decimalPlaces);

            // displaying the rounded number in a message box
            MessageBox.Show("The rounded number is " + decimalNumber);


        }

        private void btnRound_Click(object sender, EventArgs e)
        {
            // declare variables 
            double decimalNumber, decimalPlaces;

            // getting string and converting to double 
            decimalNumber = double.Parse(txtDecimalNumber.Text);
            decimalPlaces = double.Parse(numDecimalPlaces.Text);

            // calling the function
            this.RoundDecimal(ref decimalNumber, decimalPlaces);
        }
    }
}
