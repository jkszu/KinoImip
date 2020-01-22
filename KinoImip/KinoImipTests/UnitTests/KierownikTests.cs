using KinoImipLibrary.Interfaces;
using KinoImipLibrary.Model;
using KinoImipLibrary.Services;
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
    public class KierownikTests
    {
        IKierownik kierownik;
        BazaFilmow bazaFilmow = BazaFilmow.Instance;
        BazaSeansow bazaSeansow = BazaSeansow.Instance;

        [SetUp]
        public void Init()
        {
            kierownik = new Kierownik();
        }

        [Test]
        public void DodajSeansTest()
        {
            // Arrange
            var film1 = new Film("The Lighthouse", 2019);
            var seans1 = new Seans(1, film1);

            // Act
            Kierownik.DodajSeans(seans1);

            // Assert
            Assert.That(bazaSeansow.Seanse.Contains(seans1), Is.True, "DodajSeans() failure");
        }

        [Test]
        public void UsunSeansTest()
        {
            // Arrange
            // Act
            // Assert
        }

        [Test]
        public void DodajFilmTest()
        {
            // Arrange
            // Act
            // Assert
        }

        [Test]
        public void UsunFilmTest()
        {
            // Arrange
            // Act
            // Assert
        }

        [Test]
        public void PrzegladajFilmyTest()
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

        [TearDown]
        public void Cleanup()
        {
            bazaFilmow.Filmy.Clear();
            bazaSeansow.Seanse.Clear();
        }
    }
}
