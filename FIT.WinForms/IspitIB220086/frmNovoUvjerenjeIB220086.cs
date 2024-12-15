using FIT.Data;
using FIT.Data.IspitIB220086;
using FIT.Infrastructure;
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
    public partial class frmNovoUvjerenjeIB220086 : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        private Student kliknut;

        public frmNovoUvjerenjeIB220086()
        {
            InitializeComponent();
        }

        public frmNovoUvjerenjeIB220086(Student kliknut)
        {
            this.kliknut = kliknut;
            InitializeComponent();
        }

        private void btsacuvaj_Click(object sender, EventArgs e)
        {
            if (jeValidno())
            {
                var novoUvjerenje = new StudentiUvjerenjaIB220086()
                {
                    StudentId = kliknut.Id,
                    DatumVrijeme = DateTime.Now.ToString(),
                    Vrsta = cbvrsta.Text,
                    Svrha = rbsvrha.Text,
                    Uplatnica = Helpers.Ekstenzije.ToByteArray(pbUplatnica.Image),
                    Printano = 0
                };
                db.StudentiUvjerenjaIB220086.Add(novoUvjerenje);
                db.SaveChanges();
                DialogResult = DialogResult.OK;
            }

        }

        private bool jeValidno()
        {
            return Helpers.Validator.ProvjeriUnos(pbUplatnica, err, Kljucevi.ReqiredValue) &&
                Helpers.Validator.ProvjeriUnos(cbvrsta, err, Kljucevi.ReqiredValue) &&
                Helpers.Validator.ProvjeriUnos(rbsvrha, err, Kljucevi.ReqiredValue);

        }

        private void pbUplatnica_DoubleClick(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbUplatnica.Image=Image.FromFile(openFileDialog1.FileName); 
            }
        }
    }
}
