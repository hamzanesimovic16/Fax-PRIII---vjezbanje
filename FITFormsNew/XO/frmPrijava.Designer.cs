namespace FITFormsNew
{
    partial class frmPrijava
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
            txtIgrac1 = new TextBox();
            txtIgrac2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnPokreni = new Button();
            SuspendLayout();
            // 
            // txtIgrac1
            // 
            txtIgrac1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            txtIgrac1.Location = new Point(101, 86);
            txtIgrac1.Name = "txtIgrac1";
            txtIgrac1.Size = new Size(180, 34);
            txtIgrac1.TabIndex = 0;
            txtIgrac1.TextAlign = HorizontalAlignment.Center;
            // 
            // txtIgrac2
            // 
            txtIgrac2.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            txtIgrac2.Location = new Point(528, 86);
            txtIgrac2.Name = "txtIgrac2";
            txtIgrac2.Size = new Size(180, 34);
            txtIgrac2.TabIndex = 1;
            txtIgrac2.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(149, 34);
            label1.Name = "label1";
            label1.Size = new Size(96, 37);
            label1.TabIndex = 2;
            label1.Text = "Igrac1:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(578, 34);
            label2.Name = "label2";
            label2.Size = new Size(96, 37);
            label2.TabIndex = 3;
            label2.Text = "Igrac2:";
            // 
            // btnPokreni
            // 
            btnPokreni.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            btnPokreni.Location = new Point(286, 162);
            btnPokreni.Name = "btnPokreni";
            btnPokreni.Size = new Size(235, 47);
            btnPokreni.TabIndex = 4;
            btnPokreni.Text = "POKRENI";
            btnPokreni.UseVisualStyleBackColor = true;
            btnPokreni.Click += btnPokreni_Click_1;
            // 
            // frmPrijava
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 221);
            Controls.Add(btnPokreni);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtIgrac2);
            Controls.Add(txtIgrac1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmPrijava";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Prijava";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtIgrac1;
        private TextBox txtIgrac2;
        private Label label1;
        private Label label2;
        private Button btnPokreni;
    }
}