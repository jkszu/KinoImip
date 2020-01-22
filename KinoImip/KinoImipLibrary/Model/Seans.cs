using KinoImipLibrary.Interfaces;

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

        public Seans(int numerSali, IFilm film)
        {
            this.Film = film;
            this.Sala = new Sala(numerSali);
        }
    }
}
