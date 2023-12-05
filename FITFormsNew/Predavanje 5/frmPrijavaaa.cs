using FITData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace FITFormsNew.Predavanje_5
{
    public partial class frmPrijavaaa : Form
    {
        public frmPrijavaaa()
        {
            InitializeComponent();
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            var ime = txtKorisnickoIme.Text;
            var sifra = txtSifra.Text;

            if (ValidanUslov())
            {
                foreach (var korisnik in InMemoryDb.Korisnici)
                {
                    if (korisnik.KorisnickoIme == ime && korisnik.Lozinka == sifra)
                    {
                        if (korisnik.Aktivan)
                        {
                            MessageBox.Show(Resursi.Get(Kljucevi.Welcome) + " " + korisnik.Ime);

                        }
                        else
                            MessageBox.Show(Resursi.Get(Kljucevi.AccountNotActive),
                                "Greska", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);


                        return;

                    }


                }
                MessageBox.Show("Korisnicko ime ili password nisu tacni");
            }
        }

        private bool ValidanUslov()
        {
            return Validator.Validiraj(txtKorisnickoIme, err, "Obavezna vrijednost") &&
                 Validator.Validiraj(txtSifra, err, "Obavezna vrijednost");

        }


        public class Validator
        {
            public static bool Validiraj(TextBox box, ErrorProvider err, string poruka)
            {
                if(!box.Text.IsSet())
                {
                    err.SetError(box, poruka);
                    return false;
                }
                err.Clear();
                return true;
            }
        }
    }
}
