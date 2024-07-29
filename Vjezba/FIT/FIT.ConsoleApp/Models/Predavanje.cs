namespace Fit.consoleapp.Models
{
    public class Predavanje
    {
        int god;
        public int Godina { get; set; }
        public string Tema { get; set; }
        public Predavanje(string tema, int godina)
        {
            Godina = godina;
            Tema = tema;
        }

      
    }
}
