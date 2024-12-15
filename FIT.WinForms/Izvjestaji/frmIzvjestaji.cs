using FIT.Data;
using FIT.Data.IspitIB220086;
using FIT.Infrastructure;
using Microsoft.Reporting.WinForms;

namespace FIT.WinForms.Izvjestaji
{
    public partial class frmIzvjestaji : Form
    {
        private Student kliknut;
        private StudentiUvjerenjaIB220086 kliknutoUvjerenje;

        DLWMSDbContext db = new DLWMSDbContext();
        public frmIzvjestaji()
        {
            InitializeComponent();
        }

        public frmIzvjestaji(Student kliknut, StudentiUvjerenjaIB220086 kliknutoUvjerenje)
        {
            InitializeComponent();
            this.kliknut = kliknut;
            this.kliknutoUvjerenje = kliknutoUvjerenje;
        }

        private void frmIzvjestaji_Load(object sender, EventArgs e)
        {
            var rpc = new ReportParameterCollection();
            var status = kliknut.Aktivan == true ? "AKTIVAN" : "NEAKTIVAN";
            var broj = db.PolozeniPredmeti.Count(x => x.StudentId == kliknut.Id).ToString();
            var ocjena = db.PolozeniPredmeti.Where(x => x.StudentId == kliknut.Id).ToList();
            var prosjek = ocjena.Count() == 0 ? "5" : ocjena.Average(x => x.Ocjena).ToString();
            var Predmtinovi=db.PolozeniPredmeti.Where(x=>x.StudentId == kliknut.Id).Join(db.Predmeti,pp=>pp.PredmetId,p=>p.Id,(pp,p)=>new {NaziviPredmeta=p.Naziv,ocjenaPredmeta=pp.Ocjena}).ToList();
            var listaPredmeta=Predmtinovi.Count()==0? "Nema polozeni predmeta": string.Join(", ", Predmtinovi.Select(x =>$"{x.NaziviPredmeta} ({x.ocjenaPredmeta})")); 

            rpc.Add(new ReportParameter("svrha", kliknutoUvjerenje.Svrha));
            rpc.Add(new ReportParameter("imeStudenta", kliknut.ToString()));
            rpc.Add(new ReportParameter("index", kliknut.Indeks));
            rpc.Add(new ReportParameter("aktivan", status));
            rpc.Add(new ReportParameter("brojiIspita", broj));
            rpc.Add(new ReportParameter("prosjek", prosjek));
            rpc.Add(new ReportParameter("predmeti", listaPredmeta));
            reportViewer1.LocalReport.SetParameters(rpc);
            reportViewer1.RefreshReport();

        }
    }
}
