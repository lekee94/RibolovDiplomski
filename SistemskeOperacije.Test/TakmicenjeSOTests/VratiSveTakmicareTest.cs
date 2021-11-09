using Biblioteka;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SistemskeOperacije.TakmicenjeSO;
using System.Collections.Generic;

namespace SistemskeOperacije.Test.TakmicenjeSOTests
{
    [TestClass]
    public class VratiSveTakmicareTest
    {
        [TestMethod]
        public void VratiSveTakmicareUspesno()
        {
            var ocekivaniRezultat = 1;

            var takmicari = new VratiSveTakmicare().IzvrsiSO(new Takmicar()) as List<Takmicar>;

            Assert.IsTrue(takmicari.Count >= ocekivaniRezultat);
        }
    }
}
