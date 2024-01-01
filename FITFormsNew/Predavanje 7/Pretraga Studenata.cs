using FITData;
using Microsoft.EntityFrameworkCore;
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
    public partial class frmPretragaStudenata : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();

        public frmPretragaStudenata()
        {
            InitializeComponent();
            dgvStudenti.AutoGenerateColumns = false;

        }

        private void frmPretragaStudenata_Load(object sender, EventArgs e)
        {
            UcitajStudente();
        }

        private void UcitajStudente(List<Student> studenti = null)
        {
            var lista = db.Studenti.Include(s => s.Semestar).Include(t => t.Uloga).ToList();

            dgvStudenti.DataSource = null;
            dgvStudenti.DataSource = studenti ?? lista;
        }

        private void btnNoviStudent_Click(object sender, EventArgs e)
        {
            frmNoviStudent frmNoviStudent = new frmNoviStudent();
            if (frmNoviStudent.ShowDialog() == DialogResult.OK)
            {
                UcitajStudente();
            }
        }

        private void dgvStudenti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            var odabraniStudent = dgvStudenti.SelectedRows[0].DataBoundItem as Student;


            Form forma = null;
            if (dgvStudenti.CurrentCell is DataGridViewButtonCell)
                forma = new frmPolozeniPredmeti(odabraniStudent);
            else
                forma = new frmNoviStudent(odabraniStudent);

            forma.ShowDialog();

            UcitajStudente();
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            var rezultat = db.Studenti.Where(Filtriraj).ToList();

            UcitajStudente(rezultat);
        }

        private bool Filtriraj(Student student)
        {
            var text = txtFilter.Text.ToLower();

            return student.Ime.ToLower().Contains(text) ||
                   student.Prezime.ToLower().Contains(text) ||
                   student.Indeks.ToLower().Contains(text);
        }
    }
}
