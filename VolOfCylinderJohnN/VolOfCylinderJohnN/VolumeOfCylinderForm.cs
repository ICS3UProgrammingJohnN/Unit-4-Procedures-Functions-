/*
 * Created by: John Ngundeng
 * Created on: November 22, 2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #33 - Volume of a Cylinder
 * This program calculates the volume of a cylinder
 * by getting the height and radius from the user
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

namespace VolOfCylinderJohnN
{
    public partial class frmVolumeOfCylinder : Form
    {
        public frmVolumeOfCylinder()
        {
            InitializeComponent();
        }

        private double CalculateVolume(double height, double radius)
        {
            // creating variable
            double volume;

            // calculating the volume 
            volume = Math.PI * Math.Pow(radius, 2) * height;

            // returning the volume
            return volume;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // declaring variables
            double userHeight, userRadius, userVolume;

            // converting whats in the text box to double
            userHeight = double.Parse(txtHeight.Text);
            userRadius = double.Parse(txtRadius.Text);

            // calling the function
            userVolume = CalculateVolume(userHeight, userRadius);
            
            //Rounding the volume 
            userVolume = Math.Round(userVolume,2);

            //displaying the answer to the user
            this.lblVolume.Text = userVolume + " cm^3 ";
        }
    }
}
