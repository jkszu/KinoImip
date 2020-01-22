using System;
using System.Collections.Generic;
using System.Text;
using KinoImipLibrary.Interfaces;

namespace KinoImipLibrary.Services
{
    public class BazaSeansow
    {
        private static readonly Lazy<BazaSeansow>
            lazy =
                new Lazy<BazaSeansow>
                    (() => new BazaSeansow());

        public List<ISeans> Seanse = new List<ISeans>();

        private BazaSeansow()
        {
        }

        public static BazaSeansow Instance => lazy.Value;

        public void DodajSeans(ISeans seans)
        {
            if (!Seanse.Contains(seans)) Seanse.Add(seans);
        }

        public string ZwrocSeanse()
        {
            var stringBuilder = new StringBuilder();
            foreach (var seans in Seanse)
            {
                var numerSali = seans.Sala.Numer;
                stringBuilder.Append($"{numerSali}: {seans.Film.Nazwa}\n");
            }

            return stringBuilder.ToString();
        }
    }
}