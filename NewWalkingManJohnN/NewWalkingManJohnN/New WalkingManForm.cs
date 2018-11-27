using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewWalkingManJohnN
{
    public partial class frmNewWalkingMan : Form
    {
        public frmNewWalkingMan()
        {
            InitializeComponent();
            lblInstructions.Hide();
        }

        private void GeneratePictureBoxes()
        {
            // generate each of the picture boxes on the form
            GeneratePictureBox(12, 50);
            GeneratePictureBox(385, 50);
            GeneratePictureBox(385, 290);
            GeneratePictureBox(12, 290);

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // Reveal the instructions 
            this.lblInstructions.Show();

            // generate the picture boxes with their event listeners
            GeneratePictureBoxes();
        }

        private void GeneratePictureBox(int x, int y)
        {
            // dynamically generate a new picture box and a new point at the given location (x,y)
            PictureBox tmpPicMan = new PictureBox();
            Point pntPic = new System.Drawing.Point(x, y);

            // Set the location of the picture box
            tmpPicMan.Location = pntPic;

            // assign the image to the picture box
            tmpPicMan.Image = Properties.Resources.walk1;

            // stretch the image to the size of the picture box
            tmpPicMan.SizeMode = PictureBoxSizeMode.StretchImage;

            // make the picture box width and height to be the same as the image
            tmpPicMan.ClientSize = new Size(Properties.Resources.walk1.Width, Properties.Resources.walk1.Height);

            // add the event listener
            tmpPicMan.Click += new System.EventHandler(PictureBox_Click);

            // add the picture box to the form
            this.Controls.Add(tmpPicMan);
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            // cast the sender object into a picture box
            PictureBox tmpPicMan = (PictureBox)sender;


        }
    }   
        

}
