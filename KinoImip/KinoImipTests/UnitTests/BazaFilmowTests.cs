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
    public class BazaFilmowTests
    {
        [Test]
        public void ZwrocFilmyTest()
        {
            // Arrange
            var baza = new BazaFilmow();

            var film1 = new Film("The Lighthouse", 2019);
            var film2 = new Film("1917", 2020);
            var filmyExpected = new List<IFilm>();
            filmyExpected.Add(film1);
            filmyExpected.Add(film2);

            baza.DodajFilm(film1);
            baza.DodajFilm(film2);

            // Act
            var answer = baza.ZwrocFilmyTest();

            // Assert
            Assert.That(answer, Is.EqualTo(filmyExpected), "ZwrocFilmy() failure");
        }
    }
}
