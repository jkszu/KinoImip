using System;
using System.Collections.Generic;
using System.Text;

namespace KinoImipLibrary.Interfaces
{
    public interface IPotwierdzenie
    {
        IRezerwacja ZaCo { get; set; }
        IKlient Kto { get; set; }
    }
}
