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

        public List<IFilm> Filmy = new List<IFilm>();

        public void DodajFilm(IFilm film)
        {
            if( !Filmy.Contains(film) )
            {
                Filmy.Add(film);
            }
        }

        public string ZwrocFilmy()
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach(var film in Filmy)
            {
                stringBuilder.Append($"{film.Nazwa} {film.Rok} {film.Rezyser} {film.Gatunek}");
            }

            return stringBuilder.ToString();
        }
    }
}
