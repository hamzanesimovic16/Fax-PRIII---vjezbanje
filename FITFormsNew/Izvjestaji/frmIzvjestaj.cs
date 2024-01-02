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
        public frmIzvjestaj()
        {
            InitializeComponent();
        }

        private void frmIzvjestaj_Load(object sender, EventArgs e)
        {
            var rpc = new ReportParameterCollection() {
                new ReportParameter("pBrojDokumenta","220-43/76"),
                new ReportParameter("pImePrezime","Almedin Dzinic"),
                new ReportParameter("pBrojIndeksa","IB220250"),
                new ReportParameter("pStatus","REDOVAN"),
                new ReportParameter("pAkademskaGodina","2023/2024"),
                new ReportParameter("pSvrha", "Regulisanje stipendije")
            
            };


            reportViewer1.LocalReport.SetParameters(rpc);
            reportViewer1.RefreshReport();
        }
    }
}
