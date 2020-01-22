using System.Collections.Generic;

namespace KinoImipLibrary.Interfaces
{
    public interface IDaneKlienta
    {
        IDaneOsobowe DaneOsobowe { get; set; }
        List<IRezerwacja> Rezerwacje { get; set; }
        List<IBilet> Bilety { get; set; }
    }
}