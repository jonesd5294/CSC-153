/**
 * 2/12/2023
 * CSC 153
 * David Jones
 * Color Mixer
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

namespace Color_Mixer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mixButton_Click(object sender, EventArgs e)
        {
            //Background color to red
            if (redRadButton1.Checked && redRadButton2.Checked)
            {
                this.BackColor = Color.Red;
            }
            //Background color to blue
            else if (blueRadButton1.Checked && blueRadButton2.Checked)
            {
                this.BackColor = Color.Blue;
            }
            //Background color to yellow
            else if (yelRadButton1.Checked && yelRadButton2.Checked)
            {
                this.BackColor = Color.Yellow;
            }
            //Background color to purple
            else if (redRadButton1.Checked && blueRadButton2.Checked)
            {
                this.BackColor = Color.Purple;
            }
            else if (blueRadButton1.Checked && redRadButton2.Checked)
            {
                this.BackColor = Color.Purple;
            }
            //Background color to orange
            else if (redRadButton1.Checked && yelRadButton2.Checked)
            {
                this.BackColor = Color.Orange;
            }
            else if (yelRadButton1.Checked && redRadButton2.Checked)
            {
                this.BackColor = Color.Orange;
            }
            //Background color to green
            else if (blueRadButton1.Checked && yelRadButton2.Checked)
            {
                this.BackColor = Color.Green;
            }
            else if (yelRadButton1.Checked && blueRadButton2.Checked)
            {
                this.BackColor = Color.Green;
            }
            //Error Message
            else
            {
                MessageBox.Show("Please select two primary colors");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
