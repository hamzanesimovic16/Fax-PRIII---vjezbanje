namespace FITFormsNew.Predavanje_7
{
    partial class frmNoviStudent
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
            lblIme = new Label();
            lblPrezime = new Label();
            lblEmail = new Label();
            txtIme = new TextBox();
            txtPrezime = new TextBox();
            txtEmail = new TextBox();
            txtLozinka = new TextBox();
            label1 = new Label();
            dtpDatumRodjenja = new DateTimePicker();
            label2 = new Label();
            txtIndeks = new TextBox();
            label3 = new Label();
            comboBox1 = new ComboBox();
            label4 = new Label();
            btnSpasi = new Button();
            pbSlika = new PictureBox();
            btnSlika = new Button();
            openFileDialog1 = new OpenFileDialog();
            cbAktivan = new CheckBox();
            btnNovaLozinka = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pbSlika).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblIme
            // 
            lblIme.AutoSize = true;
            lblIme.Location = new Point(200, 15);
            lblIme.Name = "lblIme";
            lblIme.Size = new Size(30, 15);
            lblIme.TabIndex = 0;
            lblIme.Text = "Ime:";
            // 
            // lblPrezime
            // 
            lblPrezime.AutoSize = true;
            lblPrezime.Location = new Point(387, 15);
            lblPrezime.Name = "lblPrezime";
            lblPrezime.Size = new Size(52, 15);
            lblPrezime.TabIndex = 1;
            lblPrezime.Text = "Prezime:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(200, 67);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 15);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email:";
            // 
            // txtIme
            // 
            txtIme.Location = new Point(200, 33);
            txtIme.Name = "txtIme";
            txtIme.Size = new Size(172, 23);
            txtIme.TabIndex = 1;
            txtIme.TextChanged += txtIme_TextChanged;
            // 
            // txtPrezime
            // 
            txtPrezime.Location = new Point(387, 33);
            txtPrezime.Name = "txtPrezime";
            txtPrezime.Size = new Size(134, 23);
            txtPrezime.TabIndex = 2;
            txtPrezime.TextChanged += txtPrezime_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(200, 85);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(172, 23);
            txtEmail.TabIndex = 3;
            // 
            // txtLozinka
            // 
            txtLozinka.Location = new Point(387, 85);
            txtLozinka.Name = "txtLozinka";
            txtLozinka.Size = new Size(134, 23);
            txtLozinka.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(387, 67);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 6;
            label1.Text = "Lozinka:";
            // 
            // dtpDatumRodjenja
            // 
            dtpDatumRodjenja.Location = new Point(200, 138);
            dtpDatumRodjenja.Name = "dtpDatumRodjenja";
            dtpDatumRodjenja.Size = new Size(321, 23);
            dtpDatumRodjenja.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(200, 120);
            label2.Name = "label2";
            label2.Size = new Size(92, 15);
            label2.TabIndex = 9;
            label2.Text = "Datum rodjenja:";
            // 
            // txtIndeks
            // 
            txtIndeks.Enabled = false;
            txtIndeks.Location = new Point(200, 187);
            txtIndeks.Name = "txtIndeks";
            txtIndeks.Size = new Size(172, 23);
            txtIndeks.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(200, 169);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 10;
            label3.Text = "Indeks:";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(387, 187);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(134, 23);
            comboBox1.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(387, 169);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 13;
            label4.Text = "Semestar:";
            // 
            // btnSpasi
            // 
            btnSpasi.Location = new Point(446, 234);
            btnSpasi.Name = "btnSpasi";
            btnSpasi.Size = new Size(75, 23);
            btnSpasi.TabIndex = 9;
            btnSpasi.Text = "Spasi";
            btnSpasi.UseVisualStyleBackColor = true;
            btnSpasi.Click += btnSpasi_Click;
            // 
            // pbSlika
            // 
            pbSlika.Location = new Point(12, 12);
            pbSlika.Name = "pbSlika";
            pbSlika.Size = new Size(170, 217);
            pbSlika.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSlika.TabIndex = 15;
            pbSlika.TabStop = false;
            // 
            // btnSlika
            // 
            btnSlika.Location = new Point(12, 235);
            btnSlika.Name = "btnSlika";
            btnSlika.Size = new Size(170, 23);
            btnSlika.TabIndex = 0;
            btnSlika.Text = "Izaberi sliku";
            btnSlika.UseVisualStyleBackColor = true;
            btnSlika.Click += btnSlika_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // cbAktivan
            // 
            cbAktivan.AutoSize = true;
            cbAktivan.Checked = true;
            cbAktivan.CheckState = CheckState.Checked;
            cbAktivan.Location = new Point(200, 216);
            cbAktivan.Name = "cbAktivan";
            cbAktivan.Size = new Size(66, 19);
            cbAktivan.TabIndex = 8;
            cbAktivan.Text = "Aktivan";
            cbAktivan.UseVisualStyleBackColor = true;
            // 
            // btnNovaLozinka
            // 
            btnNovaLozinka.Location = new Point(527, 85);
            btnNovaLozinka.Name = "btnNovaLozinka";
            btnNovaLozinka.Size = new Size(18, 23);
            btnNovaLozinka.TabIndex = 16;
            btnNovaLozinka.Text = "R";
            btnNovaLozinka.UseVisualStyleBackColor = true;
            btnNovaLozinka.Click += btnNovaLozinka_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmNoviStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(579, 269);
            Controls.Add(btnNovaLozinka);
            Controls.Add(cbAktivan);
            Controls.Add(btnSlika);
            Controls.Add(pbSlika);
            Controls.Add(btnSpasi);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(txtIndeks);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dtpDatumRodjenja);
            Controls.Add(txtLozinka);
            Controls.Add(label1);
            Controls.Add(txtEmail);
            Controls.Add(txtPrezime);
            Controls.Add(txtIme);
            Controls.Add(lblEmail);
            Controls.Add(lblPrezime);
            Controls.Add(lblIme);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmNoviStudent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Podaci o novom studentu";
            Load += frmNoviStudent_Load;
            ((System.ComponentModel.ISupportInitialize)pbSlika).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblIme;
        private Label lblPrezime;
        private Label lblEmail;
        private TextBox txtIme;
        private TextBox txtPrezime;
        private TextBox txtEmail;
        private TextBox txtLozinka;
        private Label label1;
        private DateTimePicker dtpDatumRodjenja;
        private Label label2;
        private TextBox txtIndeks;
        private Label label3;
        private ComboBox comboBox1;
        private Label label4;
        private Button btnSpasi;
        private PictureBox pbSlika;
        private Button btnSlika;
        private OpenFileDialog openFileDialog1;
        private CheckBox cbAktivan;
        private Button btnNovaLozinka;
        private ErrorProvider errorProvider1;
    }
}