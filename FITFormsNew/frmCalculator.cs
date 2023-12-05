using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FITFormsNew
{
    public partial class frmCalculator : Form
    {

        private enum Operacije
        {
            Sabiranje,
            Oduzimanje,
            Mnozenje,
            Dijeljenje
        }

        private Operacije prijasnjaOperacija;
        private double Buffer { get; set; }

        public frmCalculator()
        {
            InitializeComponent();
            Buffer = 0;
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                var dugme = sender as Button;

                if (string.IsNullOrEmpty(txtPrikaz.Text) && dugme.Text == ".")
                {
                    txtPrikaz.Text += "0.";

                }

                else if (string.IsNullOrEmpty(txtPrikaz.Text) && dugme.Text == "0")
                {
                    return;
                }

                else if (txtPrikaz.Text.Length == 15)
                    return;

                else
                {
                    if (dugme.Text == "." && txtPrikaz.Text.Contains("."))
                    {
                        return;
                    }

                    txtPrikaz.Text += dugme.Text;

                }

            }
        }

        private void frmCalculator_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtPrikaz.Text = "";
            lblBuffer.Text = "";
            Buffer = 0;
        }

        private void btnPM_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtPrikaz.Text))
            {
                return;
            }

            var temp = double.Parse(txtPrikaz.Text);

            temp = temp * -1;

            txtPrikaz.Text = temp.ToString();


        }

        private void btnBrisanje_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPrikaz.Text))
            {
                return;
            }

            var temp = txtPrikaz.Text;
            temp = temp.Remove(temp.Length - 1);


            txtPrikaz.Text = temp;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            IzvrsiOperaciju();
            prijasnjaOperacija = Operacije.Sabiranje;
        }


        private void IzvrsiOperaciju()
        {
            if (string.IsNullOrEmpty(txtPrikaz.Text))
            {
                return;
            }

            if (Buffer == 0)
            {
                Buffer = double.Parse(txtPrikaz.Text);
                lblBuffer.Text = Buffer.ToString();
                txtPrikaz.Text = "";
                return;
            }

            switch (prijasnjaOperacija)
            {
                case Operacije.Sabiranje:
                    Buffer += double.Parse(txtPrikaz.Text);
                    break;

                case Operacije.Oduzimanje:
                    Buffer -= double.Parse(txtPrikaz.Text);
                    break;

                case Operacije.Mnozenje:
                    Buffer *= double.Parse(txtPrikaz.Text);
                    break;

                case Operacije.Dijeljenje:
                    Buffer /= double.Parse(txtPrikaz.Text);
                    break;

                default:
                    return;
            }

            lblBuffer.Text = Buffer.ToString();
            txtPrikaz.Text = "";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            IzvrsiOperaciju();
            prijasnjaOperacija = Operacije.Oduzimanje;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            IzvrsiOperaciju();
            prijasnjaOperacija = Operacije.Mnozenje;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            IzvrsiOperaciju();
            prijasnjaOperacija = Operacije.Dijeljenje;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            IzvrsiOperaciju();
            
            txtPrikaz.Text=Buffer.ToString();
           Buffer= 0;
            lblBuffer.Text = "";
        }
    }
}


