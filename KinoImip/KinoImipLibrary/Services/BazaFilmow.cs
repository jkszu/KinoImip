using KinoImipLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace KinoImipLibrary.Services
{
    public class BazaFilmow
    {
        private static readonly Lazy<BazaFilmow>
            lazy =
            new Lazy<BazaFilmow>
                (() => new BazaFilmow());

        public static BazaFilmow Instance { get { return lazy.Value; } }

        private BazaFilmow()
        {
        }

        public List<IFilm> Filmy;
    }
}
