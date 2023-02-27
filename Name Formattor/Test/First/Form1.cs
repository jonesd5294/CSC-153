/**
 * 1/18/2023
 * CSC 153
 * David Jones
 * Name Formattor
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

namespace First
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close program
            this.Close();
        }

        private void format1Button_Click(object sender, EventArgs e)
        {
            dispalyNameTextBox.Clear();
            dispalyNameTextBox.Text = titleTextBox.Text + ". " + firstNameTextBox.Text + " " + middleNameTextBox.Text + " " + lastNameTextBox.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void formatButton2_Click(object sender, EventArgs e)
        {
            dispalyNameTextBox.Clear();
            dispalyNameTextBox.Text = firstNameTextBox.Text + " " + middleNameTextBox.Text + " " + lastNameTextBox.Text;

        }

        private void formatButton3_Click(object sender, EventArgs e)
        {
            dispalyNameTextBox.Clear();
            dispalyNameTextBox.Text = firstNameTextBox.Text + " " + lastNameTextBox.Text;
        }

        private void formatButton4_Click(object sender, EventArgs e)
        {
            dispalyNameTextBox.Clear();
            dispalyNameTextBox.Text = lastNameTextBox.Text + ", " + firstNameTextBox.Text + " " + middleNameTextBox.Text + ", " + titleTextBox.Text + ".";
        }

        private void formatButton5_Click(object sender, EventArgs e)
        {
            dispalyNameTextBox.Clear();
            dispalyNameTextBox.Text = lastNameTextBox.Text + ", " + firstNameTextBox.Text + " " + middleNameTextBox.Text;
        }

        private void formatButton6_Click(object sender, EventArgs e)
        {
            dispalyNameTextBox.Clear();
            dispalyNameTextBox.Text = lastNameTextBox.Text + " " + firstNameTextBox.Text;
        }
    }
}
