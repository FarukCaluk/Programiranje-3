using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;

namespace Snake_game
{
    public class StanjeIgre
    {
        public int Red { get; set; }
        public int Kol { get; set; }
        public Grid_vrijednost[,] Grid { get; }
        public SmijerGrida Smjer { get; private set; }
        public int Score { get; private set; }
        public bool GameOver { get; private set; }

        private readonly LinkedList<pozicija> pozicijaZmije = new LinkedList<pozicija>();
        private readonly Random random = new Random();

        public StanjeIgre(int red, int kol)
        {
            Red = red;
            Kol = kol;
            Grid = new Grid_vrijednost[red, kol];
            Smjer = SmijerGrida.desno;

            AddSnake();
            AddFood();
        }

        private void AddSnake()
        {
            int r = Red / 2;

            for (int c = 1; c <= 3; c++)
            {
                Grid[r, c] = Grid_vrijednost.Snake;
                pozicijaZmije.AddFirst(new pozicija(r, c));
            }
        }

        private IEnumerable<pozicija> PraznaMjesta()
        {
            for (int r = 0; r < Red; r++)
            {
                for (int c = 0; c < Kol; c++)
                {
                    if (Grid[r, c] == Grid_vrijednost.Empty)
                    { 
                        yield return new pozicija(r, c);
                    }
                }
            }
        }
        private void AddFood()
        {
            List<pozicija> empty= new List<pozicija>(PraznaMjesta());

            if(empty.Count == 0)
            {
                return;
            }
            pozicija pozicija = empty[random.Next(empty.Count)];
            Grid[pozicija.Red,pozicija.Kol]=Grid_vrijednost.Food;
        }

        public pozicija HeadPozicja()
        {
        
        }

    }
}
