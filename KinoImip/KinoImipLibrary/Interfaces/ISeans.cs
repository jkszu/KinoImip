using System;
using System.Collections.Generic;
using System.Text;

namespace KinoImipLibrary.Interfaces
{
    public interface ISeans
    {
        ISala Sala { get; set; }
        IFilm Film { get; set; }
    }
}
