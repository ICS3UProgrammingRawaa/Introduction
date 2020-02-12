/*
 * Created by: Rawaa Al Ghanai
 * Created on: Feb 12, 2020
 * Created for: ICS3U Programming
 * Daily Assignment – Day #7 - PerAreaVol
 * This program displays 3 buttons and when the user clicks on the button the answer 
 * to the question comes up on the label. 
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

namespace PerAreaVolRawaa
{
    public partial class frmPerAreaVol : System.Windows.Forms.Form
    {
        public frmPerAreaVol()
        {
            InitializeComponent();
        }

        private void LblPerimeter_Click(object sender, EventArgs e)
        {

        }

        private void BtnPerimeter_Click(object sender, EventArgs e)
        {
            // calculate the perimeter of the rectangle
            this.lblPerimeter.Text = Convert.ToString (2 * 7 + 2 * 5) + "cm";
        }

        private void BtnArea_Click(object sender, EventArgs e)
        {
            // Calculate the Area of the circle
            this.lblArea.Text = Convert.ToString (Math.PI * Math.Pow(4, 2)) + "cm^2";

        }

        private void BtnVolume_Click(object sender, EventArgs e)
        {
            // Calculate the volume of a sphere
            this.lblVolume.Text = Convert.ToString((double)4 / (double)3 * Math.PI * Math.Pow(12, 3)) + "cm^3";

        }

        private void MniExit_Click(object sender, EventArgs e)
        {
            // close the program
            this.Close();
        }
    }
}
