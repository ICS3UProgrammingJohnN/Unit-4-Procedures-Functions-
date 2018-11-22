/*
 * Created by: John Ngundeng
 * Created on: November 8 2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #32 - Address Program
 * This program tell the user their address
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

namespace OptionalParJohnN
{
    public partial class frmOptionalParameters : Form
    {
        public frmOptionalParameters()
        {
            InitializeComponent();
        }
        public void GetAddress(String address, String province, String city, String postalcode)
        {
            // Displaying the address to the user without the unit
            MessageBox.Show("Your address is " + address + " " + province + " " + city + " " + postalcode);

            // Clearing the text boxes
            txtAddress.Text = "";
            txtProvince.Text = "";
            txtCity.Text = "";
            txtPostalCode.Text = "";
        }

        public void GetAddress(String address, String province, String city, String postalcode, String unit)
        {
            // Displaying the address to the user
            MessageBox.Show("Your address is " + address + " unit " + unit+ " " + province + " " + city + " " + postalcode);

            // Clearing the text boxes
            txtAddress.Text = "";
            txtUnit.Text = "";
            txtProvince.Text = "";
            txtCity.Text = "";
            txtPostalCode.Text = "";
        }

        private void lblCity_Click(object sender, EventArgs e)
        {

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            // declare variables
            String address, province, postalCode, city, unit;

            // get users information from the text boxes
            address = this.txtAddress.Text;
            province = this.txtProvince.Text;
            postalCode = this.txtPostalCode.Text;
            city = this.txtCity.Text;
            unit = this.txtUnit.Text;

            // make sure the user inputs information in boxes
            if (address == "")
            {
                // displaying message if left blank
                MessageBox.Show("Please enter your address");
            }
            else if (province == "")
            {

                // displaying message if left blank
                MessageBox.Show("Please enter your Province");
            }
            else if (postalCode == "")
            {
                // displaying message if left blank
                MessageBox.Show("Please enter your postal code");
            }
            else if (city == "")
            {
                // displaying message if left blank
                MessageBox.Show("Please enter your City");

            }
            else if (unit == "")
            {
                // calling function if left blank
                this.GetAddress(province, address, postalCode, city);
            }
            else
            {
                // Calling the function
                this.GetAddress(province, address, postalCode, city, unit);
            }

        }
    }
}