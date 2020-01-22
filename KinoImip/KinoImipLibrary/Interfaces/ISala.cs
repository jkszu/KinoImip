using System.Collections.Generic;

namespace KinoImipLibrary.Interfaces
{
    public interface ISala
    {
        int Numer { get; set; }
        List<IMiejsce> Miejsca { get; set; }
        int MaxMiejsc { get; set; }
        bool[] Dostepnosc { get; set; }
    }
}