﻿namespace WindowsFormsApp1
{
    partial class Form1
    {
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnEquals;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox okno;

        private void InitializeComponent()
        {
            this.btn0 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnEquals = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.okno = new System.Windows.Forms.TextBox();

            // 
            // 
            this.btn0.Location = new System.Drawing.Point(10, 210);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(50, 50);
            this.btn0.TabIndex = 0;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btnNumber_Click);

            // 
            // 
            this.btn1.Location = new System.Drawing.Point(10, 150);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(50, 50);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btnNumber_Click);

            // 
            // 
            this.btn2.Location = new System.Drawing.Point(70, 150);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(50, 50);
            this.btn2.TabIndex = 2;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btnNumber_Click);

            // 
            // 
            this.btn3.Location = new System.Drawing.Point(130, 150);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(50, 50);
            this.btn3.TabIndex = 3;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btnNumber_Click);

            // 
            // 
            this.btn4.Location = new System.Drawing.Point(10, 90);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(50, 50);
            this.btn4.TabIndex = 4;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btnNumber_Click);

            // 
            // 
            this.btn5.Location = new System.Drawing.Point(70, 90);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(50, 50);
            this.btn5.TabIndex = 5;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btnNumber_Click);

            // 
            // 
            this.btn6.Location = new System.Drawing.Point(130, 90);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(50, 50);
            this.btn6.TabIndex = 6;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btnNumber_Click);

            // 
            // 
            this.btn7.Location = new System.Drawing.Point(10, 30);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(50, 50);
            this.btn7.TabIndex = 7;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btnNumber_Click);

            // 
            // 
            this.btn8.Location = new System.Drawing.Point(70, 30);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(50, 50);
            this.btn8.TabIndex = 8;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btnNumber_Click);

            // 
            // 
            this.btn9.Location = new System.Drawing.Point(130, 30);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(50, 50);
            this.btn9.TabIndex = 9;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btnNumber_Click);

            // 
            // 
            this.btnAdd.Location = new System.Drawing.Point(190, 30);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(50, 50);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            // 
            // 
            this.btnSubtract.Location = new System.Drawing.Point(190, 90);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(50, 50);
            this.btnSubtract.TabIndex = 11;
            this.btnSubtract.Text = "-";
            this.btnSubtract.UseVisualStyleBackColor = true;
            this.btnSubtract.Click += new System.EventHandler(this.btnSubtract_Click);

            // 
            // 
            this.btnMultiply.Location = new System.Drawing.Point(190, 150);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(50, 50);
            this.btnMultiply.TabIndex = 12;
            this.btnMultiply.Text = "*";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);

            // 
            // 
            this.btnDivide.Location = new System.Drawing.Point(190, 210);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(50, 50);
            this.btnDivide.TabIndex = 13;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);

            // 
            // 
            this.btnEquals.Location = new System.Drawing.Point(130, 210);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(50, 50);
            this.btnEquals.TabIndex = 14;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = true;
            this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click);

            // 
            // 
            this.btnClear.Location = new System.Drawing.Point(70, 210);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(50, 50);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            // 
            // 
            this.okno.Location = new System.Drawing.Point(10, 270);
            this.okno.Name = "okno";
            this.okno.Size = new System.Drawing.Size(230, 20);
            this.okno.TabIndex = 16;
            this.okno.Text = "0";

            // 
            // 
            this.ClientSize = new System.Drawing.Size(284, 311);
            this.Controls.Add(this.okno);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnEquals);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn0);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
