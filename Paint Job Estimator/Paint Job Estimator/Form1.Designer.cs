
namespace Paint_Job_Estimator
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
            this.sqftLabel = new System.Windows.Forms.Label();
            this.sqftTextBox = new System.Windows.Forms.TextBox();
            this.perGalLabel = new System.Windows.Forms.Label();
            this.perGalTextBox = new System.Windows.Forms.TextBox();
            this.galReqLabel = new System.Windows.Forms.Label();
            this.galReqTextBox = new System.Windows.Forms.TextBox();
            this.laborHrsLabel = new System.Windows.Forms.Label();
            this.laborHrsTextBox = new System.Windows.Forms.TextBox();
            this.paintPrLabel = new System.Windows.Forms.Label();
            this.paintPrTextBox = new System.Windows.Forms.TextBox();
            this.laborPrLabel = new System.Windows.Forms.Label();
            this.laborPrTextBox = new System.Windows.Forms.TextBox();
            this.totalLabel = new System.Windows.Forms.Label();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sqftLabel
            // 
            this.sqftLabel.AutoSize = true;
            this.sqftLabel.Location = new System.Drawing.Point(23, 25);
            this.sqftLabel.Name = "sqftLabel";
            this.sqftLabel.Size = new System.Drawing.Size(88, 13);
            this.sqftLabel.TabIndex = 0;
            this.sqftLabel.Text = "Enter square feet";
            // 
            // sqftTextBox
            // 
            this.sqftTextBox.Location = new System.Drawing.Point(172, 18);
            this.sqftTextBox.Name = "sqftTextBox";
            this.sqftTextBox.Size = new System.Drawing.Size(100, 20);
            this.sqftTextBox.TabIndex = 1;
            // 
            // perGalLabel
            // 
            this.perGalLabel.AutoSize = true;
            this.perGalLabel.Location = new System.Drawing.Point(23, 62);
            this.perGalLabel.Name = "perGalLabel";
            this.perGalLabel.Size = new System.Drawing.Size(104, 13);
            this.perGalLabel.TabIndex = 2;
            this.perGalLabel.Text = "Enter cost per gallon";
            // 
            // perGalTextBox
            // 
            this.perGalTextBox.Location = new System.Drawing.Point(172, 54);
            this.perGalTextBox.Name = "perGalTextBox";
            this.perGalTextBox.Size = new System.Drawing.Size(100, 20);
            this.perGalTextBox.TabIndex = 3;
            // 
            // galReqLabel
            // 
            this.galReqLabel.AutoSize = true;
            this.galReqLabel.Location = new System.Drawing.Point(182, 126);
            this.galReqLabel.Name = "galReqLabel";
            this.galReqLabel.Size = new System.Drawing.Size(171, 13);
            this.galReqLabel.TabIndex = 4;
            this.galReqLabel.Text = "Number of gallons of paint required";
            // 
            // galReqTextBox
            // 
            this.galReqTextBox.Location = new System.Drawing.Point(420, 119);
            this.galReqTextBox.Name = "galReqTextBox";
            this.galReqTextBox.Size = new System.Drawing.Size(100, 20);
            this.galReqTextBox.TabIndex = 5;
            // 
            // laborHrsLabel
            // 
            this.laborHrsLabel.AutoSize = true;
            this.laborHrsLabel.Location = new System.Drawing.Point(182, 171);
            this.laborHrsLabel.Name = "laborHrsLabel";
            this.laborHrsLabel.Size = new System.Drawing.Size(114, 13);
            this.laborHrsLabel.TabIndex = 6;
            this.laborHrsLabel.Text = "Hours of labor required";
            // 
            // laborHrsTextBox
            // 
            this.laborHrsTextBox.Location = new System.Drawing.Point(420, 171);
            this.laborHrsTextBox.Name = "laborHrsTextBox";
            this.laborHrsTextBox.Size = new System.Drawing.Size(100, 20);
            this.laborHrsTextBox.TabIndex = 7;
            // 
            // paintPrLabel
            // 
            this.paintPrLabel.AutoSize = true;
            this.paintPrLabel.Location = new System.Drawing.Point(182, 223);
            this.paintPrLabel.Name = "paintPrLabel";
            this.paintPrLabel.Size = new System.Drawing.Size(84, 13);
            this.paintPrLabel.TabIndex = 8;
            this.paintPrLabel.Text = "Cost of the paint";
            // 
            // paintPrTextBox
            // 
            this.paintPrTextBox.Location = new System.Drawing.Point(420, 223);
            this.paintPrTextBox.Name = "paintPrTextBox";
            this.paintPrTextBox.Size = new System.Drawing.Size(100, 20);
            this.paintPrTextBox.TabIndex = 9;
            // 
            // laborPrLabel
            // 
            this.laborPrLabel.AutoSize = true;
            this.laborPrLabel.Location = new System.Drawing.Point(182, 276);
            this.laborPrLabel.Name = "laborPrLabel";
            this.laborPrLabel.Size = new System.Drawing.Size(66, 13);
            this.laborPrLabel.TabIndex = 10;
            this.laborPrLabel.Text = "Cost of labor";
            // 
            // laborPrTextBox
            // 
            this.laborPrTextBox.Location = new System.Drawing.Point(420, 276);
            this.laborPrTextBox.Name = "laborPrTextBox";
            this.laborPrTextBox.Size = new System.Drawing.Size(100, 20);
            this.laborPrTextBox.TabIndex = 11;
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(182, 331);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(109, 13);
            this.totalLabel.TabIndex = 12;
            this.totalLabel.Text = "Total cost of paint job";
            // 
            // totalTextBox
            // 
            this.totalTextBox.Location = new System.Drawing.Point(420, 331);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(100, 20);
            this.totalTextBox.TabIndex = 13;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(127, 394);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 14;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(537, 394);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 15;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(350, 393);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 16;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.totalTextBox);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.laborPrTextBox);
            this.Controls.Add(this.laborPrLabel);
            this.Controls.Add(this.paintPrTextBox);
            this.Controls.Add(this.paintPrLabel);
            this.Controls.Add(this.laborHrsTextBox);
            this.Controls.Add(this.laborHrsLabel);
            this.Controls.Add(this.galReqTextBox);
            this.Controls.Add(this.galReqLabel);
            this.Controls.Add(this.perGalTextBox);
            this.Controls.Add(this.perGalLabel);
            this.Controls.Add(this.sqftTextBox);
            this.Controls.Add(this.sqftLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sqftLabel;
        private System.Windows.Forms.TextBox sqftTextBox;
        private System.Windows.Forms.Label perGalLabel;
        private System.Windows.Forms.TextBox perGalTextBox;
        private System.Windows.Forms.Label galReqLabel;
        private System.Windows.Forms.TextBox galReqTextBox;
        private System.Windows.Forms.Label laborHrsLabel;
        private System.Windows.Forms.TextBox laborHrsTextBox;
        private System.Windows.Forms.Label paintPrLabel;
        private System.Windows.Forms.TextBox paintPrTextBox;
        private System.Windows.Forms.Label laborPrLabel;
        private System.Windows.Forms.TextBox laborPrTextBox;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button ClearButton;
    }
}

