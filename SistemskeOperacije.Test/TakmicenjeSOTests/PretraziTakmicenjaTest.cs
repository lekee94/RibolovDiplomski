using Biblioteka;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SistemskeOperacije.TakmicenjeSO;
using System.Collections.Generic;
using System.Linq;

namespace SistemskeOperacije.Test.TakmicenjeSOTests
{
    [TestClass]
    public class PretraziTakmicenjaTest
    {
        [TestMethod]
        public void PretraziTakmicenjaPoKategorijiUspesno()
        {
            var randomTakmicenje = new VratiJednoTakmicenje().IzvrsiSO(new Takmicenje()) as Takmicenje;
            Assert.IsNotNull(randomTakmicenje);

            randomTakmicenje.Uslov = $"Kategorija like '{randomTakmicenje.Kategorija}%'";

            var trazenaTakmicenja = new PretraziTakmicenja().IzvrsiSO(randomTakmicenje) as List<Takmicenje>;

            var takmicenje = trazenaTakmicenja.FirstOrDefault();

            Assert.IsNotNull(takmicenje);

            Assert.IsTrue(takmicenje.Kategorija.Equals(randomTakmicenje.Kategorija));
        }

        [TestMethod]
        public void PretraziTakmicenjaPoDelegatuUspesno()
        {
            var randomTakmicenje = new VratiJednoTakmicenje().IzvrsiSO(new Takmicenje()) as Takmicenje;
            Assert.IsNotNull(randomTakmicenje);

            randomTakmicenje.Uslov = $"Delegat = {randomTakmicenje.Delegat.DelegatID}";

            var trazenaTakmicenja = new PretraziTakmicenja().IzvrsiSO(randomTakmicenje) as List<Takmicenje>;

            var takmicenje = trazenaTakmicenja.FirstOrDefault();

            Assert.IsNotNull(takmicenje);

            Assert.IsTrue(takmicenje.Delegat.DelegatID == randomTakmicenje.Delegat.DelegatID);
        }

        [TestMethod]
        public void PretraziTakmicenjaPoStaziUspesno()
        {
            var randomTakmicenje = new VratiJednoTakmicenje().IzvrsiSO(new Takmicenje()) as Takmicenje;
            Assert.IsNotNull(randomTakmicenje);

            randomTakmicenje.Uslov = $"Staza = {randomTakmicenje.Staza.StazaID}";

            var trazenaTakmicenja = new PretraziTakmicenja().IzvrsiSO(randomTakmicenje) as List<Takmicenje>;

            var takmicenje = trazenaTakmicenja.FirstOrDefault();

            Assert.IsNotNull(takmicenje);

            Assert.IsTrue(takmicenje.Staza.StazaID == randomTakmicenje.Staza.StazaID);
        }

        [TestMethod]
        public void PretraziTakmicenjeNeuspesno()
        {
            var ocekivaniRezultat = 0;

            var takmicenje = new Takmicenje()
            {
                Uslov = "TakmicenjeID < 0" 
            };

            var trazenaTakmicenja = new PretraziTakmicenja().IzvrsiSO(takmicenje) as List<Takmicenje>;

            Assert.IsTrue(trazenaTakmicenja != null && trazenaTakmicenja.Count <= ocekivaniRezultat);
        }
    }
}
