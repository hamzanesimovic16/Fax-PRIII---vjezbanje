using FITData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FITFormsNew.Predavanje_7
{
    public partial class frmNoviStudent : Form
    {
        public frmNoviStudent()
        {
            InitializeComponent();


        }

        private void UcitajSemestre()
        {
            comboBox1.DataSource = InMemoryDb.Semestri;
            comboBox1.DisplayMember = "Oznaka";
            comboBox1.ValueMember = "Id";

        }

        private void btnSlika_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbSlika.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }


        private void frmNoviStudent_Load(object sender, EventArgs e)
        {
            UcitajSemestre();
            GenerisiIndeks();
            GenerisiLozinku();
        }

        private void GenerisiLozinku()
        {
            txtLozinka.Text = Generator.generisiLozinku();
        }

        private void GenerisiIndeks()
        {
            txtIndeks.Text = Generator.GenIndeks();
        }

        private void txtIme_TextChanged(object sender, EventArgs e)
        {
            GenerisiPodatke();
        }

        private void GenerisiPodatke()
        {
            GenerisiEmail();
        }

        private void GenerisiEmail()
        {
            var ime = txtIme.Text.ToLower();
            var prezime = txtPrezime.Text.ToLower();

            txtEmail.Text = Generator.GenEmail(ime, prezime);
        }

        private void txtPrezime_TextChanged(object sender, EventArgs e)
        {
            GenerisiPodatke();
        }

        private void btnNovaLozinka_Click(object sender, EventArgs e)
        {
            GenerisiLozinku();
        }

        private void btnSpasi_Click(object sender, EventArgs e)
        {
            if (ValidanUnos())
            {
                var student = new Student()
                {
                    Aktivan = cbAktivan.Checked,
                    Semestar = (int)comboBox1.SelectedValue,
                    Slika = pbSlika.Image,
                    DatumRodjenja = dtpDatumRodjenja.Value,
                    Id = InMemoryDb.Studenti.Count + 1,
                    Ime = txtIme.Text,
                    Prezime = txtPrezime.Text,
                    Indeks = txtIndeks.Text,
                    Lozinka = txtLozinka.Text
                };
                InMemoryDb.Studenti.Add(student);

                this.DialogResult = DialogResult.OK;
                Close();

            }
        }

        private bool ValidanUnos()
        {
            return 
                Validator.Validiraj(pbSlika, errorProvider1, "Obavezna vrijednost") &&
                Validator.Validiraj(txtIme, errorProvider1, "Obavezna vrijednost") &&
                Validator.Validiraj(txtPrezime, errorProvider1, "Obavezna vrijednost") &&
                Validator.Validiraj(comboBox1, errorProvider1, "Obavezna vrijednost");
        }
    }
}
