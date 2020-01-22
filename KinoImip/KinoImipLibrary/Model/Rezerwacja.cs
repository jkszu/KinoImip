
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

        public Rezerwacja(IDaneKlienta daneKlienta, ISeans seans, int miejsce, float kwota, bool status)
        {
            this.Imie = daneKlienta.DaneOsobowe.Imie;
            this.Nazwisko = daneKlienta.DaneOsobowe.Nazwisko;
            this.Pozycja = new Miejsce(miejsce, true);
            this.Seans = seans;
            this.Kwota = kwota;
            this.Status = status;
        }

        public IBilet GenerujBilet()
        {
            return new Bilet(this.Seans, this.Pozycja.Numer);
        }
    }
}
