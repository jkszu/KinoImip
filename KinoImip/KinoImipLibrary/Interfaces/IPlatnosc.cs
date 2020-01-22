namespace KinoImipLibrary.Interfaces
{
    public interface IPlatnosc
    {
        IRezerwacja ZaCo { get; set; }
        IKlient Kto { get; set; }
        void WyslijPlatnosc(int kwota);
    }
}
