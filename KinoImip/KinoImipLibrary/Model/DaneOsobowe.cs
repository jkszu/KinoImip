using KinoImipLibrary.Interfaces;

namespace KinoImipLibrary.Model
{
    public class DaneOsobowe : IDaneOsobowe
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public int Konto { get; set; }

        public DaneOsobowe(string imie, string nazwisko, int konto)
        {
            this.Imie = imie;
            this.Nazwisko = nazwisko;
            this.Konto = konto;
        }
    }
}
