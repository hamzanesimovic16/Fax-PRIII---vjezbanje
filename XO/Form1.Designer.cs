﻿namespace XO
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            SuspendLayout();
            // 
            // btn1
            // 
            btn1.Font = new Font("Microsoft Sans Serif", 70F, FontStyle.Regular, GraphicsUnit.Point);
            btn1.Location = new Point(12, 35);
            btn1.Name = "btn1";
            btn1.Size = new Size(130, 130);
            btn1.TabIndex = 0;
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn_Click;
            // 
            // btn2
            // 
            btn2.Font = new Font("Microsoft Sans Serif", 70F, FontStyle.Regular, GraphicsUnit.Point);
            btn2.Location = new Point(156, 35);
            btn2.Name = "btn2";
            btn2.Size = new Size(130, 130);
            btn2.TabIndex = 1;
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn_Click;
            // 
            // btn3
            // 
            btn3.Font = new Font("Microsoft Sans Serif", 70F, FontStyle.Regular, GraphicsUnit.Point);
            btn3.Location = new Point(304, 35);
            btn3.Name = "btn3";
            btn3.Size = new Size(130, 130);
            btn3.TabIndex = 2;
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Microsoft Sans Serif", 70F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(12, 171);
            button4.Name = "button4";
            button4.Size = new Size(130, 130);
            button4.TabIndex = 3;
            button4.UseVisualStyleBackColor = true;
            button4.Click += btn_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Microsoft Sans Serif", 70F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(156, 171);
            button5.Name = "button5";
            button5.Size = new Size(130, 130);
            button5.TabIndex = 4;
            button5.UseVisualStyleBackColor = true;
            button5.Click += btn_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Microsoft Sans Serif", 70F, FontStyle.Regular, GraphicsUnit.Point);
            button6.Location = new Point(304, 171);
            button6.Name = "button6";
            button6.Size = new Size(130, 130);
            button6.TabIndex = 5;
            button6.UseVisualStyleBackColor = true;
            button6.Click += btn_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Microsoft Sans Serif", 70F, FontStyle.Regular, GraphicsUnit.Point);
            button7.Location = new Point(12, 307);
            button7.Name = "button7";
            button7.Size = new Size(130, 130);
            button7.TabIndex = 6;
            button7.UseVisualStyleBackColor = true;
            button7.Click += btn_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Microsoft Sans Serif", 70F, FontStyle.Regular, GraphicsUnit.Point);
            button8.Location = new Point(156, 308);
            button8.Name = "button8";
            button8.Size = new Size(130, 130);
            button8.TabIndex = 7;
            button8.UseVisualStyleBackColor = true;
            button8.Click += btn_Click;
            // 
            // button9
            // 
            button9.Font = new Font("Microsoft Sans Serif", 70F, FontStyle.Regular, GraphicsUnit.Point);
            button9.Location = new Point(304, 308);
            button9.Name = "button9";
            button9.Size = new Size(130, 130);
            button9.TabIndex = 8;
            button9.UseVisualStyleBackColor = true;
            button9.Click += btn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(446, 450);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
    }
}