using KinoImipLibrary.Interfaces;

namespace KinoImipLibrary.Model
{
    public class Miejsce : IMiejsce
    {
        public Miejsce(int numer, bool czyZarezerwowane)
        {
            Numer = numer;
            this.czyZarezerwowane = czyZarezerwowane;
        }

        public bool czyZarezerwowane { get; set; }
        public int Numer { get; set; }
    }
}