using System;
using System.Collections.Generic;
using System.Text;

namespace KinoImipLibrary.Interfaces
{
    public interface IFilm
    {
        string Nazwa { get; set; }
        string Rezyser { get; set; }
        int Rok { get; set; }
        string Gatunek { get; set; }
        string Notka { get; set; }
    }
}
