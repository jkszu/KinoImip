using System;
using System.Collections.Generic;
using System.Text;

namespace KinoImipLibrary.Interfaces
{
    public interface IKierownik
    {
        void DodajSeans(ISeans seans);
        void UsunSeans(ISeans seans);
        void DodajFilm(IFilm film);
        void UsunFilm(IFilm film);
        void PrzegladajFilmy();
        void PrzegladajSeanse();
    }
}
