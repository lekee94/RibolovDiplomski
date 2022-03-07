using Biblioteka;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SistemskeOperacije.TakmicenjeSO;
using System.Collections.Generic;

namespace SistemskeOperacije.Test.TakmicenjeSOTests
{
    [TestClass]
    public class VratiSveStazeTest
    {
        [TestMethod]
        public void VratiSveStazeUspesno()
        {
            var ocekivaniRezultat = 1;

            var staze = new VratiSveStaze().IzvrsiSO(new TakmicarskaStaza()) as List<TakmicarskaStaza>;

            Assert.IsTrue(staze != null && staze.Count >= ocekivaniRezultat);
        }
    }
}
