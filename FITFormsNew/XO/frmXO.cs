using System.Media;

namespace FITFormsNew
{
    public partial class frmXO : Form
    {
        public string ime1;
        public string ime2;
        public frmXO()
        {
            InitializeComponent();



            brojac = 0;
        }

        public int brojac { get; set; }
        private void btn_Click(object sender, EventArgs e)
        {


            var dugme = sender as Button;


            if (dugme.Text == "")
            {

                if (brojac % 2 == 0)
                {
                    dugme.Text = "X";
                }
                else
                {
                    dugme.Text = "O";
                }

                if (KrajIgre())
                {
                    string pobjednik = (brojac % 2 == 0) ? ime1 : ime2;
                    MessageBox.Show($"Pobjeda igraca {pobjednik}");
                    PostaviStanje(false);
                    return;
                }
                brojac++;
                lblPlayersName.Text = (brojac % 2 == 0)? ime1:ime2;
                if (brojac % 2 == 0)
                {
                    lblPlayersName.Text += " X";
                }
                else
                {
                    lblPlayersName.Text += " O";
                }
            }
            else
            {
                SystemSounds.Beep.Play();
            }

        }

        private void generisiPocetak()
        {
            this.Hide();
            PostaviStanje(true, true, true);
            var prijava = new frmPrijava();
            prijava.ShowDialog();
            if (string.IsNullOrEmpty(prijava.Igrac1))
                Close();
            else
                Show();

            lblPlayersName.Text = prijava.Igrac1+" X";

            ime1=prijava.Igrac1;
            
            ime2= prijava.Igrac2;
        }

        private void frmXO_Load(object sender, EventArgs e)
        {
            
            generisiPocetak();
            this.Text = $"FITXO| {ime1} X i {ime2} O";
        }


        private bool Provjera(Button btn1, Button btn2, Button btn3)
        {
            var pobjeda = btn1.Text != "" && btn1.Text == btn2.Text && btn1.Text == btn3.Text;
            if (pobjeda)
                btn1.BackColor = btn2.BackColor = btn3.BackColor = Color.DeepPink;
            return pobjeda;
        }

        private bool ProvjeraRedova()
        {
            return Provjera(btn1, btn2, btn3) ||
                Provjera(button4, button5, button6) ||
                Provjera(button7, button8, button9);

        }

        private bool ProvjeraKolona()
        {
            return Provjera(btn1, button4, button7) ||
                Provjera(btn2, button5, button8) ||
                Provjera(btn3, button6, button9);

        }

        private bool ProvjeraDijagonala()
        {
            return Provjera(btn1, button5, button9) ||
                Provjera(btn3, button5, button7);

        }

        private bool KrajIgre()
        {
            return ProvjeraRedova() || ProvjeraKolona() || ProvjeraDijagonala();
        }

        private void PostaviStanje(bool omogucen, bool obrisiBoje = false, bool obrisiStanje = false)
        {
            lblPlayersName.Text = "";
            foreach (var kontrola in Controls)
            {
                if (kontrola is Button)
                {
                    var dugme = kontrola as Button;

                    if (dugme == btnReset)
                        continue;

                    dugme.Enabled = omogucen;

                    if (obrisiBoje)
                        dugme.UseVisualStyleBackColor = true;
                    if (obrisiStanje)
                        dugme.Text = "";
                }

            }
            brojac = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            generisiPocetak();
        }
    }
}