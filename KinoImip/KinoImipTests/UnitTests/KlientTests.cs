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
            var seans = Substitute.For<ISeans>();
            var bilet = Substitute.For<IBilet>();
            var daneKlienta = Substitute.For<IDaneKlienta>();
            var miejsce = Substitute.For<IMiejsce>();

            var klient = new Klient(daneKlienta);

            // Act
            klient.KupBilet(seans, miejsce);

            // Assert
            Assert.That(klient.Bilety.Any(b => b == bilet), "KupBilet() failure");  
        }

        [Test]
        public void RezerwujTest()
        {
            // Arrange
            var sala = new Sala(30);
            var film = new Film("Lighthouse", 2019);
            var seans = new Seans(sala, film);

            var bilet = Substitute.For<IBilet>();
            var daneKlienta = Substitute.For<IDaneKlienta>(); 

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
            var daneKlienta = Substitute.For<IDaneKlienta>();

            //var rezerwacja = Substitute.For<IRezerwacja>();
            var rezerwacja = new Rezerwacja();
            rezerwacja.Imie = "John";
            rezerwacja.Kwota = 20;
            rezerwacja.Nazwisko = "Johnson";
            rezerwacja.Pozycja = new Miejsce(4,true);

            var rezerwacje = new List<IRezerwacja>();
            rezerwacje.Add(rezerwacja);

            daneKlienta.Rezerwacje.Returns(rezerwacje);

            var klient = new Klient(daneKlienta);

            // Act
            klient.AnulujRezerwacje(rezerwacja);

            // Assert
            Assert.That(rezerwacja.Status, Is.EqualTo(false));
        }
    }
}
