using KinoImipLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace KinoImipLibrary.Model
{
    public class Seans : ISeans
    {
        public ISala Sala { get; set; }
        public IFilm Film { get; set; }

        public Seans(ISala sala, IFilm film)
        {
            this.Sala = sala;
            this.Film = film;
        }
    }
}
