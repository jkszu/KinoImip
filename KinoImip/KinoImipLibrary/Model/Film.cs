using KinoImipLibrary.Interfaces;

namespace KinoImipLibrary.Model
{
    public class Film : IFilm
    {
        public Film(string nazwa, int rok)
        {
            Rok = rok;
            Nazwa = nazwa;
        }

        public int Rok { get; set; }
        public string Nazwa { get; set; }
        public string Rezyser { get; set; }
        public string Gatunek { get; set; }
        public string Notka { get; set; }
    }
}