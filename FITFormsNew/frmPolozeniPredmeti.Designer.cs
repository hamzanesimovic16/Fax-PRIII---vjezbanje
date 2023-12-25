namespace FITFormsNew
{
    partial class frmPolozeniPredmeti
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
            dgvPolozeniPredmeti = new DataGridView();
            Predmet = new DataGridViewTextBoxColumn();
            DatumPolaganja = new DataGridViewTextBoxColumn();
            Ocjena = new DataGridViewTextBoxColumn();
            cmbPredmet = new ComboBox();
            label1 = new Label();
            cmbOcjena = new ComboBox();
            label2 = new Label();
            dtpDatumPolaganja = new DateTimePicker();
            label3 = new Label();
            btnSpasi = new Button();
            errorProvider1 = new ErrorProvider(components);
            pbSlika = new PictureBox();
            lblBrojIndeksa = new Label();
            lblImePrezime = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPolozeniPredmeti).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbSlika).BeginInit();
            SuspendLayout();
            // 
            // dgvPolozeniPredmeti
            // 
            dgvPolozeniPredmeti.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPolozeniPredmeti.Columns.AddRange(new DataGridViewColumn[] { Predmet, DatumPolaganja, Ocjena });
            dgvPolozeniPredmeti.Location = new Point(12, 254);
            dgvPolozeniPredmeti.Name = "dgvPolozeniPredmeti";
            dgvPolozeniPredmeti.RowTemplate.Height = 25;
            dgvPolozeniPredmeti.Size = new Size(776, 184);
            dgvPolozeniPredmeti.TabIndex = 0;
            dgvPolozeniPredmeti.CellContentClick += dgvPolozeniPredmeti_CellContentClick;
            // 
            // Predmet
            // 
            Predmet.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Predmet.DataPropertyName = "Predmet";
            Predmet.HeaderText = "Predmet";
            Predmet.Name = "Predmet";
            // 
            // DatumPolaganja
            // 
            DatumPolaganja.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DatumPolaganja.DataPropertyName = "DatumPolaganja";
            DatumPolaganja.HeaderText = "DatumPolaganja";
            DatumPolaganja.Name = "DatumPolaganja";
            // 
            // Ocjena
            // 
            Ocjena.DataPropertyName = "Ocjena";
            Ocjena.HeaderText = "Ocjena";
            Ocjena.Name = "Ocjena";
            // 
            // cmbPredmet
            // 
            cmbPredmet.FormattingEnabled = true;
            cmbPredmet.Location = new Point(12, 225);
            cmbPredmet.Name = "cmbPredmet";
            cmbPredmet.Size = new Size(156, 23);
            cmbPredmet.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 207);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 2;
            label1.Text = "Predmet";
            // 
            // cmbOcjena
            // 
            cmbOcjena.FormattingEnabled = true;
            cmbOcjena.Items.AddRange(new object[] { "6", "7", "8", "9", "10" });
            cmbOcjena.Location = new Point(174, 225);
            cmbOcjena.Name = "cmbOcjena";
            cmbOcjena.Size = new Size(121, 23);
            cmbOcjena.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(174, 207);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 4;
            label2.Text = "Ocjena";
            label2.Click += label2_Click;
            // 
            // dtpDatumPolaganja
            // 
            dtpDatumPolaganja.Location = new Point(301, 225);
            dtpDatumPolaganja.Name = "dtpDatumPolaganja";
            dtpDatumPolaganja.Size = new Size(200, 23);
            dtpDatumPolaganja.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(301, 207);
            label3.Name = "label3";
            label3.Size = new Size(98, 15);
            label3.TabIndex = 6;
            label3.Text = "Datum polaganja";
            // 
            // btnSpasi
            // 
            btnSpasi.Location = new Point(519, 225);
            btnSpasi.Name = "btnSpasi";
            btnSpasi.Size = new Size(75, 23);
            btnSpasi.TabIndex = 7;
            btnSpasi.Text = "Spasi";
            btnSpasi.UseVisualStyleBackColor = true;
            btnSpasi.Click += btnSpasi_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // pbSlika
            // 
            pbSlika.Location = new Point(24, 12);
            pbSlika.Name = "pbSlika";
            pbSlika.Size = new Size(131, 168);
            pbSlika.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSlika.TabIndex = 8;
            pbSlika.TabStop = false;
            // 
            // lblBrojIndeksa
            // 
            lblBrojIndeksa.AutoSize = true;
            lblBrojIndeksa.Font = new Font("Segoe UI Semibold", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBrojIndeksa.Location = new Point(174, 26);
            lblBrojIndeksa.Name = "lblBrojIndeksa";
            lblBrojIndeksa.Size = new Size(0, 47);
            lblBrojIndeksa.TabIndex = 9;
            // 
            // lblImePrezime
            // 
            lblImePrezime.AutoSize = true;
            lblImePrezime.Font = new Font("Segoe UI Semibold", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblImePrezime.Location = new Point(174, 118);
            lblImePrezime.Name = "lblImePrezime";
            lblImePrezime.Size = new Size(0, 47);
            lblImePrezime.TabIndex = 10;
            // 
            // frmPolozeniPredmeti
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblImePrezime);
            Controls.Add(lblBrojIndeksa);
            Controls.Add(pbSlika);
            Controls.Add(btnSpasi);
            Controls.Add(label3);
            Controls.Add(dtpDatumPolaganja);
            Controls.Add(label2);
            Controls.Add(cmbOcjena);
            Controls.Add(label1);
            Controls.Add(cmbPredmet);
            Controls.Add(dgvPolozeniPredmeti);
            Name = "frmPolozeniPredmeti";
            Text = "frmPolozeniPredmeti";
            Load += frmPolozeniPredmeti_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPolozeniPredmeti).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbSlika).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPolozeniPredmeti;
        private DataGridViewTextBoxColumn Predmet;
        private DataGridViewTextBoxColumn DatumPolaganja;
        private DataGridViewTextBoxColumn Ocjena;
        private ComboBox cmbPredmet;
        private Label label1;
        private ComboBox cmbOcjena;
        private Label label2;
        private DateTimePicker dtpDatumPolaganja;
        private Label label3;
        private Button btnSpasi;
        private ErrorProvider errorProvider1;
        private PictureBox pbSlika;
        private Label lblBrojIndeksa;
        private Label lblImePrezime;
    }
}