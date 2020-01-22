using KinoImipLibrary.Interfaces;

namespace KinoImipLibrary.Model
{
    public class DaneOsobowe : IDaneOsobowe
    {
        public DaneOsobowe(string imie, string nazwisko, int konto)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            Konto = konto;
        }

        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public int Konto { get; set; }
    }
}