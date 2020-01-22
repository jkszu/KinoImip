using KinoImipLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace KinoImipLibrary.Model
{
    public class Kierownik : IKierownik
    {
        public void DodajFilm(IFilm film)
        {
            throw new NotImplementedException();
        }

        public void DodajSeans(ISeans seans)
        {
            throw new NotImplementedException();
        }

        public string PrzegladajFilmy()
        {
            throw new NotImplementedException();
        }

        public string PrzegladajSeanse()
        {
            throw new NotImplementedException();
        }

        public void UsunFilm(IFilm film)
        {
            throw new NotImplementedException();
        }

        public void UsunSeans(ISeans seans)
        {
            throw new NotImplementedException();
        }
    }
}
