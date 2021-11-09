using Biblioteka;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SistemskeOperacije.TakmicarSO;
using System.Collections.Generic;

namespace SistemskeOperacije.Test.TakmicarSOTest
{
    [TestClass]
    public class VratiSveZemljeTest
    {
        [TestMethod]
        public void VratiSveZemljeUspesno()
        {
            var ocekivaniRezultat = 1;

            var zemlje = new VratiSveZemlje().IzvrsiSO(new Zemlja()) as List<Zemlja>;

            Assert.IsTrue(zemlje.Count >= ocekivaniRezultat);
        }
    }
}
