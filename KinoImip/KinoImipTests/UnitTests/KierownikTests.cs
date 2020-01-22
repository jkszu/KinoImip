using KinoImipLibrary.Interfaces;
using KinoImipLibrary.Model;
using KinoImipLibrary.Services;
using NUnit.Framework;

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
            kierownik.DodajSeans(seans1);

            // Assert
            Assert.That(bazaSeansow.Seanse.Contains(seans1), Is.True, "DodajSeans() failure");
        }

        [Test]
        public void UsunSeansTest()
        {
            // Arrange
            var film1 = new Film("The Lighthouse", 2019);
            var seans1 = new Seans(1, film1);
            bazaSeansow.DodajSeans(seans1);

            // Act
            kierownik.UsunSeans(seans1);

            // Assert
            Assert.That(bazaSeansow.Seanse.Contains(seans1), Is.False, "UsunSeans() failure");
        }

        [Test]
        public void DodajFilmTest()
        {
            // Arrange
            var film1 = new Film("The Lighthouse", 2019);

            // Act
            kierownik.DodajFilm(film1);

            // Assert
            Assert.That(bazaFilmow.Filmy.Contains(film1), Is.True, "DodajFilm() failure");
        }

        [Test]
        public void UsunFilmTest()
        {
            // Arrange
            var film1 = new Film("The Lighthouse", 2019);
            bazaFilmow.DodajFilm(film1);

            // Act
            kierownik.UsunFilm(film1);

            // Assert
            Assert.That(bazaFilmow.Filmy.Contains(film1), Is.False, "UsunFilm() failure");
        }

        [Test]
        public void PrzegladajFilmyTest()
        {
            // Arrange
            var film1 = new Film("The Lighthouse", 2019);
            bazaFilmow.DodajFilm(film1);
            var expectedResult = bazaFilmow.ZwrocFilmy();

            // Act
            var outcome = kierownik.PrzegladajFilmy();

            // Assert
            Assert.That(outcome, Is.EqualTo(expectedResult), "PrzegladajFilmy() failure");
        }

        [Test]
        public void PrzegladajSeanseTest()
        {
            // Arrange
            var film1 = new Film("The Lighthouse", 2019);
            var seans1 = new Seans(1, film1);
            bazaSeansow.DodajSeans(seans1);
            var expectedResult = bazaSeansow.ZwrocSeanse();

            // Act
            var outcome = kierownik.PrzegladajSeanse();

            // Assert
            Assert.That(outcome, Is.EqualTo(expectedResult), "PrzegladajFilmy() failure");
        }

        [TearDown]
        public void Cleanup()
        {
            bazaFilmow.Filmy.Clear();
            bazaSeansow.Seanse.Clear();
        }
    }
}
