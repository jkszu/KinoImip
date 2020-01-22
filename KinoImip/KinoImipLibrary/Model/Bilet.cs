using KinoImipLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace KinoImipLibrary.Model
{
    public class Bilet : IBilet
    {
        public ISeans Seans { get; set; }
        public IMiejsce Miejsce { get; set; }

        public Bilet(ISeans seans, int miejsce)
        {
            this.Seans = seans;
            this.Miejsce = new Miejsce(miejsce, true);
        }
    }
}
