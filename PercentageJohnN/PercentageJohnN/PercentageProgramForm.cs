/*
 * Created by: John
 * Created on: November 21, 2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #33 - Percentage Program
 * This program 
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

namespace PercentageJohnN
{
    public partial class frmPercentageProgram : Form
    {
        public frmPercentageProgram()
        {
            InitializeComponent();
        }

        private int ConvertToPercent (String level)
        {
            int percentage;

            switch (level)
            {
                case "4++":
                    percentage = 98;
                    break;
                case "4+":
                    percentage = 95;
                    break;
                case "4":
                    percentage = 87;
                    break;
                case "4-":
                    percentage = 83;
                    break;
                case "3+":
                    percentage = 78;
                    break;
                case "3":
                    percentage = 75;
                    break;
                case "3-":
                    percentage = 72;
                    break;
                case "2+":
                    percentage = 68;
                    break;
                case "2":
                    percentage = 65;
                    break;
                case "2-":
                    percentage = 62;
                    break;
                case "1+":
                    percentage = 58;
                    break;
                case "1":
                    percentage = 55;
                    break;
                case "1-":
                    percentage = 52;
                    break;
                case "0":
                    percentage = 40;
                    break;
                default:
                    percentage = -1;
                    break;
            }
            return percentage;

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            // declaring variables
            String level;
            int percentage;
            
            // getting the level from the user
            level = txtLevel.Text;

            // calling the percentage function
            percentage = this.ConvertToPercent(level);

            // displaying the percentage to the user
            MessageBox.Show("The percentage is " + percentage + "%");
        }
    }
}
