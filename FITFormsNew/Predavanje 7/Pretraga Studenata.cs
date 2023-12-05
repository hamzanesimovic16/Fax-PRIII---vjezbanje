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
    public partial class frmPretragaStudenata : Form
    {
        public frmPretragaStudenata()
        {
            InitializeComponent();
            dgvStudenti.AutoGenerateColumns = false;
        }

        private void frmPretragaStudenata_Load(object sender, EventArgs e)
        {
            UcitajStudente();
        }

        private void UcitajStudente()
        {
            dgvStudenti.DataSource = null;
            dgvStudenti.DataSource = InMemoryDb.Studenti;
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

            frmNoviStudent formaIzmjena=new frmNoviStudent(odabraniStudent);
           
            if (formaIzmjena.ShowDialog() == DialogResult.OK)
                UcitajStudente();
        }
    }
}
