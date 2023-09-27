namespace CashRegister
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
            this.burgerInput = new System.Windows.Forms.TextBox();
            this.friesInput = new System.Windows.Forms.TextBox();
            this.drinkInput = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.burgerLabel = new System.Windows.Forms.Label();
            this.friesLabel = new System.Windows.Forms.Label();
            this.drinkLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.subtotalOutput = new System.Windows.Forms.Label();
            this.taxOutput = new System.Windows.Forms.Label();
            this.totalOutput = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // burgerInput
            // 
            this.burgerInput.Location = new System.Drawing.Point(159, 75);
            this.burgerInput.Name = "burgerInput";
            this.burgerInput.Size = new System.Drawing.Size(100, 22);
            this.burgerInput.TabIndex = 0;
            // 
            // friesInput
            // 
            this.friesInput.Location = new System.Drawing.Point(159, 119);
            this.friesInput.Name = "friesInput";
            this.friesInput.Size = new System.Drawing.Size(100, 22);
            this.friesInput.TabIndex = 1;
            // 
            // drinkInput
            // 
            this.drinkInput.Location = new System.Drawing.Point(159, 163);
            this.drinkInput.Name = "drinkInput";
            this.drinkInput.Size = new System.Drawing.Size(100, 22);
            this.drinkInput.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(159, 297);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 3;
            // 
            // burgerLabel
            // 
            this.burgerLabel.AutoSize = true;
            this.burgerLabel.Location = new System.Drawing.Point(34, 78);
            this.burgerLabel.Name = "burgerLabel";
            this.burgerLabel.Size = new System.Drawing.Size(119, 16);
            this.burgerLabel.TabIndex = 4;
            this.burgerLabel.Text = "Number of Burgers";
            // 
            // friesLabel
            // 
            this.friesLabel.AutoSize = true;
            this.friesLabel.Location = new System.Drawing.Point(51, 122);
            this.friesLabel.Name = "friesLabel";
            this.friesLabel.Size = new System.Drawing.Size(102, 16);
            this.friesLabel.TabIndex = 5;
            this.friesLabel.Text = "Number of Fries";
            // 
            // drinkLabel
            // 
            this.drinkLabel.AutoSize = true;
            this.drinkLabel.Location = new System.Drawing.Point(40, 166);
            this.drinkLabel.Name = "drinkLabel";
            this.drinkLabel.Size = new System.Drawing.Size(113, 16);
            this.drinkLabel.TabIndex = 6;
            this.drinkLabel.Text = "Number of Drinks ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Sub Total";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tax";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Total";
            // 
            // subtotalOutput
            // 
            this.subtotalOutput.AutoSize = true;
            this.subtotalOutput.Location = new System.Drawing.Point(159, 212);
            this.subtotalOutput.Name = "subtotalOutput";
            this.subtotalOutput.Size = new System.Drawing.Size(44, 16);
            this.subtotalOutput.TabIndex = 10;
            this.subtotalOutput.Text = "label7";
            // 
            // taxOutput
            // 
            this.taxOutput.AutoSize = true;
            this.taxOutput.Location = new System.Drawing.Point(159, 238);
            this.taxOutput.Name = "taxOutput";
            this.taxOutput.Size = new System.Drawing.Size(44, 16);
            this.taxOutput.TabIndex = 11;
            this.taxOutput.Text = "label8";
            // 
            // totalOutput
            // 
            this.totalOutput.AutoSize = true;
            this.totalOutput.Location = new System.Drawing.Point(159, 265);
            this.totalOutput.Name = "totalOutput";
            this.totalOutput.Size = new System.Drawing.Size(44, 16);
            this.totalOutput.TabIndex = 12;
            this.totalOutput.Text = "label9";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(55, 302);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 16);
            this.label10.TabIndex = 13;
            this.label10.Text = "Tendered";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(101, 187);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 14;
            this.calculateButton.Text = "Calculate ";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(101, 325);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(101, 383);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(55, 360);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 16);
            this.label11.TabIndex = 17;
            this.label11.Text = "Change";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(159, 360);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 16);
            this.label12.TabIndex = 18;
            this.label12.Text = "label12";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(195, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 16);
            this.label13.TabIndex = 19;
            this.label13.Text = "Burger Town";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 418);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.totalOutput);
            this.Controls.Add(this.taxOutput);
            this.Controls.Add(this.subtotalOutput);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.drinkLabel);
            this.Controls.Add(this.friesLabel);
            this.Controls.Add(this.burgerLabel);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.drinkInput);
            this.Controls.Add(this.friesInput);
            this.Controls.Add(this.burgerInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox burgerInput;
        private System.Windows.Forms.TextBox friesInput;
        private System.Windows.Forms.TextBox drinkInput;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label burgerLabel;
        private System.Windows.Forms.Label friesLabel;
        private System.Windows.Forms.Label drinkLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label subtotalOutput;
        private System.Windows.Forms.Label taxOutput;
        private System.Windows.Forms.Label totalOutput;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}

