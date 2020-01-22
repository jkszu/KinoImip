using KinoImipLibrary.Model;
using NUnit.Framework;

namespace KinoImipTests.UnitTests
{
    [TestFixture]
    public class PlatnoscTests
    {
        [Test]
        public void WyslijPlatnoscTest()
        {
            // Arrange
            var klient = new Klient("John", "Johanson", 3242);
            var film1 = new Film("The Lighthouse", 2019);
            var seans1 = new Seans(1, film1);
            var miejsce = 2;
            var kwota = 20;

            var rezerwacja = new Rezerwacja(klient.DaneKlienta, seans1, miejsce, kwota, true);
            var platnosc = new Platnosc(rezerwacja, klient);

            // Act
            var outcome = platnosc.WyslijPlatnosc(kwota);

            // Assert
            Assert.That(outcome, Is.True, "WyslijPlatnosc() failure"); 
        }
    }
}
