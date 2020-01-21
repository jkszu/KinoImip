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

        public List<IBilet> Bilety { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IDaneKlienta DaneKlienta { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void AnulujRezerwacje(IRezerwacja rezerwacja)
        {
            throw new NotImplementedException();
        }

        public void KupBilet(ISeans seans, IMiejsce miejsce)
        {
            throw new NotImplementedException();
        }

        public void KupBilet(ISeans seans, IMiejsce miejsce, int posiadanaKwota)
        {
            throw new NotImplementedException();
        }

        public IRezerwacja Rezerwuj(ISeans seans, IMiejsce miejsce)
        {
            // TODO: Logic
            return new Rezerwacja();
        }
    }
}
