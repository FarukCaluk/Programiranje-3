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
    public partial class frmStudentInfoIB220086 : Form
    {
        DLWMSDbContext db=new DLWMSDbContext();
        private Student kliknuti;

        public frmStudentInfoIB220086()
        {
            InitializeComponent();        
        }

        public frmStudentInfoIB220086(Student kliknuti)
        {
            this.kliknuti = kliknuti;
            InitializeComponent();
             pbstudenta.Image=Helpers.Ekstenzije.ToImage(kliknuti.Slika);   
            imeprezime.Text=kliknuti.ToString();
            List<PolozeniPredmetiIB220086>podaci=db.PolozeniPredmeti.Where(x=>x.StudentId==kliknuti.Id).ToList();
            prosjek.Text=podaci.Count() == 0 ? "5" : podaci.Average(x=>x.Ocjena).ToString();
        }
    }
}
