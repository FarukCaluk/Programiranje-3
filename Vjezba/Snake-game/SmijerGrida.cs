using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_game
{
    public class SmijerGrida
    {
        public readonly static SmijerGrida lijevo = new SmijerGrida(0, -1);
        public readonly static SmijerGrida desno = new SmijerGrida(0, 1);
        public readonly static SmijerGrida gore = new SmijerGrida(-1,0);
        public readonly static SmijerGrida dolje = new SmijerGrida(1,0);
        public int red {  get; set; }
        public int kol {  get; set; }

        private SmijerGrida(int redod,int kolod) 
        {
            red = redod;
            kol = kolod;
        }
        public SmijerGrida Opposite()
        {
            return new SmijerGrida(-red,-kol);
        }

        public override bool Equals(object? obj)
        {
            return obj is SmijerGrida grida &&
                   red == grida.red &&
                   kol == grida.kol;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(red, kol);
        }

        public static bool operator ==(SmijerGrida? left, SmijerGrida? right)
        {
            return EqualityComparer<SmijerGrida>.Default.Equals(left, right);
        }

        public static bool operator !=(SmijerGrida? left, SmijerGrida? right)
        {
            return !(left == right);
        }
    }
}
