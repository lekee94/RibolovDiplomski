using Biblioteka;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SistemskeOperacije.TakmicarSO;
using System;

namespace SistemskeOperacije.Test.TakmicarSOTest
{
    [TestClass]
    public class ZapamtiTakmicaraTest
    {
        [TestMethod]
        public void ZapamtiTakmicaraUspesno()
        {
            var takmicarID = new Random().Next(500, 5000);

            var takmicar = new Takmicar
            {
                TakmicarID = takmicarID,
                Ime = "Test Ime",
                Prezime = "Test Prezime",
                DatumRodjenja = DateTime.Now,
                Zemlja = new Zemlja() 
                {
                    ZemljaID = 1
                }
            };

            var rezultat = new ZapamtiTakmicara().IzvrsiSO(takmicar) as Takmicar;

            Assert.IsTrue(rezultat != null);
        }
    }
}
