using Fit.consoleapp.Models;

namespace Fit.consoleapp.Nastava
{
    public class P1
    {
        public static void Pokreni()
        {
            //TipoviPodataka();
            //Pokazivaci();
            // klase();
            VrsteTipova();

        }

        private static void VrsteTipova()
        {
            int index1 = 0;//VALUE
            int index2 = new int();
            if (index1 == 230032)
                Console.WriteLine("Student Denis Music");
            if (index2 == 230032)
                Console.WriteLine("Student Denis Music");

            int a = 10;
            int b = a;
            //REFERENCE
            Predmet pr2_1 = new Predmet();
            Predmet pr2_2 = pr2_1;

            pr2_2.Semestar = 4;
        }

        private static void klase()
        {
            Predavanje pr3= new Predavanje(godina: 2,tema:"c# intro");
            pr3.Tema += " u WinForms";
            pr3.Godina = 1;



            Console.WriteLine($"{pr3.Tema} na {pr3.Godina} godini studija");
            Predmet pr2 = new Predmet()
            {
                Naziv = "programioranje 2",
                Semestar = 1
            };
        }

        private static void Pokazivaci()
        {
            int index = 220086;
            unsafe
            {
                int* pIndex = &index;
                *pIndex = 66;
            }
        }

        private static void TipoviPodataka()
        {
            int index = 220086;
            string naziv = "programiranje-3";
            bool aktivan = true;
            Console.WriteLine(index + " " + naziv + " " + aktivan);
            Console.WriteLine($"{index} je polozio {naziv} i student je aktivan {aktivan}");
        }
    }
}
