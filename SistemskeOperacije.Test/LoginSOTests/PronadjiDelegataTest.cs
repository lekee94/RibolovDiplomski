using Biblioteka;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SistemskeOperacije.LoginSO;
using System.Collections.Generic;
using System.Linq;

namespace SistemskeOperacije.Test.LoginSOTests
{
    [TestClass]
    public class PronadjiDelegataTest
    {
        [TestMethod]
        public void PronadjiDelegataUspesno()
        {
            var delegati = new VratiSveDelegate().IzvrsiSO(new Delegat()) as List<Delegat>;
            var delegatUslov = delegati.FirstOrDefault();
            delegatUslov.Uslov = $"DelegatID = {delegatUslov.DelegatID}";

            Assert.IsNotNull(delegatUslov);

            var delegatRezultat = new PronadjiDelegata().IzvrsiSO(delegatUslov) as Delegat;

            Assert.IsNotNull(delegatRezultat);
            Assert.IsTrue(delegatUslov.DelegatID == delegatRezultat.DelegatID);
        }

        [TestMethod]
        public void PronadjiDelegataNeuspesno()
        {
            var nevalidanDelegatID = -1;

            var delegatUslov = new Delegat()
            {
                DelegatID = nevalidanDelegatID,
                Uslov = $"DelegatID = {nevalidanDelegatID}"
            };

            var delegatRezultat = new PronadjiDelegata().IzvrsiSO(delegatUslov) as Delegat;

            Assert.IsNull(delegatRezultat);
        }
    }
}
