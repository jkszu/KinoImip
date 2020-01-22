using System;
using KinoImipLibrary.Interfaces;

namespace KinoImipLibrary.Model
{
    public class Platnosc : IPlatnosc
    {
        public Platnosc(IRezerwacja zaCo, IKlient kto)
        {
            ZaCo = zaCo;
            Kto = kto;
        }

        public IRezerwacja ZaCo { get; set; }
        public IKlient Kto { get; set; }

        public bool WyslijPlatnosc(int kwota)
        {
            var bank = new Bank();
            Console.WriteLine("Platnosc wyslana");

            return bank.PrzyjmijPlatnosc(this);
        }
    }
}