using NUnit.Framework;
using KinoImipLibrary.Services;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KinoImipLibrary.Model;
using KinoImipLibrary.Interfaces;

namespace KinoImipTests.UnitTests
{
    [TestFixture]
    public class BazaFilmowTests
    {
        BazaFilmow baza = BazaFilmow.Instance;

        [Test]
        public void ZwrocFilmyTest()
        {
            // Arrange
            var baza = BazaFilmow.Instance;

            var film1 = new Film("The Lighthouse", 2019);
            var film2 = new Film("1917", 2020);
            var filmyExpected = new List<IFilm>();

            filmyExpected.Add(film1);
            filmyExpected.Add(film2);

            var filmyExpectedAnswer = "The Lighthouse 2019\n1917 2020\n";

            baza.DodajFilm(film1);
            baza.DodajFilm(film2);

            // Act
            var answer = baza.ZwrocFilmy();

            // Assert
            Assert.That(answer, Is.EqualTo(filmyExpectedAnswer), "ZwrocFilmy() failure");
        }

        [TearDown]
        public void Cleanup()
        {
            baza.Filmy.Clear();
        }
    }
}
