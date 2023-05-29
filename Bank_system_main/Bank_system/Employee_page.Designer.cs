namespace Bank_system
{
    partial class Employee_page
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.add_customer_search1 = new Bank_system.Add_customer_search1();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Forte", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(28, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(85, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 67);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add customer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(322, 104);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 61);
            this.button2.TabIndex = 2;
            this.button2.Text = "Show list of loans";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(539, 84);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 61);
            this.button3.TabIndex = 3;
            this.button3.Text = "Show Customers";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // add_customer_search1
            // 
            this.add_customer_search1.Location = new System.Drawing.Point(185, 151);
            this.add_customer_search1.Name = "add_customer_search1";
            this.add_customer_search1.Size = new System.Drawing.Size(417, 161);
            this.add_customer_search1.TabIndex = 4;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(230, 295);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(171, 66);
            this.button4.TabIndex = 5;
            this.button4.Text = "Show All details of loans";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(467, 295);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(166, 66);
            this.button5.TabIndex = 6;
            this.button5.Text = "Manage Loans";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Employee_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.add_customer_search1);
            this.Name = "Employee_page";
            this.Text = "Employee_page";
            this.Load += new System.EventHandler(this.Employee_page_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Add_customer_search1 add_customer_search1;
        private Button button4;
        private Button button5;
    }
}