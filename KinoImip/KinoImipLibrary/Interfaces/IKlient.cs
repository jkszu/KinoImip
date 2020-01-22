namespace KinoImipLibrary.Interfaces
{
    public interface IKlient
    {
        IDaneKlienta DaneKlienta { get; set; }

        void KupBilet(ISeans seans, int miejsce, float kwota);
        IRezerwacja Rezerwuj(ISeans seans, int miejsce);
        void AnulujRezerwacje(IRezerwacja rezerwacja);
    }
}
