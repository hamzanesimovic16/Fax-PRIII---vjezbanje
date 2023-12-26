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

namespace FITFormsNew
{
    public partial class frmPredmetiIzBaze : Form
    {
        DLWMSDbContext baza = new DLWMSDbContext();
        public frmPredmetiIzBaze()
        {
            InitializeComponent();
            dgvPredmeti.AutoGenerateColumns = false;
        }

        private void frmPredmetiIzBaze_Load(object sender, EventArgs e)
        {
            UcitajPredmete();
        }

        private void UcitajPredmete()
        {
            dgvPredmeti.DataSource = null;
            dgvPredmeti.DataSource = baza.Predmeti.ToList();

        }

        private void btnSpasi_Click(object sender, EventArgs e)  //samo proba nije gotovo do kraja, validaciju treba dovrsiti
        {
            var noviPredmet=new Predmet() { Naziv=$"{txtNazivPredmeta.Text}", Semestar=int.Parse(cmbSemestar.Text)  };

            foreach (var predmet in baza.Predmeti.ToList())              
            {
                if((predmet as Predmet).Naziv==noviPredmet.Naziv)
                {
                    MessageBox.Show("Vec postoji");
                    return;
                }
            }


            baza.Predmeti.Add(noviPredmet);
            baza.SaveChanges();
            UcitajPredmete();

        }
    }
}
