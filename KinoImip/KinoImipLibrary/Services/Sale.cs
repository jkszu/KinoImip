using System;
using System.Collections.Generic;
using KinoImipLibrary.Interfaces;

namespace KinoImipLibrary.Services
{
    public class Sale
    {
        private static readonly Lazy<Sale>
            lazy = new Lazy<Sale>(() => new Sale());

        public List<ISala> sale = new List<ISala>();

        private Sale()
        {
        }

        public static Sale Instance => lazy.Value;
    }
}