using FITData;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FITFormsNew.Izvjestaji
{
    public partial class frmIzvjestaj : Form
    {
        private dtoPrint dtoObjekat;

        

        public frmIzvjestaj(dtoPrint dtoObjekat)
        {
            InitializeComponent();
            this.dtoObjekat = dtoObjekat;
        }

        private void frmIzvjestaj_Load(object sender, EventArgs e)
        {
            var rpc = new ReportParameterCollection() {
                new ReportParameter("pBrojDokumenta","220-43/76"),
                new ReportParameter("pImePrezime",dtoObjekat.ImePrezime),
                new ReportParameter("pBrojIndeksa",dtoObjekat.BrojIndeksa),
                new ReportParameter("pStatus","REDOVAN"),
                new ReportParameter("pAkademskaGodina","2023/2024"),
                new ReportParameter("pSvrha", "Regulisanje stipendije")
            
            };


            //var polozeni = new dsDLWMS.PolozeniPredmetiDataTable();

            //for(int i = 0; i < 10; i++) {
            //    var red = polozeni.NewPolozeniPredmetiRow();

            //    red.Br=(i+1).ToString();
            //    red.NazivPredmeta = $"Polozeni predmet{i + 1}";
            //    red.DatumPolaganja = DateTime.Now.ToString("d");
            //    red.Ocjena = "6";

            //    polozeni.AddPolozeniPredmetiRow(red);
            //}

            var polozeni = new dsDLWMS.PolozeniPredmetiDataTable();

            for (int i = 0; i < dtoObjekat.PolozeniPredmeti.Count(); i++)
            {
                var red = polozeni.NewPolozeniPredmetiRow();

                red.Br = (i + 1).ToString();
                red.NazivPredmeta = dtoObjekat.PolozeniPredmeti[i].Predmet.Naziv;
                red.DatumPolaganja = dtoObjekat.PolozeniPredmeti[i].DatumPolaganja.ToString("d");
                red.Ocjena = dtoObjekat.PolozeniPredmeti[i].Ocjena.ToString();

                polozeni.AddPolozeniPredmetiRow(red);
            }



            var rds =new ReportDataSource();
            rds.Value = polozeni;
            rds.Name = "dsPolozeniPredmeti";


            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.SetParameters(rpc);
            reportViewer1.RefreshReport();
        }
    }
}
