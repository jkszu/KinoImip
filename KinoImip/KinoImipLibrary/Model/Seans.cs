using KinoImipLibrary.Interfaces;

namespace KinoImipLibrary.Model
{
    public class Seans : ISeans
    {
        public Seans(ISala sala, IFilm film)
        {
            Sala = sala;
            Film = film;
        }

        public Seans(int numerSali, IFilm film)
        {
            Film = film;
            Sala = new Sala(numerSali);
        }

        public ISala Sala { get; set; }
        public IFilm Film { get; set; }
    }
}