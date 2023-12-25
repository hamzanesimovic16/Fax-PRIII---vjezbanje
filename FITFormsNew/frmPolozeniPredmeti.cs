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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace FITFormsNew
{
    public partial class frmPolozeniPredmeti : Form
    {
        private Student? odabraniStudent;

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
            pbSlika.Image = odabraniStudent.Slika;
        }

        private void UcitajPredmete()
        {
            cmbPredmet.UcitajPodatke(InMemoryDb.Predmeti);
        }

        private void UcitajPolozenePredmete()
        {
            dgvPolozeniPredmeti.DataSource = null;
            dgvPolozeniPredmeti.DataSource = odabraniStudent.PolozeniPredmeti;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSpasi_Click(object sender, EventArgs e)
        {
            if (ValidanUnos())
            {
                var predmet = cmbPredmet.SelectedItem as Predmet;
                var ponovljenUnos = odabraniStudent.PolozeniPredmeti.Where(p => p.PredmetId == predmet.Id).Count() > 0;

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
                polozeniPredmet.Id = odabraniStudent.PolozeniPredmeti.Count() + 1;

                odabraniStudent.PolozeniPredmeti.Add(polozeniPredmet);
                UcitajPolozenePredmete();

            }
        }

        private bool ValidanUnos()
        {

            return
                Validator.Validiraj(cmbPredmet, errorProvider1, Resursi.Get(Kljucevi.RequiredValue)) &&
                Validator.Validiraj(cmbOcjena, errorProvider1, Resursi.Get(Kljucevi.RequiredValue));
        }
    }
}
