/*
 * Created by: Rawaa Al Ghanai
 * Created on: Feb. 11, 2020
 * Created for: ICS3U Programming
 * Daily Assignment – Day #6 - Name of Program
 * This program displays 4 radio buttons and when the user clicks on each radio button
 * the greeting changes according to the language of the radio button.
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

namespace HelloIntRawaa
{
    public partial class frmHelloInt : Form
    {
        public frmHelloInt()
        {
            InitializeComponent();
        }

        private void RadArabic_CheckedChanged(object sender, EventArgs e)
        {
            // change the greeting to Arabic
            this.lblGreeting.Text = "!مرحبا بالعالم";
        }

        private void RadEnglish_CheckedChanged(object sender, EventArgs e)
        {
            // change the greeting to English
            this.lblGreeting.Text = "Hello, World!";
      
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            // change the greeting to Spanish
            this.lblGreeting.Text = "¡Hola Mundo!";
        }

        private void RadFrançais_CheckedChanged(object sender, EventArgs e)
        {
            // change the greeting to French
            this.lblGreeting.Text = "Bonjour le monde!";
           
        }
    }
}
