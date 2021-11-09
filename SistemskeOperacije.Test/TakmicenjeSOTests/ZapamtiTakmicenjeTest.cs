using Biblioteka;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SistemskeOperacije.TakmicenjeSO;
using System;

namespace SistemskeOperacije.Test.TakmicenjeSOTests
{
    [TestClass]
    public class ZapamtiTakmicenjeTest
    {
        [TestMethod]
        public void ZapamtiTakmicenjeUspesno()
        {
            var ocekivaniRezultat = 1;

            var takmicenjeID = new Random().Next(500, 5000);

            var takmicenje = new Takmicenje()
            {
                TakmicenjeID = takmicenjeID,
                Naziv = "Test Naziv",
                Kategorija = "Seniori",
                Datum = DateTime.Now,
                Staza = new TakmicarskaStaza() { StazaID = 1},
                Delegat = new Delegat() { DelegatID = 1},
            };

            var rezultat = new ZapamtiTakmicenje().IzvrsiSO(takmicenje);

            var rezultatZaPoredjenje = Convert.ToInt32(rezultat);

            Assert.IsNotNull(rezultatZaPoredjenje == ocekivaniRezultat);
        }
    }
}
