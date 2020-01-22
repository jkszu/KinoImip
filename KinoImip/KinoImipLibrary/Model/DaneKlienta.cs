using KinoImipLibrary.Interfaces;
using System.Collections.Generic;

namespace KinoImipLibrary.Model
{
    public class DaneKlienta : IDaneKlienta
    {
        public IDaneOsobowe DaneOsobowe { get; set; }
        public List<IRezerwacja> Rezerwacje { get; set; } = new List<IRezerwacja>();
        public List<IBilet> Bilety { get; set; } = new List<IBilet>();

        public DaneKlienta(string imie, string nazwisko, int konto)
        {
            DaneOsobowe = new DaneOsobowe(imie, nazwisko, konto);
        }
    }
}
