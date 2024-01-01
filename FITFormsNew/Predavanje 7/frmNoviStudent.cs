using FITData;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
        DLWMSDbContext db = new DLWMSDbContext();

        public Student _student;
        public frmNoviStudent(Student student = null)
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            _student = student ?? new Student();
        }

        private void UcitajSemestre()
        {
            comboBox1.UcitajPodatke(db.Semestri.ToList(), "Id", "Oznaka");

            //comboBox1.DataSource = InMemoryDb.Semestri;
            //comboBox1.DisplayMember = "Oznaka";
            //comboBox1.ValueMember = "Id";

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
            UcitajUloge();

            if (_student.Id != 0)
            {
                UcitajPodatke();
            }
            else
            {
                GenerisiIndeks();
                GenerisiLozinku();
            }

        }

        private void UcitajUloge()
        {
            cmbUloge.DataSource = null;
            cmbUloge.DataSource = db.Uloge.ToList();

            clbUloge.Items.AddRange(db.Uloge.ToArray());


        }

        private void UcitajPodatke()
        {
            pbSlika.Image = _student.Slika.UcitajSliku();
            txtIme.Text = _student.Ime;
            txtPrezime.Text = _student.Prezime;
            comboBox1.SelectedValue = _student.SemestarId;
            txtLozinka.Text = _student.Lozinka;
            txtIndeks.Text = _student.Indeks;
            cbAktivan.Checked = _student.Aktivan;
            UcitajUlogeStudenta();
        }

        private void UcitajUlogeStudenta()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = _student.Uloga;

            List<int> indeksiZaCheckListu = new List<int>();

            foreach (var uloga in _student.Uloga)
            {
                indeksiZaCheckListu.Add(uloga.Id);
            }

            foreach (var indeks in indeksiZaCheckListu)
            {
                clbUloge.SetItemChecked(indeks - 1, true);
            }

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

                _student.Aktivan = cbAktivan.Checked;
                _student.SemestarId = (int)comboBox1.SelectedValue;
                _student.Slika = pbSlika.Image.PrebaciUBajtove();
                _student.DatumRodjenja = dtpDatumRodjenja.Value;
                _student.Ime = txtIme.Text;
                _student.Prezime = txtPrezime.Text;
                _student.Indeks = txtIndeks.Text;
                _student.Lozinka = txtLozinka.Text;



                if (_student.Id == 0)
                {
                    //_student.Id = InMemoryDb.Studenti.Count + 1;  nije vise potrenbo jer je Id u bazi auto increment
                    db.Studenti.Add(_student);

                }
                else
                {
                    db.Entry(_student).State = EntityState.Modified;
                }
                db.SaveChanges();

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

        private void btnOdaberiUlogu_Click(object sender, EventArgs e)
        {
            var uloga = cmbUloge.SelectedItem as Uloga;

            if (_student.Uloga.Where(u => u.Id == uloga.Id).Count() > 0)
            {
                MessageBox.Show("Uloga je vec unesena", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            _student.Uloga.Add(uloga);
            UcitajUlogeStudenta();
        }
    }
}
