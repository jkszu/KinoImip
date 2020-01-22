using KinoImipLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace KinoImipLibrary.Services
{
    public class BazaSeansow
    {
        private static readonly Lazy<BazaSeansow>
            lazy =
            new Lazy<BazaSeansow>
                (() => new BazaSeansow());

        public static BazaSeansow Instance { get { return lazy.Value; } }

        private BazaSeansow()
        {
        }

        public List<ISeans> Seanse = new List<ISeans>();
        public void DodajSeans(ISeans seans)
        {
            if (!Seanse.Contains(seans))
            {
                Seanse.Add(seans);
            }
        }

        public string ZwrocSeanse()
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var seans in Seanse)
            {
                var numerSali = seans.Sala.Numer;
                stringBuilder.Append($"{numerSali}: {seans.Film.Nazwa}\n");
            }

            return stringBuilder.ToString();
        }
    }
}
