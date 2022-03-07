using Biblioteka;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SistemskeOperacije.TakmicarSO;
using System.Collections.Generic;

namespace SistemskeOperacije.Test.TakmicarSOTest
{
    [TestClass]
    public class PretraziTakmicareTest
    {
        [TestMethod]
        public void PretraziTakmicarePoImenuUspesno()
        {
            var testTakmicar = new VratiJednogTakmicara().IzvrsiSO(new Takmicar()) as Takmicar;
            Assert.IsNotNull(testTakmicar);

            testTakmicar.Uslov = $"Ime like '{testTakmicar.Ime}%'";

            var trazeniTakmicari = new PretraziTakmicare().IzvrsiSO(testTakmicar) as List<Takmicar>;

            foreach (var t in trazeniTakmicari)
            {
                Assert.IsNotNull(t);

                Assert.IsTrue(t.Ime.Equals(testTakmicar.Ime));
            }
        }

        [TestMethod]
        public void PretraziTakmicarePoPrezimenuUspesno()
        {
            var testTakmicar = new VratiJednogTakmicara().IzvrsiSO(new Takmicar()) as Takmicar;
            Assert.IsNotNull(testTakmicar);

            testTakmicar.Uslov = $"Prezime like '{testTakmicar.Prezime}%'";

            var trazeniTakmicari = new PretraziTakmicare().IzvrsiSO(testTakmicar) as List<Takmicar>;

            foreach (var t in trazeniTakmicari)
            {
                Assert.IsNotNull(t);

                Assert.IsTrue(t.Prezime.Equals(testTakmicar.Prezime));
            }
        }

        [TestMethod]
        public void PretraziTakmicarePoZemljiUspesno()
        {
            var testTakmicar = new VratiJednogTakmicara().IzvrsiSO(new Takmicar()) as Takmicar;
            Assert.IsNotNull(testTakmicar);

            testTakmicar.Uslov = $"Zemlja = {testTakmicar.Zemlja.ZemljaID}";

            var trazeniTakmicari = new PretraziTakmicare().IzvrsiSO(testTakmicar) as List<Takmicar>;

            foreach (var t in trazeniTakmicari)
            {
                Assert.IsNotNull(t);

                Assert.IsTrue(t.Zemlja.ZemljaID.Equals(testTakmicar.Zemlja.ZemljaID));
            }
        }

        [TestMethod]
        public void PretraziTakmicareNeuspesno()
        {
            var ocekivaniRezultat = 0;

            var takmicar = new Takmicar()
            {
                Uslov = "TakmicarID < 0"
            };

            var trazeniTakmicari = new PretraziTakmicare().IzvrsiSO(takmicar) as List<Takmicar>;

            Assert.IsTrue(trazeniTakmicari.Count <= ocekivaniRezultat);
        }
    }
}
