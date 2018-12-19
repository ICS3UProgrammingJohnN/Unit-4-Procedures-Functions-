/*
 * Created by: John Ngudeng
 * Created on: December 14, 2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #35 - String Equality
 * This program campares two strings to see if they are the same
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

namespace StringEqualityJohnN
{
    public partial class frmStringEquality : Form
    {
        public frmStringEquality()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private bool StringsAreEqual (string string1, string string2)
        {
            // declaring variable
            bool isEqual;
            // Camparing the lengths of the strings
            if (string1.Length == string2.Length)
            {
                //changing the characters to lower cased letters to compare
                if (string1.ToLower() == string2.ToLower())
                {
                    isEqual = true;
                }
                else
                {
                    isEqual = false;
                }
            }
            else
            {
                isEqual = false;
            }
            // returning value
            return isEqual;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            // declare variables
            string userString1, userString2;
            bool userIsEqual = false;

            // assigning whats in the text box to the variables
            userString1 = txtString1.Text;
            userString2 = txtString2.Text;

            // calling the function
            userIsEqual = this.StringsAreEqual(userString1, userString2);

            // displaying is the strings are the same or different
            if (userIsEqual == true)
            {
                lblAnswer.Text = "The strings are the same.";
            }
            else if (userIsEqual == false)
            {
                lblAnswer.Text = "The Strings are different.";
            }

        }
    }
}
