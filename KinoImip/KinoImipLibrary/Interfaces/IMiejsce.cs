using System;
using System.Collections.Generic;
using System.Text;

namespace KinoImipLibrary.Interfaces
{
    public interface IMiejsce
    {
        int Numer { get; set; }
        bool czyZarezerwowane { get; set; }
    }
}
