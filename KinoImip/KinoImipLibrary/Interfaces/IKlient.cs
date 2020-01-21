using System;
using System.Collections.Generic;
using System.Text;

namespace KinoImipLibrary.Interfaces
{
    public interface IKlient
    {
        List<IBilet> Bilety { get; set; } 
        IDaneKlienta DaneKlienta { get; set; }

        void KupBilet(ISeans seans, IMiejsce miejsce);
    }
}
