using KinoImipLibrary.Interfaces;

namespace KinoImipLibrary.Model
{
    public class Bilet : IBilet
    {
        public Bilet(ISeans seans, int miejsce)
        {
            Seans = seans;
            Miejsce = new Miejsce(miejsce, true);
        }

        public ISeans Seans { get; set; }
        public IMiejsce Miejsce { get; set; }
    }
}