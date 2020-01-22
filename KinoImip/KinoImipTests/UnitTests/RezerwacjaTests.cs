using KinoImipLibrary.Model;
using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinoImipTests.UnitTests
{
    [TestFixture]
    public class RezerwacjaTests
    {
        [Test]
        public void GenerujBiletTests()
        {
            // Arrange
            var daneKlienta = new DaneKlienta("John", "Johninson", 313213);

            var miejsce = 2;
            var sala = new Sala(30);
            var film = new Film("Lighthouse", 2019);
            var seans = new Seans(sala, film);

            var rezerwacja = new Rezerwacja(
                    daneKlienta,
                    seans,
                    miejsce,
                    20,
                    true
                );

            // Act
            var bilet = rezerwacja.GenerujBilet();

            // Assert
            Assert.That(bilet.Seans, Is.EqualTo(seans), "GenerujBilet() failure");
        }
    }
}
