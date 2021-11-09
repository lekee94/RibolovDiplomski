using Biblioteka;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SistemskeOperacije.TakmicarSO;

namespace SistemskeOperacije.Test.TakmicarSOTest
{
    [TestClass]
    public class PronadjiTakmicaraTest
    {
        [TestMethod]
        public void PronadjiTakmicaraUspesno()
        {
            var takmicarPretraga = new VratiJednogTakmicara().IzvrsiSO(new Takmicar()) as Takmicar;
            Assert.IsNotNull(takmicarPretraga);

            var takmicar = new PronadjiTakmicara().IzvrsiSO(takmicarPretraga) as Takmicar;

            Assert.IsNotNull(takmicar);
            Assert.IsTrue(takmicar.TakmicarID == takmicarPretraga.TakmicarID);
        }

        [TestMethod]
        public void PronadjiTakmicaraNeuspesno()
        {
            var takmicarPretraga = new Takmicar();

            var takmicar = new PronadjiTakmicara().IzvrsiSO(takmicarPretraga) as Takmicar;

            Assert.IsNull(takmicar);
        }
    }
}
