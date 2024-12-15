using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT.Data.IspitIB220086
{
    public class StudentiUvjerenjaIB220086
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public string DatumVrijeme { get; set; }
        public string Vrsta { get; set; }
        public string Svrha { get; set; }
        public byte[] Uplatnica { get; set; }
        public int Printano { get; set; }
    }
}
