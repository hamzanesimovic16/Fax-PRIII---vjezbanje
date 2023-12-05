using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FITFormsNew
{
    public partial class frmPrijava : Form
    {
        public frmPrijava()
        {
            InitializeComponent();
        }


        public string Igrac1 { get; set; }
        public string Igrac2 { get; set; }



        private void btnPokreni_Click_1(object sender, EventArgs e)
        {
            if (txtIgrac1.Text != "" && txtIgrac2.Text != "")
            {
                Igrac1 = txtIgrac1.Text;
                Igrac2 = txtIgrac2.Text;
                Close();




            }
            else
            {
                SystemSounds.Beep.Play();
            }
        }
    }
}
