
namespace Property_Tax
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
            this.propAmountLabel = new System.Windows.Forms.Label();
            this.propAmountTextBox = new System.Windows.Forms.TextBox();
            this.propTaxLabel = new System.Windows.Forms.Label();
            this.propTaxTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // propAmountLabel
            // 
            this.propAmountLabel.AutoSize = true;
            this.propAmountLabel.Location = new System.Drawing.Point(66, 36);
            this.propAmountLabel.Name = "propAmountLabel";
            this.propAmountLabel.Size = new System.Drawing.Size(159, 13);
            this.propAmountLabel.TabIndex = 0;
            this.propAmountLabel.Text = "Enter the amount of the property";
            // 
            // propAmountTextBox
            // 
            this.propAmountTextBox.Location = new System.Drawing.Point(295, 36);
            this.propAmountTextBox.Name = "propAmountTextBox";
            this.propAmountTextBox.Size = new System.Drawing.Size(100, 20);
            this.propAmountTextBox.TabIndex = 1;
            // 
            // propTaxLabel
            // 
            this.propTaxLabel.AutoSize = true;
            this.propTaxLabel.Location = new System.Drawing.Point(69, 163);
            this.propTaxLabel.Name = "propTaxLabel";
            this.propTaxLabel.Size = new System.Drawing.Size(90, 13);
            this.propTaxLabel.TabIndex = 2;
            this.propTaxLabel.Text = "Your property tax ";
            // 
            // propTaxTextBox
            // 
            this.propTaxTextBox.Location = new System.Drawing.Point(295, 155);
            this.propTaxTextBox.Name = "propTaxTextBox";
            this.propTaxTextBox.Size = new System.Drawing.Size(100, 20);
            this.propTaxTextBox.TabIndex = 3;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(126, 296);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 4;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(432, 295);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(285, 295);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.propTaxTextBox);
            this.Controls.Add(this.propTaxLabel);
            this.Controls.Add(this.propAmountTextBox);
            this.Controls.Add(this.propAmountLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label propAmountLabel;
        private System.Windows.Forms.TextBox propAmountTextBox;
        private System.Windows.Forms.Label propTaxLabel;
        private System.Windows.Forms.TextBox propTaxTextBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button clearButton;
    }
}

