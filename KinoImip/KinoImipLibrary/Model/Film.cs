using KinoImipLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace KinoImipLibrary.Model
{
    public class Film : IFilm
    {
        public int Rok { get; set; }
        public string Nazwa { get; set; }
        public string Rezyser { get; set; }
        public string Gatunek { get; set; }
        public string Notka { get; set; }

        public Film(string nazwa, int rok)
        {
            this.Rok = rok;
            this.Nazwa = nazwa;
        }
    }
}
