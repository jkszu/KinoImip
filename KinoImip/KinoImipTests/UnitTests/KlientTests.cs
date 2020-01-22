using NSubstitute;
using NUnit.Framework;
using KinoImipLibrary.Interfaces;
using KinoImipLibrary.Model;

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinoImipTests.UnitTests
{
    [TestFixture]
    public class KlientTests
    {
        [SetUp]
        public void Init()
        {
        }

        [Test]
        public void KupBiletTest()
        {
            // Arrange
            var sala = new Sala(30);
            var film = new Film("Lighthouse", 2019);
            var seans = new Seans(sala, film);
            var miejsce = 2;
            var bilet = new Bilet(seans, miejsce);
            var daneKlienta = new DaneKlienta("John", "Johnson", 23423);
            var klient = new Klient(daneKlienta);

            // Act
            klient.KupBilet(seans, miejsce, 20);

            // Assert
            Assert.That(klient.DaneKlienta.Bilety.Any(b => b.Seans == bilet.Seans), "KupBilet() failure");  
        }

        [Test]
        public void RezerwujTest()
        {
            // Arrange
            var miejsce = 2;
            var sala = new Sala(30);
            var film = new Film("Lighthouse", 2019);
            var seans = new Seans(sala, film);
            var bilet = new Bilet(seans, miejsce);
            var daneKlienta = new DaneKlienta("John", "Johnson", 32423);

            var klient = new Klient(daneKlienta);

            // Act
            var rezerwacja = klient.Rezerwuj(seans, 2);

            // Assert
            Assert.That(rezerwacja.Status, Is.EqualTo(true), "Rezerwuj() failure"); // TODO: Enum, reserved
        }

        [Test]
        public void AnulujRezerwacjeTest()
        {
            // Arrange
            var klient = new Klient("John", "Johnson", 3221345);

            var sala = new Sala(30);
            var film = new Film("Lighthouse", 2019);
            var seans = new Seans(sala, film);

            var rezerwacja = new Rezerwacja(klient.DaneKlienta, seans, 4, 20, true); 
            var rezerwacje = new List<IRezerwacja>(); 
            klient.DaneKlienta.Rezerwacje = rezerwacje; 

            // Act
            klient.AnulujRezerwacje(rezerwacja);

            // Assert
            Assert.That(rezerwacja.Status, Is.EqualTo(false));
        }
    }
}
