using FIT.Data;
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
    public partial class frmPretragaIB220086 : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        List<Student> podaciStudent = new List<Student>();
        public frmPretragaIB220086()
        {
            InitializeComponent();
            dgvPretraga.AutoGenerateColumns = false;

            //comboBox1.SelectedIndex = 2;
            ucitajStudente();
        }

        private void ucitajStudente()
        {
            var spol = comboBox1.SelectedItem.ToString();
            var datumOD = dtpOD.Value;
            var dtaumDO = dtpDO.Value;
            if (comboBox1.SelectedItem == "Svi")
            {
                podaciStudent = db.Studenti.Where(x => x.DatumRodjenja > datumOD && x.DatumRodjenja < dtaumDO).ToList();
            }
            else
            {
                podaciStudent = db.Studenti.Where(x => x.DatumRodjenja > datumOD && x.DatumRodjenja < dtaumDO && x.Spol == spol).ToList();
            }
            //var srch = tbstc.Text.ToLower();

            //podaciStudent = db.Studenti.Where(x => x.Ime.ToLower().Contains(srch) || x.Prezime.ToLower().Contains(srch)).ToList();


            DataTable dt = new DataTable();
            dt.Columns.Add("brojindexa");
            dt.Columns.Add("imeprezime");
            dt.Columns.Add("prosjek");
            dt.Columns.Add("datumrođenja");
            dt.Columns.Add("aktivan");

            for (int i = 0; i < podaciStudent.Count; i++)
            {
                var red = dt.NewRow();
                var podaci = podaciStudent[i];
                var ocjena = db.PolozeniPredmeti.Where(x => x.StudentId == podaci.Id).ToList();

                red["brojindexa"] = podaci.Indeks;
                red["imeprezime"] = podaci.ToString();
                red["prosjek"] = ocjena.Count() == 0 ? 5 : ocjena.Average(x => x.Ocjena);
                red["datumrođenja"] = podaci.DatumRodjenja;
                red["aktivan"] = podaci.Aktivan;

                dt.Rows.Add(red);

            }
            dgvPretraga.DataSource = dt;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ucitajStudente();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            ucitajStudente();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            ucitajStudente();
        }

        private void dgvPretraga_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPretraga.Columns[e.ColumnIndex].Name == "uvjerenje")
            {
                var kliknut = podaciStudent[e.RowIndex];
                var uvjerenje = new frmUvjerenjaIb220086(kliknut);
                uvjerenje.Show();
            }
            else
            {
                var kliknuti = podaciStudent[e.RowIndex];
                var frmStudent = new frmStudentInfoIB220086(kliknuti);
                frmStudent.Show();
            }
        }

        
        private void tbstc_TextChanged(object sender, EventArgs e)
        {
            ucitajStudente();
        }
    }
}
