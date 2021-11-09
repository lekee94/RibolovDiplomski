using Biblioteka;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SistemskeOperacije.TakmicenjeSO;
using System;

namespace SistemskeOperacije.Test.TakmicenjeSOTests
{
    [TestClass]
    public class ObrisiTakmicenjeTest
    {
        [TestMethod]
        public void ObrisiTakmicenjeUspesno() 
        {
            var takmicenje = new VratiJednoTakmicenje().IzvrsiSO(new Takmicenje()) as Takmicenje;
            Assert.IsNotNull(takmicenje);

            var ocekivaniRezultat = 1;

            var obrisiTakmicenje = new ObrisiTakmicenje();
            var rezultat = obrisiTakmicenje.IzvrsiSO(takmicenje);

            Assert.IsTrue(Convert.ToInt32(rezultat) == ocekivaniRezultat);
        }

        [TestMethod]
        public void ObrisiTakmicenjeNeuspesno()
        {
            var takmicenje = new Takmicenje()
            {
                TakmicenjeID = -1,
            };

            var ocekivaniRezultat = 0;

            var obrisiTakmicenje = new ObrisiTakmicenje();
            var rezultat = obrisiTakmicenje.IzvrsiSO(takmicenje);

            Assert.IsTrue(Convert.ToInt32(rezultat) == ocekivaniRezultat);
        }
    }
}
