/**
 * 2/22/2023
 * CSC 153
 * David Jones
 * This program will calculate the number of seconds from user and display hours, mins, and seconds.
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

namespace WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Declare variables
        int numDays = 0;
        int numHours = 0;
        int numMins = 0;
        int usrSec = 0;
        
        private void calculateButton_Click(object sender, EventArgs e)
        {
            //Call user variable
            usrSec = int.Parse(usrinputTextBox.Text);

            //If statements and calculations
            if (usrSec >= 86400)
            {
                numDays = usrSec / 86400;
                usrSec -= numDays * 86400;
            }
            if (usrSec >= 3600)
            {
                numHours = usrSec / 3600;
                usrSec -= numHours * 3600;
            }
            if (usrSec >= 60)
            {
                numMins = usrSec / 60;
                usrSec -= numMins * 60;
            }
           

            //Dispaly Days, Hours, Mins, Secs
            numDaysLabel.Text = numDays.ToString();
            numHoursLabel.Text = numHours.ToString();
            numMinsLabel.Text = numMins.ToString();
            numSecsLabel.Text = usrSec.ToString();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            usrinputTextBox.Clear();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
