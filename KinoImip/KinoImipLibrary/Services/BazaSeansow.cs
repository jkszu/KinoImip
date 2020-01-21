using KinoImipLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace KinoImipLibrary.Services
{
    public class BazaSeansow
    {
        private static readonly Lazy<BazaSeansow>
            lazy =
            new Lazy<BazaSeansow>
                (() => new BazaSeansow());

        public static BazaSeansow Instance { get { return lazy.Value; } }

        private BazaSeansow()
        {
        }

        public List<ISeans> Seanse;
    }
}
