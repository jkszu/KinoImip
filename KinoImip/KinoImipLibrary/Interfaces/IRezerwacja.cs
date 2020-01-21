using System;
using System.Collections.Generic;
using System.Text;

namespace KinoImipLibrary.Interfaces
{
    public interface IRezerwacja
    {
        IMiejsce Pozycja { get; set; }
        string Imie { get; set; }
        string Nazwisko { get; set; }
        ISeans Seans { get; set; }
        float Kwota { get; set; }
        bool Status { get; set; }
        IBilet GenerujBilet();

    }
}
