using KinoImipLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace KinoImipLibrary.Model
{
    public class Klient : IKlient
    {
        public Klient(IDaneKlienta daneKlienta)
        {
            DaneKlienta = daneKlienta;
        }

        public List<IBilet> Bilety { get; set; }
        public IDaneKlienta DaneKlienta { get; set; }

        public void AnulujRezerwacje(IRezerwacja rezerwacja)
        {
            rezerwacja.Pozycja.czyZarezerwowane = false;
            rezerwacja.Status = false;
            this.DaneKlienta.Rezerwacje.Remove(rezerwacja);
        }

        public void KupBilet(ISeans seans, IMiejsce miejsce)
        {
            // TODO: Platnosc


            
        }

        public void KupBilet(ISeans seans, IMiejsce miejsce, int posiadanaKwota)
        {
            throw new NotImplementedException();
        }

        public IRezerwacja Rezerwuj(ISeans seans, int miejsce)
        {
            var miejscePodczasSeansu = seans.Sala.Miejsca[miejsce];
            var czyZarezerwowane = miejscePodczasSeansu.czyZarezerwowane;


            if (!czyZarezerwowane)
            {
                miejscePodczasSeansu.czyZarezerwowane = true;
            }

            var rezerwacja = new Rezerwacja();
            rezerwacja.Imie = DaneKlienta.DaneOsobowe.Imie;
            rezerwacja.Nazwisko = DaneKlienta.DaneOsobowe.Nazwisko;
            rezerwacja.Seans = seans;
            rezerwacja.Kwota = 20;
            rezerwacja.Status = true;
            rezerwacja.Pozycja = miejscePodczasSeansu;

            return rezerwacja;
        }
    }
}
