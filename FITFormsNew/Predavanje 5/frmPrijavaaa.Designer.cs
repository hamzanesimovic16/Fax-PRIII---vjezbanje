namespace FITFormsNew.Predavanje_5
{
    partial class frmPrijavaaa
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
            components = new System.ComponentModel.Container();
            pictureBox1 = new PictureBox();
            txtKorisnickoIme = new TextBox();
            txtSifra = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnPrijava = new Button();
            label3 = new Label();
            err = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.og_image;
            pictureBox1.Location = new Point(27, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(177, 168);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // txtKorisnickoIme
            // 
            txtKorisnickoIme.Location = new Point(254, 67);
            txtKorisnickoIme.Name = "txtKorisnickoIme";
            txtKorisnickoIme.Size = new Size(281, 23);
            txtKorisnickoIme.TabIndex = 1;
            // 
            // txtSifra
            // 
            txtSifra.Location = new Point(254, 125);
            txtSifra.Name = "txtSifra";
            txtSifra.Size = new Size(281, 23);
            txtSifra.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(254, 49);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 3;
            label1.Text = "Korisnicko ime";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(254, 107);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 4;
            label2.Text = "Sifra";
            // 
            // btnPrijava
            // 
            btnPrijava.Location = new Point(460, 164);
            btnPrijava.Name = "btnPrijava";
            btnPrijava.Size = new Size(75, 31);
            btnPrijava.TabIndex = 5;
            btnPrijava.Text = "Prijavi";
            btnPrijava.UseVisualStyleBackColor = true;
            btnPrijava.Click += btnPrijava_Click;
            // 
            // label3
            // 
            label3.BackColor = Color.Black;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(232, 30);
            label3.Name = "label3";
            label3.Size = new Size(2, 165);
            label3.TabIndex = 6;
            label3.Text = "label3";
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // frmPrijavaaa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(552, 214);
            Controls.Add(label3);
            Controls.Add(btnPrijava);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSifra);
            Controls.Add(txtKorisnickoIme);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmPrijavaaa";
            Text = "frmPrijava";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox txtKorisnickoIme;
        private TextBox txtSifra;
        private Label label1;
        private Label label2;
        private Button btnPrijava;
        private Label label3;
        private ErrorProvider err;
    }
}