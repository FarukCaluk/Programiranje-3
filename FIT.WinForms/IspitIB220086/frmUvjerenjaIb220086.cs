using FIT.Data;
using FIT.Data.IspitIB220086;
using FIT.Infrastructure;
using FIT.WinForms.Izvjestaji;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIT.WinForms.IspitIB220086
{
    public partial class frmUvjerenjaIb220086 : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        private Student kliknut;
        List<StudentiUvjerenjaIB220086> podaciuvjerenja = new List<StudentiUvjerenjaIB220086>();

        public frmUvjerenjaIb220086()
        {
            InitializeComponent();
        }

        public frmUvjerenjaIb220086(Student kliknut)
        {
            this.kliknut = kliknut;
            InitializeComponent();
            ucitajUvjerenje();
        }

        private void ucitajUvjerenje()
        {
            podaciuvjerenja = db.StudentiUvjerenjaIB220086.Where(x => x.StudentId == kliknut.Id).ToList();
            dgvuvjerenje.AutoGenerateColumns = false;
            dgvuvjerenje.DataSource = podaciuvjerenja;
            this.Text = "Broj uvjerenja->" + podaciuvjerenja.Count();
        }

        private void dgvuvjerenje_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvuvjerenje.Columns[e.ColumnIndex].Name == "brisi")
            {
                var kliknutoUvjerenje = podaciuvjerenja[e.RowIndex];

                DialogResult odabir = MessageBox.Show("Jeste li sigurni da zelite brisati uvjerenje?", "Upozorenje!", MessageBoxButtons.YesNo);
                if (odabir == DialogResult.Yes)
                {
                    db.StudentiUvjerenjaIB220086.Remove(kliknutoUvjerenje);
                    db.SaveChanges();
                    ucitajUvjerenje();

                }
                else if (odabir == DialogResult.No)
                {
                    MessageBox.Show("Uvjerenje nije obrisano");
                }
            }
            else if (dgvuvjerenje.Columns[e.ColumnIndex].Name == "printaj")
            {
                var kliknutoUvjerenje = podaciuvjerenja[e.RowIndex];
                var izvjestaj = new frmIzvjestaji(kliknut, kliknutoUvjerenje);
                izvjestaj.ShowDialog();
                if (kliknutoUvjerenje.Printano == 0)
                {
                    kliknutoUvjerenje.Printano = 1;
                    db.Entry(kliknutoUvjerenje).State = EntityState.Modified;
                    db.SaveChanges();
                }
                ucitajUvjerenje();
            }
        }

        private void btzahtjev_Click(object sender, EventArgs e)
        {
            var novaForma = new frmNovoUvjerenjeIB220086(kliknut);
            if (DialogResult.OK == novaForma.ShowDialog())
            {
                ucitajUvjerenje();
            }
        }

        private void btdodaj_Click(object sender, EventArgs e)
        {
            if (jeValidno())
            {
                    
                var vrsta=cbvrsta.Text;
                var svrha=tbsvrha.Text;
                var broj = int.Parse(tbbroj.Text);
                Thread thread = new Thread(() => provjera(vrsta, svrha, broj));
                thread.Start(); 
            }

        }

        private void provjera(string vrsta, string svrha, int broj)
        {
            var tekst = "";
            
            for (int i = 0;i<broj;i++)
            {
                var novoUvjerenje = new StudentiUvjerenjaIB220086()
                {
                    StudentId = kliknut.Id,
                    DatumVrijeme = DateTime.Now.ToString(),
                    Vrsta = vrsta,
                    Svrha = svrha,
                    Uplatnica = podaciuvjerenja[0].Uplatnica,
                    Printano = 0
                };
                db.StudentiUvjerenjaIB220086.Add(novoUvjerenje);
                db.SaveChanges();
                tekst += $"{DateTime.Now.ToString("HH:mm:ss")}-> {vrsta} {kliknut.Indeks} {kliknut.ToString()} {svrha}{Environment.NewLine}";
            }
            Action action = () => 
            {
                tbinfo.Text = tekst;
                ucitajUvjerenje();
            };
            BeginInvoke(action);
        }

        private bool jeValidno()
        {
            return Helpers.Validator.ProvjeriUnos(tbbroj, err, Kljucevi.ReqiredValue) &&
                Helpers.Validator.ProvjeriUnos(tbsvrha, err, Kljucevi.ReqiredValue) &&
                Helpers.Validator.ProvjeriUnos(cbvrsta, err, Kljucevi.ReqiredValue);

        }
    }
}
