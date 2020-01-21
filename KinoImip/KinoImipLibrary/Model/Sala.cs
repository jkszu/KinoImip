using KinoImipLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace KinoImipLibrary.Model
{
    public class Sala : ISala
    {
        public int Numer { get; set; }
        public List<IMiejsce> Miejsca { get; set; } = new List<IMiejsce>();
        public int MaxMiejsc { get; set; }
        public bool[] Dostepnosc { get; set; }

        public Sala(int maxMiejsc)
        {
            for (int i = 0; i < maxMiejsc; i++)
            {
                var noweMiejsce = new Miejsce(i, false);
                Miejsca.Add(noweMiejsce);
            }
        }
    }
}
