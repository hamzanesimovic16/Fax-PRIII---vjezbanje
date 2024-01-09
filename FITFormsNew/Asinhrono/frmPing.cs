using FITData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FITFormsNew.Asinhrono
{
    public partial class frmPing : Form
    {
        public frmPing()
        {
            InitializeComponent();
        }
        public string Sadrzaj { get; set; }

        DLWMSDbContext db=new DLWMSDbContext();
        private async void btnPing_Click(object sender, EventArgs e)
        {
            Thread noviThread = new Thread(() => { Ping(new dtoPing() { Lokacija = "www.olx.ba", BrojPonavljanja = 20, Sleep = 200 }); }) ;
            //Thread Google=new Thread(PingGoogle);
            Thread DrugiThread = new Thread(() => { UcitajStudenta(); });
            //Olx.Start();
            //Google.Start();

            //await Task.Run(() => { UcitajStudenta(); });
            TestMetoda();
            Task.Run(() => { Ping(new dtoPing() { Lokacija = "www.olx.ba", BrojPonavljanja = 20, Sleep = 200 }); });

            //noviThread.Start();
            //DrugiThread.Start();

            //Olx.Join();
            //Google.Join();

            //PingOlx();
            //PingGoogle();
            PrikaziSadrzaj();
            
        }


        private void UcitajStudenta()
        {
            try
            {
                var slika = db.Studenti.Find(5).Slika;
                for (int i = 0; i < 50; i++)
                {
                    var noviStudent = new Student() {
                        Aktivan=true,
                        DatumRodjenja=DateTime.Now,
                        Ime=$"Ime {i}",
                        Prezime= $"Prezime {i}",
                        Indeks=Generator.GenIndeks(),
                        Slika=slika,
                        SemestarId=1,
                        Lozinka=Generator.generisiLozinku(),
                        
                    };
                    db.Studenti.Add(noviStudent);
                    Sadrzaj += $"Dodan student {i} {Environment.NewLine}";
                    BeginInvoke(PrikaziSadrzaj);
                    Thread.Sleep(200);

                }
                db.SaveChanges();
                
            }
            catch(Exception ex) {
                Sadrzaj += ex.Message;
            }
        }

        private async void TestMetoda()
        {
            await Task.Run(() => { Ping(new dtoPing() { BrojPonavljanja = 15, Lokacija = "www.facebook.com", Sleep = 200 }); }) ;
            //Task.Run(() => { UcitajStudenta(); });
            //UcitajStudenta();
            MessageBox.Show("Zavrsena test metoda");
        }
        private void Ping(dtoPing obj)
        {
            try
            {

                var ping = new Ping();

                for (int i = 0; i < obj.BrojPonavljanja; i++)
                {
                    var reply = ping.Send(obj.Lokacija);
                    Sadrzaj += PingResToString(reply);
                    BeginInvoke(PrikaziSadrzaj);
                    Thread.Sleep(obj.Sleep);
                }


            }


            catch (Exception err)
            {
                Sadrzaj += err.Message;
            }


        }

        private void PrikaziSadrzaj()
        {

            txtLog.Text = Sadrzaj;
            PomjeriNaKraj();
        }

        private void PomjeriNaKraj()
        {
            txtLog.SelectionStart = txtLog.TextLength;
            txtLog.ScrollToCaret();
        }

        private void PingGoogle()
        {
            try
            {

                var ping = new Ping();

                for (int i = 0; i < 10; i++)
                {
                    var reply = ping.Send("www.google.com");
                    Sadrzaj+= PingResToString(reply);
                    BeginInvoke(PrikaziSadrzaj);
                    Thread.Sleep(200);
                }


            }


            catch (Exception err)
            {
                Sadrzaj += err.Message;
            }


        }

        private string PingResToString(PingReply reply)
        {
            return $"{reply.Address} \t {reply.RoundtripTime} {Environment.NewLine} ";
        }

        private void PingOlx()
        {
            try
            {

                var ping = new Ping();

                for (int i = 0; i < 10; i++)
                {
                    var reply = ping.Send("olx.ba");
                    Sadrzaj += PingResToString(reply);
                    BeginInvoke(PrikaziSadrzaj);
                    Thread.Sleep(200);
                }


            }


            catch (Exception err)
            {
                Sadrzaj += err.Message;
            }
        }
    }


    class dtoPing
    {
        public string Lokacija { get; set; }
        public int BrojPonavljanja { get; set; }
        public int Sleep { get; set; }
    }
}
