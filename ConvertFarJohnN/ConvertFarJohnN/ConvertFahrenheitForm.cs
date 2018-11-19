/*
 * Created by: John Ngundeng
 * Created on: November 15, 2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #28 - temp converter
 * This program converts the temperature from celsius to fahrenheit.
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

namespace ConvertFarJohnN
{
    public partial class frmConvertFahrenheit : Form
    {
        public frmConvertFahrenheit()
        {
            InitializeComponent();
        }

        public void ConvertToFahrenheit(double celsius)
        {
            // declare local variables 
            double fahrenheit;

            // caculate the fahrenheit
            fahrenheit = (double)9 /(double) 5 * celsius + 32;

            // converting fahrenheit to int
            fahrenheit = Convert.ToInt32(fahrenheit);

            // display a message box with converted temperature
            MessageBox.Show("The temperature is " + fahrenheit + " degrees fahrenheit" );
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            // declare local variables 
            double userCelsius;

            // convert users input 
            userCelsius = double.Parse(this.txtCelsius.Text);

            // call the convert function
            this.ConvertToFahrenheit(userCelsius);
        }
    }
}
