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
            // 
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            // declare variables
            string userString1, userString2;

            // 
            userString1 = txtString1.Text;
            userString2 = txtString2.Text;


            this.StringsAreEqual(userString1, userString2);

        }
    }
}
