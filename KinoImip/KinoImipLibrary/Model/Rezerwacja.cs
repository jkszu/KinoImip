
using KinoImipLibrary.Interfaces;

namespace KinoImipLibrary.Model
{
    public class Rezerwacja : IRezerwacja
    {
        public IMiejsce Pozycja { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public ISeans Seans { get; set; }
        public float Kwota { get; set; }
        public bool Status { get; set; }

        public IBilet GenerujBilet()
        {
            throw new System.NotImplementedException();
        }
    }
}
