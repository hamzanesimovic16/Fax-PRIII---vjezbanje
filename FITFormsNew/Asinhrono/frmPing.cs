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
        private void btnPing_Click(object sender, EventArgs e)
        {
            Thread Olx=new Thread(PingOlx);
            Thread Google=new Thread(PingGoogle);

            Olx.Start();
            Google.Start();



            //Olx.Join();
            //Google.Join();

            //PingOlx();
            //PingGoogle();
            PrikaziSadrzaj();
            
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
}
