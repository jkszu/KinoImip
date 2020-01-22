using System.Linq;
using KinoImipLibrary.Interfaces;

namespace KinoImipLibrary.Model
{
    public class Klient : IKlient
    {
        public Klient(IDaneKlienta daneKlienta)
        {
            DaneKlienta = daneKlienta;
        }

        public Klient(string imie, string nazwisko, int konto)
        {
            DaneKlienta = new DaneKlienta(imie, nazwisko, konto);
        }

        public IDaneKlienta DaneKlienta { get; set; }

        public void AnulujRezerwacje(IRezerwacja rezerwacja)
        {
            rezerwacja.Pozycja.czyZarezerwowane = false;
            rezerwacja.Status = false;
            DaneKlienta.Rezerwacje.Remove(rezerwacja);
        }

        public void KupBilet(ISeans seans, int miejsce, float kwota)
        {
            var bank = new Bank();


            IRezerwacja rezerwacja;

            if (!DaneKlienta.Rezerwacje.Where(a => a.Seans == seans && a.Pozycja.Numer == miejsce).Any())
                rezerwacja = Rezerwuj(seans, miejsce);
            else
                rezerwacja = DaneKlienta.Rezerwacje.Where(a => a.Seans == seans && a.Pozycja.Numer == miejsce).First();

            var bilet = rezerwacja.GenerujBilet();
            DaneKlienta.Bilety.Add(bilet);
            DaneKlienta.Rezerwacje.Remove(rezerwacja);
        }

        public IRezerwacja Rezerwuj(ISeans seans, int miejsce)
        {
            var miejscePodczasSeansu = seans.Sala.Miejsca[miejsce];
            var czyZarezerwowane = miejscePodczasSeansu.czyZarezerwowane;

            if (!czyZarezerwowane) miejscePodczasSeansu.czyZarezerwowane = true;

            var rezerwacja = new Rezerwacja(
                DaneKlienta,
                seans,
                miejsce,
                20,
                true
            );

            DaneKlienta.Rezerwacje.Add(rezerwacja);
            return rezerwacja;
        }
    }
}