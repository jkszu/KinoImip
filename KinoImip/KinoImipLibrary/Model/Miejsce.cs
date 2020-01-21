using KinoImipLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace KinoImipLibrary.Model
{
    public class Miejsce : IMiejsce
    {
       public bool czyZarezerwowane { get; set; }
        public int Numer { get; set; }

       public Miejsce(int numer, bool czyZarezerwowane)
        {
            this.Numer = numer;
            this.czyZarezerwowane = czyZarezerwowane;
        }
    }
}