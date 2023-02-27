
namespace WindowsForms
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
            this.secondsLabel = new System.Windows.Forms.Label();
            this.usrinputTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.numDaysLabel = new System.Windows.Forms.Label();
            this.numHoursLabel = new System.Windows.Forms.Label();
            this.numMinsLabel = new System.Windows.Forms.Label();
            this.daysLabel = new System.Windows.Forms.Label();
            this.hoursLabel = new System.Windows.Forms.Label();
            this.minsLabel = new System.Windows.Forms.Label();
            this.secsLabel = new System.Windows.Forms.Label();
            this.numSecsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // secondsLabel
            // 
            this.secondsLabel.AutoSize = true;
            this.secondsLabel.Location = new System.Drawing.Point(46, 51);
            this.secondsLabel.Name = "secondsLabel";
            this.secondsLabel.Size = new System.Drawing.Size(125, 13);
            this.secondsLabel.TabIndex = 0;
            this.secondsLabel.Text = "Enter number of seconds";
            // 
            // usrinputTextBox
            // 
            this.usrinputTextBox.Location = new System.Drawing.Point(190, 48);
            this.usrinputTextBox.Name = "usrinputTextBox";
            this.usrinputTextBox.Size = new System.Drawing.Size(100, 20);
            this.usrinputTextBox.TabIndex = 1;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(107, 279);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 2;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(372, 279);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(234, 279);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // numDaysLabel
            // 
            this.numDaysLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.numDaysLabel.Location = new System.Drawing.Point(82, 148);
            this.numDaysLabel.Name = "numDaysLabel";
            this.numDaysLabel.Size = new System.Drawing.Size(89, 21);
            this.numDaysLabel.TabIndex = 5;
            // 
            // numHoursLabel
            // 
            this.numHoursLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.numHoursLabel.Location = new System.Drawing.Point(216, 148);
            this.numHoursLabel.Name = "numHoursLabel";
            this.numHoursLabel.Size = new System.Drawing.Size(100, 23);
            this.numHoursLabel.TabIndex = 6;
            // 
            // numMinsLabel
            // 
            this.numMinsLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.numMinsLabel.Location = new System.Drawing.Point(372, 148);
            this.numMinsLabel.Name = "numMinsLabel";
            this.numMinsLabel.Size = new System.Drawing.Size(100, 23);
            this.numMinsLabel.TabIndex = 7;
            // 
            // daysLabel
            // 
            this.daysLabel.AutoSize = true;
            this.daysLabel.Location = new System.Drawing.Point(82, 103);
            this.daysLabel.Name = "daysLabel";
            this.daysLabel.Size = new System.Drawing.Size(31, 13);
            this.daysLabel.TabIndex = 8;
            this.daysLabel.Text = "Days";
            // 
            // hoursLabel
            // 
            this.hoursLabel.AutoSize = true;
            this.hoursLabel.Location = new System.Drawing.Point(216, 102);
            this.hoursLabel.Name = "hoursLabel";
            this.hoursLabel.Size = new System.Drawing.Size(35, 13);
            this.hoursLabel.TabIndex = 9;
            this.hoursLabel.Text = "Hours";
            // 
            // minsLabel
            // 
            this.minsLabel.AutoSize = true;
            this.minsLabel.Location = new System.Drawing.Point(369, 103);
            this.minsLabel.Name = "minsLabel";
            this.minsLabel.Size = new System.Drawing.Size(44, 13);
            this.minsLabel.TabIndex = 10;
            this.minsLabel.Text = "Minutes";
            // 
            // secsLabel
            // 
            this.secsLabel.AutoSize = true;
            this.secsLabel.Location = new System.Drawing.Point(525, 103);
            this.secsLabel.Name = "secsLabel";
            this.secsLabel.Size = new System.Drawing.Size(49, 13);
            this.secsLabel.TabIndex = 12;
            this.secsLabel.Text = "Seconds";
            // 
            // numSecsLabel
            // 
            this.numSecsLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.numSecsLabel.Location = new System.Drawing.Point(528, 148);
            this.numSecsLabel.Name = "numSecsLabel";
            this.numSecsLabel.Size = new System.Drawing.Size(100, 23);
            this.numSecsLabel.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.secsLabel);
            this.Controls.Add(this.numSecsLabel);
            this.Controls.Add(this.minsLabel);
            this.Controls.Add(this.hoursLabel);
            this.Controls.Add(this.daysLabel);
            this.Controls.Add(this.numMinsLabel);
            this.Controls.Add(this.numHoursLabel);
            this.Controls.Add(this.numDaysLabel);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.usrinputTextBox);
            this.Controls.Add(this.secondsLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label secondsLabel;
        private System.Windows.Forms.TextBox usrinputTextBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label numDaysLabel;
        private System.Windows.Forms.Label numHoursLabel;
        private System.Windows.Forms.Label numMinsLabel;
        private System.Windows.Forms.Label daysLabel;
        private System.Windows.Forms.Label hoursLabel;
        private System.Windows.Forms.Label minsLabel;
        private System.Windows.Forms.Label secsLabel;
        private System.Windows.Forms.Label numSecsLabel;
    }
}

