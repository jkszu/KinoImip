namespace KinoImipLibrary.Interfaces
{
    public interface IPotwierdzenie
    {
        IRezerwacja ZaCo { get; set; }
        IKlient Kto { get; set; }
    }
}
