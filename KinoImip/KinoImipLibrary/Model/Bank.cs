using KinoImipLibrary.Interfaces;

namespace KinoImipLibrary.Model
{
    public class Bank
    {
        public bool PrzyjmijPlatnosc(IPlatnosc platnosc)
        {
            System.Console.WriteLine("Platnosc przyjeta");
            return true;
        }
    }
}
