using System;
using System.Collections.Generic;
using System.Text;

namespace KinoImipLibrary.Interfaces
{
    public interface IBilet
    {
        ISeans Seans { get; set; }
        IMiejsce Miejsce { get; set; }
    }
}
