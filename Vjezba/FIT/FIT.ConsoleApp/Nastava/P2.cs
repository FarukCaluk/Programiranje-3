using FIT.data;

namespace Fit.consoleapp.Nastava
{
    public class P2
    {
        public static void Pokreni()
        {
            //BazniTip();
            Overrider();
        }

        private static void Overrider()
        {
            Student denis = new Student();
           
            Console.WriteLine(denis);
            Console.WriteLine(denis.ToString());
        }

        private static void BazniTip()
        {
            int god = 2023;
            Osoba denis = new Student();

            Console.WriteLine(denis);
            Console.WriteLine(denis.ToString());

            object oGodina = god;
            object oDenis = denis;
            fromObj(denis);
            fromObj(god);
        }
        private static void fromObj(object obj)
        {
            if (obj is Student)
            {
                (obj as Student).Predstavise();
            }
            else if (obj is int)
                Console.WriteLine("int");
        }
    }
}
