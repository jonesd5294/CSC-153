/**
 * 2/1/2023
 * CSC 153
 * David Jones
 * Property tax
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

namespace Property_Tax
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Declare Variables
        const decimal STATE_PRICE = .64m;
        const int COST = 100;
        int propAmount;
        decimal tax;


        private void calculateButton_Click(object sender, EventArgs e)
        {
            //Call variables
            propAmount = int.Parse(propAmountTextBox.Text);

            //Calculations
            tax = propAmount / (COST * STATE_PRICE);

            //Ouput the amount of property tax
            propTaxTextBox.Text = tax.ToString("c");
            


            
            
             

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close Program
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //Clear text
            propAmountTextBox.Clear();
            propTaxTextBox.Clear();
        }
    }
}
