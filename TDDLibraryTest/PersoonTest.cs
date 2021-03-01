using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDLibrary;
using System;
using System.Collections.Generic;

namespace TDDLibraryTest
{
    [TestClass]
    public class PersoonTest
    {
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void LegeLijstIsVerkeerd()
        {
            new Persoon(new List<string> { });
        }

        [TestMethod, ExpectedException(typeof(ArgumentNullException))]
        public void EenLijstMetNullIsVerkeerd()
        {
            new Persoon(null);
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void EenVoornaamZonderTekenIsVerkeerd()
        {
            new Persoon(new List<string> {""});
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void EenLijstMet2DezelfdeVoornamenIsVerkeerd()
        {
            new Persoon(new List<string> { "vida", "vida" });
        }

        [TestMethod]
        public void EenLijstMetMinstensEenVoornaamIsOk()
        {
            new Persoon(new List<string> { "vida" });
        }

        [TestMethod]
        public void EenLijstMet2VerschillendeVoornamenIsOk()
        {
            new Persoon(new List<string> { "vida", "ali" });
        }

        [TestMethod]
        public void ToStringMoetEenStringTeruggeven()
        {
            var voornaam = new List<string> { "vida", "ali" };
            var persoon = new Persoon(voornaam);
            string voornaamMetSpatie = string.Join(' ', voornaam);
            Assert.AreEqual(voornaamMetSpatie, persoon.ToString());
        }
    }
}
