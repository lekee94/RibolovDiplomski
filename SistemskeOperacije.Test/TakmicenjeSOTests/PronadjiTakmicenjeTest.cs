using Biblioteka;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SistemskeOperacije.TakmicenjeSO;

namespace SistemskeOperacije.Test.TakmicenjeSOTests
{
    [TestClass]
    public class PronadjiTakmicenjeTest
    {
        [TestMethod]
        public void PronadjiTakmicenjeUspesno()
        {
            var takmicenjePretraga = new VratiJednoTakmicenje().IzvrsiSO(new Takmicenje()) as Takmicenje;
            Assert.IsNotNull(takmicenjePretraga);

            var takmicenje = new PronadjiTakmicenje().IzvrsiSO(takmicenjePretraga) as Takmicenje;

            Assert.IsNotNull(takmicenje);
            Assert.IsTrue(takmicenje.TakmicenjeID == takmicenjePretraga.TakmicenjeID);
        }

        [TestMethod]
        public void PronadjiTakmicenjeNeuspesno()
        {
            var takmicenjePretraga = new Takmicenje();

            var takmicenje = new PronadjiTakmicenje().IzvrsiSO(takmicenjePretraga) as Takmicenje;

            Assert.IsNull(takmicenje);
        }
    }
}
