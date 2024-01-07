using FITData;
using FITFormsNew.Izvjestaji;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace FITFormsNew
{
    public partial class frmPolozeniPredmeti : Form
    {
        private Student? odabraniStudent;

        DLWMSDbContext db = new DLWMSDbContext();

        public frmPolozeniPredmeti(Student odabraniStudent)
        {
            InitializeComponent();
            this.odabraniStudent = odabraniStudent;

            dgvPolozeniPredmeti.AutoGenerateColumns = false;
        }

        private void dgvPolozeniPredmeti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmPolozeniPredmeti_Load(object sender, EventArgs e)
        {
            UcitajPolozenePredmete();
            UcitajPredmete();
            UcitajLicnePodatke();
        }

        private void UcitajLicnePodatke()
        {
            lblBrojIndeksa.Text = odabraniStudent.Indeks;
            lblImePrezime.Text = $"{odabraniStudent.Ime} {odabraniStudent.Prezime}";
            pbSlika.Image = odabraniStudent.Slika.UcitajSliku();
        }

        private void UcitajPredmete()
        {
            cmbPredmet.UcitajPodatke(db.Predmeti.ToList());
        }

        private void UcitajPolozenePredmete()
        {
            dgvPolozeniPredmeti.DataSource = null;
            dgvPolozeniPredmeti.DataSource = db.PolozeniPredmeti.Where(s => s.StudentId == odabraniStudent.Id).ToList();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSpasi_Click(object sender, EventArgs e)
        {
            if (ValidanUnos())
            {
                var predmet = cmbPredmet.SelectedItem as Predmet;
                var ponovljenUnos = db.PolozeniPredmeti.Where(p => p.StudentId == odabraniStudent.Id && predmet.Id == p.PredmetId).Count() > 0;

                if (ponovljenUnos)
                {
                    MessageBox.Show($"{Resursi.Get(Kljucevi.DuplicatedCourse)}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var polozeniPredmet = new PolozeniPredmet();
                polozeniPredmet.Predmet = predmet;
                polozeniPredmet.PredmetId = predmet.Id;
                polozeniPredmet.Ocjena = int.Parse(cmbOcjena.Text);
                polozeniPredmet.DatumPolaganja = dtpDatumPolaganja.Value;
                polozeniPredmet.StudentId = odabraniStudent.Id;
                //polozeniPredmet.Id = odabraniStudent.PolozeniPredmeti.Count() + 1;

                //odabraniStudent.PolozeniPredmeti.Add(polozeniPredmet);

                db.PolozeniPredmeti.Add(polozeniPredmet);
                db.SaveChanges();
                UcitajPolozenePredmete();

            }
        }

        private bool ValidanUnos()
        {

            return
                Validator.Validiraj(cmbPredmet, errorProvider1, Resursi.Get(Kljucevi.RequiredValue)) &&
                Validator.Validiraj(cmbOcjena, errorProvider1, Resursi.Get(Kljucevi.RequiredValue));
        }

        private void btnPrintajUvjerenje_Click(object sender, EventArgs e)
        {
            var dtoObjekat = new dtoPrint()
            {
                ImePrezime = $"{odabraniStudent.Ime} {odabraniStudent.Prezime}",
                BrojIndeksa = odabraniStudent.Indeks,
                PolozeniPredmeti = dgvPolozeniPredmeti.DataSource as List<PolozeniPredmet>
            };

            var printForma = new frmIzvjestaj(dtoObjekat);
            printForma.ShowDialog();
        }
    }

    public class dtoPrint
    {
        public string ImePrezime { get; set; }
        public string BrojIndeksa { get; set; }

        public List<PolozeniPredmet> PolozeniPredmeti { get; set; }



    }
}
