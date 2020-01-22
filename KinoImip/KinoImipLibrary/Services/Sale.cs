using KinoImipLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace KinoImipLibrary.Services
{
    public class Sale
    {
        private static readonly Lazy<Sale>
            lazy = new Lazy<Sale>(() => new Sale());

        public static Sale Instance { get { return lazy.Value; } }

        private Sale()
        {
        }

        public List<ISala> sale = new List<ISala>();
    }
}
