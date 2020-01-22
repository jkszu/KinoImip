namespace KinoImipLibrary.Interfaces
{
    public interface IPlatnosc
    {
        IRezerwacja ZaCo { get; set; }
        IKlient Kto { get; set; }
        bool WyslijPlatnosc(int kwota);
    }
}
