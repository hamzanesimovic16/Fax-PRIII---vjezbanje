namespace FITFormsNew
{
    partial class frmPredmetiIzBaze
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
            dgvPredmeti = new DataGridView();
            Naziv = new DataGridViewTextBoxColumn();
            Semestar = new DataGridViewTextBoxColumn();
            txtNazivPredmeta = new TextBox();
            cmbSemestar = new ComboBox();
            btnSpasi = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPredmeti).BeginInit();
            SuspendLayout();
            // 
            // dgvPredmeti
            // 
            dgvPredmeti.AllowUserToAddRows = false;
            dgvPredmeti.AllowUserToDeleteRows = false;
            dgvPredmeti.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPredmeti.Columns.AddRange(new DataGridViewColumn[] { Naziv, Semestar });
            dgvPredmeti.Location = new Point(12, 134);
            dgvPredmeti.Name = "dgvPredmeti";
            dgvPredmeti.ReadOnly = true;
            dgvPredmeti.RowTemplate.Height = 25;
            dgvPredmeti.Size = new Size(776, 304);
            dgvPredmeti.TabIndex = 0;
            // 
            // Naziv
            // 
            Naziv.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Naziv.DataPropertyName = "Naziv";
            Naziv.HeaderText = "Naziv";
            Naziv.Name = "Naziv";
            Naziv.ReadOnly = true;
            // 
            // Semestar
            // 
            Semestar.DataPropertyName = "Semestar";
            Semestar.HeaderText = "Semestar";
            Semestar.Name = "Semestar";
            Semestar.ReadOnly = true;
            // 
            // txtNazivPredmeta
            // 
            txtNazivPredmeta.Location = new Point(12, 105);
            txtNazivPredmeta.Name = "txtNazivPredmeta";
            txtNazivPredmeta.Size = new Size(198, 23);
            txtNazivPredmeta.TabIndex = 1;
            // 
            // cmbSemestar
            // 
            cmbSemestar.FormattingEnabled = true;
            cmbSemestar.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8" });
            cmbSemestar.Location = new Point(226, 105);
            cmbSemestar.Name = "cmbSemestar";
            cmbSemestar.Size = new Size(121, 23);
            cmbSemestar.TabIndex = 2;
            // 
            // btnSpasi
            // 
            btnSpasi.Location = new Point(365, 105);
            btnSpasi.Name = "btnSpasi";
            btnSpasi.Size = new Size(75, 23);
            btnSpasi.TabIndex = 3;
            btnSpasi.Text = "Spasi";
            btnSpasi.UseVisualStyleBackColor = true;
            btnSpasi.Click += btnSpasi_Click;
            // 
            // frmPredmetiIzBaze
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSpasi);
            Controls.Add(cmbSemestar);
            Controls.Add(txtNazivPredmeta);
            Controls.Add(dgvPredmeti);
            Name = "frmPredmetiIzBaze";
            Text = "frmPredmetiIzBaze";
            Load += frmPredmetiIzBaze_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPredmeti).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPredmeti;
        private DataGridViewTextBoxColumn Naziv;
        private DataGridViewTextBoxColumn Semestar;
        private TextBox txtNazivPredmeta;
        private ComboBox cmbSemestar;
        private Button btnSpasi;
    }
}