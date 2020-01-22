using KinoImipLibrary.Interfaces;

namespace KinoImipLibrary.Model
{
    public class Potwierdzenie : IPotwierdzenie
    {
        public IRezerwacja ZaCo { get; set; }
        public IKlient Kto { get; set; }
    }
}