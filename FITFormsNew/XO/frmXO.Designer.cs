namespace FITFormsNew
{
    partial class frmXO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmXO));
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            btnReset = new Button();
            lblPlayersName = new Label();
            SuspendLayout();
            // 
            // btn1
            // 
            btn1.Font = new Font("Microsoft Sans Serif", 70F, FontStyle.Regular, GraphicsUnit.Point);
            btn1.Location = new Point(12, 85);
            btn1.Name = "btn1";
            btn1.Size = new Size(130, 130);
            btn1.TabIndex = 0;
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn_Click;
            // 
            // btn2
            // 
            btn2.Font = new Font("Microsoft Sans Serif", 70F, FontStyle.Regular, GraphicsUnit.Point);
            btn2.Location = new Point(156, 85);
            btn2.Name = "btn2";
            btn2.Size = new Size(130, 130);
            btn2.TabIndex = 1;
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn_Click;
            // 
            // btn3
            // 
            btn3.Font = new Font("Microsoft Sans Serif", 70F, FontStyle.Regular, GraphicsUnit.Point);
            btn3.Location = new Point(304, 85);
            btn3.Name = "btn3";
            btn3.Size = new Size(130, 130);
            btn3.TabIndex = 2;
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Microsoft Sans Serif", 70F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(12, 221);
            button4.Name = "button4";
            button4.Size = new Size(130, 130);
            button4.TabIndex = 3;
            button4.UseVisualStyleBackColor = true;
            button4.Click += btn_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Microsoft Sans Serif", 70F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(156, 221);
            button5.Name = "button5";
            button5.Size = new Size(130, 130);
            button5.TabIndex = 4;
            button5.UseVisualStyleBackColor = true;
            button5.Click += btn_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Microsoft Sans Serif", 70F, FontStyle.Regular, GraphicsUnit.Point);
            button6.Location = new Point(304, 221);
            button6.Name = "button6";
            button6.Size = new Size(130, 130);
            button6.TabIndex = 5;
            button6.UseVisualStyleBackColor = true;
            button6.Click += btn_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Microsoft Sans Serif", 70F, FontStyle.Regular, GraphicsUnit.Point);
            button7.Location = new Point(12, 357);
            button7.Name = "button7";
            button7.Size = new Size(130, 130);
            button7.TabIndex = 6;
            button7.UseVisualStyleBackColor = true;
            button7.Click += btn_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Microsoft Sans Serif", 70F, FontStyle.Regular, GraphicsUnit.Point);
            button8.Location = new Point(156, 358);
            button8.Name = "button8";
            button8.Size = new Size(130, 130);
            button8.TabIndex = 7;
            button8.UseVisualStyleBackColor = true;
            button8.Click += btn_Click;
            // 
            // button9
            // 
            button9.Font = new Font("Microsoft Sans Serif", 70F, FontStyle.Regular, GraphicsUnit.Point);
            button9.Location = new Point(304, 358);
            button9.Name = "button9";
            button9.Size = new Size(130, 130);
            button9.TabIndex = 8;
            button9.UseVisualStyleBackColor = true;
            button9.Click += btn_Click;
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnReset.Location = new Point(333, 22);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(89, 46);
            btnReset.TabIndex = 9;
            btnReset.Text = "reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += button1_Click;
            // 
            // lblPlayersName
            // 
            lblPlayersName.AutoSize = true;
            lblPlayersName.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lblPlayersName.Location = new Point(12, 40);
            lblPlayersName.Name = "lblPlayersName";
            lblPlayersName.Size = new Size(0, 28);
            lblPlayersName.TabIndex = 10;
            // 
            // frmXO
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(446, 500);
            Controls.Add(lblPlayersName);
            Controls.Add(btnReset);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "frmXO";
            Text = "XO - Almedin i Hamza";
            Load += frmXO_Load;
            ResumeLayout(false);
            PerformLayout();
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
        private Button btnReset;
        private Label lblPlayersName;
    }
}