
namespace Change_for_a_Dollar_Game
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
            this.satementLabel = new System.Windows.Forms.Label();
            this.penniesLabel = new System.Windows.Forms.Label();
            this.nickelsLabel = new System.Windows.Forms.Label();
            this.dimesLabel = new System.Windows.Forms.Label();
            this.quartersLabel = new System.Windows.Forms.Label();
            this.penniesTextBox = new System.Windows.Forms.TextBox();
            this.nickelsTextBox = new System.Windows.Forms.TextBox();
            this.dimesTextBox = new System.Windows.Forms.TextBox();
            this.quartersTextBox = new System.Windows.Forms.TextBox();
            this.caluculateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // satementLabel
            // 
            this.satementLabel.AutoSize = true;
            this.satementLabel.Location = new System.Drawing.Point(57, 45);
            this.satementLabel.Name = "satementLabel";
            this.satementLabel.Size = new System.Drawing.Size(229, 13);
            this.satementLabel.TabIndex = 0;
            this.satementLabel.Text = "Enter amount of coins required to make a dollar";
            // 
            // penniesLabel
            // 
            this.penniesLabel.AutoSize = true;
            this.penniesLabel.Location = new System.Drawing.Point(60, 104);
            this.penniesLabel.Name = "penniesLabel";
            this.penniesLabel.Size = new System.Drawing.Size(45, 13);
            this.penniesLabel.TabIndex = 1;
            this.penniesLabel.Text = "Pennies";
            // 
            // nickelsLabel
            // 
            this.nickelsLabel.AutoSize = true;
            this.nickelsLabel.Location = new System.Drawing.Point(60, 152);
            this.nickelsLabel.Name = "nickelsLabel";
            this.nickelsLabel.Size = new System.Drawing.Size(42, 13);
            this.nickelsLabel.TabIndex = 2;
            this.nickelsLabel.Text = "Nickles";
            // 
            // dimesLabel
            // 
            this.dimesLabel.AutoSize = true;
            this.dimesLabel.Location = new System.Drawing.Point(60, 201);
            this.dimesLabel.Name = "dimesLabel";
            this.dimesLabel.Size = new System.Drawing.Size(36, 13);
            this.dimesLabel.TabIndex = 3;
            this.dimesLabel.Text = "Dimes";
            // 
            // quartersLabel
            // 
            this.quartersLabel.AutoSize = true;
            this.quartersLabel.Location = new System.Drawing.Point(60, 251);
            this.quartersLabel.Name = "quartersLabel";
            this.quartersLabel.Size = new System.Drawing.Size(47, 13);
            this.quartersLabel.TabIndex = 4;
            this.quartersLabel.Text = "Quarters";
            // 
            // penniesTextBox
            // 
            this.penniesTextBox.Location = new System.Drawing.Point(175, 96);
            this.penniesTextBox.Name = "penniesTextBox";
            this.penniesTextBox.Size = new System.Drawing.Size(100, 20);
            this.penniesTextBox.TabIndex = 5;
            // 
            // nickelsTextBox
            // 
            this.nickelsTextBox.Location = new System.Drawing.Point(175, 144);
            this.nickelsTextBox.Name = "nickelsTextBox";
            this.nickelsTextBox.Size = new System.Drawing.Size(100, 20);
            this.nickelsTextBox.TabIndex = 6;
            // 
            // dimesTextBox
            // 
            this.dimesTextBox.Location = new System.Drawing.Point(175, 201);
            this.dimesTextBox.Name = "dimesTextBox";
            this.dimesTextBox.Size = new System.Drawing.Size(100, 20);
            this.dimesTextBox.TabIndex = 7;
            // 
            // quartersTextBox
            // 
            this.quartersTextBox.Location = new System.Drawing.Point(175, 251);
            this.quartersTextBox.Name = "quartersTextBox";
            this.quartersTextBox.Size = new System.Drawing.Size(100, 20);
            this.quartersTextBox.TabIndex = 8;
            // 
            // caluculateButton
            // 
            this.caluculateButton.Location = new System.Drawing.Point(93, 353);
            this.caluculateButton.Name = "caluculateButton";
            this.caluculateButton.Size = new System.Drawing.Size(75, 23);
            this.caluculateButton.TabIndex = 9;
            this.caluculateButton.Text = "Calculate";
            this.caluculateButton.UseVisualStyleBackColor = true;
            this.caluculateButton.Click += new System.EventHandler(this.caluculateButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(351, 353);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 10;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(228, 353);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 11;
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
            this.Controls.Add(this.caluculateButton);
            this.Controls.Add(this.quartersTextBox);
            this.Controls.Add(this.dimesTextBox);
            this.Controls.Add(this.nickelsTextBox);
            this.Controls.Add(this.penniesTextBox);
            this.Controls.Add(this.quartersLabel);
            this.Controls.Add(this.dimesLabel);
            this.Controls.Add(this.nickelsLabel);
            this.Controls.Add(this.penniesLabel);
            this.Controls.Add(this.satementLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label satementLabel;
        private System.Windows.Forms.Label penniesLabel;
        private System.Windows.Forms.Label nickelsLabel;
        private System.Windows.Forms.Label dimesLabel;
        private System.Windows.Forms.Label quartersLabel;
        private System.Windows.Forms.TextBox penniesTextBox;
        private System.Windows.Forms.TextBox nickelsTextBox;
        private System.Windows.Forms.TextBox dimesTextBox;
        private System.Windows.Forms.TextBox quartersTextBox;
        private System.Windows.Forms.Button caluculateButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button clearButton;
    }
}

