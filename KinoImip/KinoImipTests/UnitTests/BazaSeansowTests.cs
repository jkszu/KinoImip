﻿using KinoImipLibrary.Interfaces;
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
    public class BazaSeansowTests
    {
        BazaSeansow baza = BazaSeansow.Instance;

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
            var zwrocSeanseExpected = "1: The Lighthouse\n2: 1917\n";

            // Assert
            Assert.That(answer, Is.EqualTo(zwrocSeanseExpected), "ZwrocFilmy() failure");
        }

        [TearDown]
        public void Cleanup()
        {
            baza.Seanse.Clear();
        }
    }
}
 