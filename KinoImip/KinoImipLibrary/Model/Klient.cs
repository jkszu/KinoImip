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

        public void KupBilet(ISeans seans, IMiejsce miejsce)
        {
            throw new NotImplementedException();
        }
    }
}
