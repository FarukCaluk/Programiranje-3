namespace FIT.data
{
    public class Student : Osoba
    {
        public string index { get; set; }
        public string ime { get; set; }
        public string prezime { get; set; }
        public override string ToString()
        {
            return $"{index} {ime} {prezime}";
        }
    }
}
