using System;
using System.Collections.Generic;
using System.Text;
using KinoImipLibrary.Interfaces;

namespace KinoImipLibrary.Services
{
    public class BazaFilmow
    {
        private static readonly Lazy<BazaFilmow>
            lazy =
                new Lazy<BazaFilmow>
                    (() => new BazaFilmow());

        public List<IFilm> Filmy = new List<IFilm>();

        private BazaFilmow()
        {
        }

        public static BazaFilmow Instance => lazy.Value;

        public void DodajFilm(IFilm film)
        {
            if (!Filmy.Contains(film)) Filmy.Add(film);
        }

        public string ZwrocFilmy()
        {
            var stringBuilder = new StringBuilder();
            foreach (var film in Filmy) stringBuilder.Append($"{film.Nazwa} {film.Rok}\n");

            return stringBuilder.ToString();
        }
    }
}