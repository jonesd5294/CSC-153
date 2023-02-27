/**
 * 1/26/2023
 * CSC 153
 * David Jones
 * Paint Job Estimator
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

namespace Paint_Job_Estimator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Declare variables
        int sqftUnits;
        int sqft;
        int laborHr;
        decimal paintPr;
        decimal paintCost;
        decimal laborPr;
        decimal total;
        

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close this form
            this.Close();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            //Call user input and convert into new variable
            sqft = int.Parse(sqftTextBox.Text);
            paintPr = decimal.Parse(perGalTextBox.Text);
            
            //Calculations
            sqftUnits = sqft / 115;
            laborHr = sqftUnits * 8;            
            paintCost = paintPr * sqftUnits;
            laborPr = laborHr * 20;
            total = laborPr + paintCost;



            //Dispaly gallons required
            galReqTextBox.Text = sqftUnits.ToString();

            //Display hours of labor
            laborHrsTextBox.Text = laborHr.ToString();

            //Dispaly cost of paint
            paintPrTextBox.Text = paintCost.ToString("c");

            //Dispaly cost of labor
            laborPrTextBox.Text = laborPr.ToString("c");

            //Display total cost of paint job
            totalTextBox.Text = total.ToString("c");


           

            

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            //Clear text
            sqftTextBox.Clear();
            perGalTextBox.Clear();
            galReqTextBox.Clear();
            laborHrsTextBox.Clear();
            paintPrTextBox.Clear();
            laborPrTextBox.Clear();
            totalTextBox.Clear();

        }
    }
}
