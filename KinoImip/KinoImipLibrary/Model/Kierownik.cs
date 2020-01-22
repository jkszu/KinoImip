using KinoImipLibrary.Interfaces;
using KinoImipLibrary.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace KinoImipLibrary.Model
{
    public class Kierownik : IKierownik
    {
        BazaFilmow bazaFilmow = BazaFilmow.Instance;
        BazaSeansow bazaSeansow = BazaSeansow.Instance;

        public void DodajFilm(IFilm film)
        {
            bazaFilmow.DodajFilm(film);
        }

        public void DodajSeans(ISeans seans)
        {
            bazaSeansow.DodajSeans(seans);
        }

        public string PrzegladajFilmy()
        {
            return bazaFilmow.ZwrocFilmy();
        }

        public string PrzegladajSeanse()
        {
            return bazaSeansow.ZwrocSeanse();
        }

        public void UsunFilm(IFilm film)
        {
            bazaFilmow.Filmy.Remove(film);
        }

        public void UsunSeans(ISeans seans)
        {
            bazaSeansow.Seanse.Remove(seans);
        }
    }
}
