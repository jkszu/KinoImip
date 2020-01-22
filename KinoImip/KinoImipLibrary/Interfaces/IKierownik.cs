namespace KinoImipLibrary.Interfaces
{
    public interface IKierownik
    {
        void DodajSeans(ISeans seans);
        void UsunSeans(ISeans seans);
        void DodajFilm(IFilm film);
        void UsunFilm(IFilm film);
        string PrzegladajFilmy();
        string PrzegladajSeanse();
    }
}