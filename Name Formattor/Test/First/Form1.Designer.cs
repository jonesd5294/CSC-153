
namespace First
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.middleNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.format1Button = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dispalyNameTextBox = new System.Windows.Forms.TextBox();
            this.formatButton2 = new System.Windows.Forms.Button();
            this.formatButton3 = new System.Windows.Forms.Button();
            this.formatButton4 = new System.Windows.Forms.Button();
            this.formatButton5 = new System.Windows.Forms.Button();
            this.formatButton6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(126, 28);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.firstNameTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter First Name";
            // 
            // middleNameTextBox
            // 
            this.middleNameTextBox.Location = new System.Drawing.Point(126, 81);
            this.middleNameTextBox.Name = "middleNameTextBox";
            this.middleNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.middleNameTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter Middle Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Enter Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Enter Preferred Title";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(126, 125);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.lastNameTextBox.TabIndex = 6;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(126, 172);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(100, 20);
            this.titleTextBox.TabIndex = 7;
            // 
            // format1Button
            // 
            this.format1Button.Location = new System.Drawing.Point(15, 306);
            this.format1Button.Name = "format1Button";
            this.format1Button.Size = new System.Drawing.Size(75, 23);
            this.format1Button.TabIndex = 8;
            this.format1Button.Text = "Format1";
            this.format1Button.UseVisualStyleBackColor = true;
            this.format1Button.Click += new System.EventHandler(this.format1Button_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(351, 415);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Your Formatted Name";
            // 
            // dispalyNameTextBox
            // 
            this.dispalyNameTextBox.Location = new System.Drawing.Point(139, 241);
            this.dispalyNameTextBox.Name = "dispalyNameTextBox";
            this.dispalyNameTextBox.Size = new System.Drawing.Size(185, 20);
            this.dispalyNameTextBox.TabIndex = 11;
            // 
            // formatButton2
            // 
            this.formatButton2.Location = new System.Drawing.Point(114, 306);
            this.formatButton2.Name = "formatButton2";
            this.formatButton2.Size = new System.Drawing.Size(75, 23);
            this.formatButton2.TabIndex = 12;
            this.formatButton2.Text = "Format 2";
            this.formatButton2.UseVisualStyleBackColor = true;
            this.formatButton2.Click += new System.EventHandler(this.formatButton2_Click);
            // 
            // formatButton3
            // 
            this.formatButton3.Location = new System.Drawing.Point(224, 306);
            this.formatButton3.Name = "formatButton3";
            this.formatButton3.Size = new System.Drawing.Size(75, 23);
            this.formatButton3.TabIndex = 13;
            this.formatButton3.Text = "Format 3";
            this.formatButton3.UseVisualStyleBackColor = true;
            this.formatButton3.Click += new System.EventHandler(this.formatButton3_Click);
            // 
            // formatButton4
            // 
            this.formatButton4.Location = new System.Drawing.Point(333, 306);
            this.formatButton4.Name = "formatButton4";
            this.formatButton4.Size = new System.Drawing.Size(75, 23);
            this.formatButton4.TabIndex = 14;
            this.formatButton4.Text = "Format 4";
            this.formatButton4.UseVisualStyleBackColor = true;
            this.formatButton4.Click += new System.EventHandler(this.formatButton4_Click);
            // 
            // formatButton5
            // 
            this.formatButton5.Location = new System.Drawing.Point(448, 306);
            this.formatButton5.Name = "formatButton5";
            this.formatButton5.Size = new System.Drawing.Size(75, 23);
            this.formatButton5.TabIndex = 15;
            this.formatButton5.Text = "Format 5";
            this.formatButton5.UseVisualStyleBackColor = true;
            this.formatButton5.Click += new System.EventHandler(this.formatButton5_Click);
            // 
            // formatButton6
            // 
            this.formatButton6.Location = new System.Drawing.Point(572, 306);
            this.formatButton6.Name = "formatButton6";
            this.formatButton6.Size = new System.Drawing.Size(75, 23);
            this.formatButton6.TabIndex = 16;
            this.formatButton6.Text = "Format 6";
            this.formatButton6.UseVisualStyleBackColor = true;
            this.formatButton6.Click += new System.EventHandler(this.formatButton6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.formatButton6);
            this.Controls.Add(this.formatButton5);
            this.Controls.Add(this.formatButton4);
            this.Controls.Add(this.formatButton3);
            this.Controls.Add(this.formatButton2);
            this.Controls.Add(this.dispalyNameTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.format1Button);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.middleNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.firstNameTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox middleNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Button format1Button;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox dispalyNameTextBox;
        private System.Windows.Forms.Button formatButton2;
        private System.Windows.Forms.Button formatButton3;
        private System.Windows.Forms.Button formatButton4;
        private System.Windows.Forms.Button formatButton5;
        private System.Windows.Forms.Button formatButton6;
    }
}

