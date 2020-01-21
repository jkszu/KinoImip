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


            // Act
            // Assert
        }

        [Test]
        public void AnulujRezerwacjeTest()
        {
            // Arrange
            // Act
            // Assert
        }

        [Test]
        public void PrzegladajSeanseTest()
        {
            // Arrange
            // Act
            // Assert
        }
    }
}
