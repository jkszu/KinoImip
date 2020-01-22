using System;
using KinoImipLibrary.Interfaces;

namespace KinoImipLibrary.Model
{
    public class Bank
    {
        public bool PrzyjmijPlatnosc(IPlatnosc platnosc)
        {
            Console.WriteLine("Platnosc przyjeta");
            return true;
        }
    }
}