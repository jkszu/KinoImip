using KinoImipLibrary.Interfaces;

namespace KinoImipLibrary.Model
{
    public class Rezerwacja : IRezerwacja
    {
        public Rezerwacja(IDaneKlienta daneKlienta, ISeans seans, int miejsce, float kwota, bool status)
        {
            Imie = daneKlienta.DaneOsobowe.Imie;
            Nazwisko = daneKlienta.DaneOsobowe.Nazwisko;
            Pozycja = new Miejsce(miejsce, true);
            Seans = seans;
            Kwota = kwota;
            Status = status;
        }

        public IMiejsce Pozycja { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public ISeans Seans { get; set; }
        public float Kwota { get; set; }
        public bool Status { get; set; }

        public IBilet GenerujBilet()
        {
            return new Bilet(Seans, Pozycja.Numer);
        }
    }
}