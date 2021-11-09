using Biblioteka;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SistemskeOperacije.LoginSO;
using System.Collections.Generic;

namespace SistemskeOperacije.Test.LoginSOTests
{
    [TestClass]
    public class VratiSveDelegateTest
    {
        [TestMethod]
        public void VratiSveDelegateUspesno() 
        {
            var ocekivaniRezultat = 1;

            var delegati = new VratiSveDelegate().IzvrsiSO(new Delegat()) as List<Delegat>;

            Assert.IsTrue(delegati.Count >= ocekivaniRezultat);
        }
    }
}
