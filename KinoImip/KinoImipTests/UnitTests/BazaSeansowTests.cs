using KinoImipLibrary.Model;
using KinoImipLibrary.Services;
using NUnit.Framework;

namespace KinoImipTests.UnitTests
{
    [TestFixture]
    public class BazaSeansowTests
    {
        BazaSeansow baza = BazaSeansow.Instance;

        [SetUp]
        public void Init()
        {
            baza.Seanse.Clear();
        }

        [Test]
        public void ZwrocSeanseTest()
        {
            // Arrange
            var film1 = new Film("The Lighthouse", 2019);
            var film2 = new Film("1917", 2020);

            var seans1 = new Seans(1, film1);
            var seans2 = new Seans(2, film2);

            baza.DodajSeans(seans1);
            baza.DodajSeans(seans2);

            // Act
            var answer = baza.ZwrocSeanse();
            var zwrocSeanseExpected = "The Lighthouse\n1917\n";

            // Assert
            Assert.That(answer, Is.EqualTo(zwrocSeanseExpected), "ZwrocSeanse() failure");
        }

        [TearDown]
        public void Cleanup()
        {
            baza.Seanse.Clear();
        }
    }
}
