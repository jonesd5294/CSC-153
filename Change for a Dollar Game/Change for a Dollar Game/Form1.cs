/**
 * 2/19/2023
 * CSC 153
 * David Jones
 * This program calculates if the user input is equal to, greater than, or less than a dollar
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

namespace Change_for_a_Dollar_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Declare variables
        const decimal PENNY = 0.01m;
        const decimal NICKEL = 0.05m;
        const decimal DIME = 0.10m;
        const decimal QUARTER = 0.25m;
        const decimal DOLLAR = 1.00m;
        int pennies;
        int nickels;
        int dimes;
        int quarters;
        decimal usrPen;
        decimal usrNic;
        decimal usrDim;
        decimal usrQua;
        decimal total;

        private void caluculateButton_Click(object sender, EventArgs e)
        {
            //Call user input and convert variables
            pennies = int.Parse(penniesTextBox.Text);
            nickels = int.Parse(nickelsTextBox.Text);
            dimes = int.Parse(dimesTextBox.Text);
            quarters = int.Parse(quartersTextBox.Text);

            //Calculate variables
            usrPen = pennies * PENNY;
            usrNic = nickels * NICKEL;
            usrDim = dimes * DIME;
            usrQua = quarters * QUARTER;

            //Calculate total
            total = usrPen + usrNic + usrDim + usrQua;

            //If else if else statement to Display total
            if (total == DOLLAR)
            {
                MessageBox.Show("Congratulations you won!");
            }
            else if (total > DOLLAR)
            {
                MessageBox.Show("The amount you entered is more than a dollar.");
            }
            else
            {
                MessageBox.Show("The amount you entered is less than a dollar.");
            }
       



        }

        //Exit program
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Clear text
        private void clearButton_Click(object sender, EventArgs e)
        {
            penniesTextBox.Clear();
            nickelsTextBox.Clear();
            dimesTextBox.Clear();
            quartersTextBox.Clear();


        }
    }
}
