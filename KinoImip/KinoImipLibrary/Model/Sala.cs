using System.Collections.Generic;
using System.Linq;
using KinoImipLibrary.Interfaces;
using KinoImipLibrary.Services;

namespace KinoImipLibrary.Model
{
    public class Sala : ISala
    {
        public Sala(int maxMiejsc)
        {
            for (var i = 0; i < maxMiejsc; i++)
            {
                var noweMiejsce = new Miejsce(i, false);
                Miejsca.Add(noweMiejsce);
            }

            Sale.Instance.sale.Add(this);
            var iloscSal = Sale.Instance.sale.Count();
            Numer = iloscSal;
        }

        public int Numer { get; set; }
        public List<IMiejsce> Miejsca { get; set; } = new List<IMiejsce>();
        public int MaxMiejsc { get; set; }
        public bool[] Dostepnosc { get; set; }
    }
}