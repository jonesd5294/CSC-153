
namespace Color_Mixer
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
            this.exitButton = new System.Windows.Forms.Button();
            this.mixButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.primBox1 = new System.Windows.Forms.GroupBox();
            this.primBox2 = new System.Windows.Forms.GroupBox();
            this.redRadButton1 = new System.Windows.Forms.RadioButton();
            this.blueRadButton1 = new System.Windows.Forms.RadioButton();
            this.yelRadButton1 = new System.Windows.Forms.RadioButton();
            this.redRadButton2 = new System.Windows.Forms.RadioButton();
            this.blueRadButton2 = new System.Windows.Forms.RadioButton();
            this.yelRadButton2 = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.primBox1.SuspendLayout();
            this.primBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(474, 350);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // mixButton
            // 
            this.mixButton.Location = new System.Drawing.Point(160, 350);
            this.mixButton.Name = "mixButton";
            this.mixButton.Size = new System.Drawing.Size(75, 23);
            this.mixButton.TabIndex = 2;
            this.mixButton.Text = "Mix";
            this.mixButton.UseVisualStyleBackColor = true;
            this.mixButton.Click += new System.EventHandler(this.mixButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.primBox2);
            this.panel1.Controls.Add(this.primBox1);
            this.panel1.Location = new System.Drawing.Point(39, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(657, 331);
            this.panel1.TabIndex = 3;
            // 
            // primBox1
            // 
            this.primBox1.Controls.Add(this.yelRadButton1);
            this.primBox1.Controls.Add(this.blueRadButton1);
            this.primBox1.Controls.Add(this.redRadButton1);
            this.primBox1.Location = new System.Drawing.Point(75, 74);
            this.primBox1.Name = "primBox1";
            this.primBox1.Size = new System.Drawing.Size(200, 150);
            this.primBox1.TabIndex = 0;
            this.primBox1.TabStop = false;
            this.primBox1.Text = "Select the First Color";
            // 
            // primBox2
            // 
            this.primBox2.Controls.Add(this.yelRadButton2);
            this.primBox2.Controls.Add(this.blueRadButton2);
            this.primBox2.Controls.Add(this.redRadButton2);
            this.primBox2.Location = new System.Drawing.Point(396, 74);
            this.primBox2.Name = "primBox2";
            this.primBox2.Size = new System.Drawing.Size(200, 150);
            this.primBox2.TabIndex = 1;
            this.primBox2.TabStop = false;
            this.primBox2.Text = "Select the Second Color";
            // 
            // redRadButton1
            // 
            this.redRadButton1.AutoSize = true;
            this.redRadButton1.Location = new System.Drawing.Point(27, 20);
            this.redRadButton1.Name = "redRadButton1";
            this.redRadButton1.Size = new System.Drawing.Size(45, 17);
            this.redRadButton1.TabIndex = 0;
            this.redRadButton1.TabStop = true;
            this.redRadButton1.Text = "Red";
            this.redRadButton1.UseVisualStyleBackColor = true;
            // 
            // blueRadButton1
            // 
            this.blueRadButton1.AutoSize = true;
            this.blueRadButton1.Location = new System.Drawing.Point(27, 58);
            this.blueRadButton1.Name = "blueRadButton1";
            this.blueRadButton1.Size = new System.Drawing.Size(46, 17);
            this.blueRadButton1.TabIndex = 1;
            this.blueRadButton1.TabStop = true;
            this.blueRadButton1.Text = "Blue";
            this.blueRadButton1.UseVisualStyleBackColor = true;
            // 
            // yelRadButton1
            // 
            this.yelRadButton1.AutoSize = true;
            this.yelRadButton1.Location = new System.Drawing.Point(27, 106);
            this.yelRadButton1.Name = "yelRadButton1";
            this.yelRadButton1.Size = new System.Drawing.Size(56, 17);
            this.yelRadButton1.TabIndex = 2;
            this.yelRadButton1.TabStop = true;
            this.yelRadButton1.Text = "Yellow";
            this.yelRadButton1.UseVisualStyleBackColor = true;
            // 
            // redRadButton2
            // 
            this.redRadButton2.AutoSize = true;
            this.redRadButton2.Location = new System.Drawing.Point(29, 20);
            this.redRadButton2.Name = "redRadButton2";
            this.redRadButton2.Size = new System.Drawing.Size(45, 17);
            this.redRadButton2.TabIndex = 0;
            this.redRadButton2.TabStop = true;
            this.redRadButton2.Text = "Red";
            this.redRadButton2.UseVisualStyleBackColor = true;
            // 
            // blueRadButton2
            // 
            this.blueRadButton2.AutoSize = true;
            this.blueRadButton2.Location = new System.Drawing.Point(29, 58);
            this.blueRadButton2.Name = "blueRadButton2";
            this.blueRadButton2.Size = new System.Drawing.Size(46, 17);
            this.blueRadButton2.TabIndex = 1;
            this.blueRadButton2.TabStop = true;
            this.blueRadButton2.Text = "Blue";
            this.blueRadButton2.UseVisualStyleBackColor = true;
            // 
            // yelRadButton2
            // 
            this.yelRadButton2.AutoSize = true;
            this.yelRadButton2.Location = new System.Drawing.Point(29, 106);
            this.yelRadButton2.Name = "yelRadButton2";
            this.yelRadButton2.Size = new System.Drawing.Size(56, 17);
            this.yelRadButton2.TabIndex = 2;
            this.yelRadButton2.TabStop = true;
            this.yelRadButton2.Text = "Yellow";
            this.yelRadButton2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mixButton);
            this.Controls.Add(this.exitButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.primBox1.ResumeLayout(false);
            this.primBox1.PerformLayout();
            this.primBox2.ResumeLayout(false);
            this.primBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button mixButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox primBox2;
        private System.Windows.Forms.RadioButton yelRadButton2;
        private System.Windows.Forms.RadioButton blueRadButton2;
        private System.Windows.Forms.RadioButton redRadButton2;
        private System.Windows.Forms.GroupBox primBox1;
        private System.Windows.Forms.RadioButton yelRadButton1;
        private System.Windows.Forms.RadioButton blueRadButton1;
        private System.Windows.Forms.RadioButton redRadButton1;
    }
}

