using Biblioteka;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SistemskeOperacije.TakmicenjeSO;
using System;

namespace SistemskeOperacije.Test.TakmicenjeSOTests
{
    [TestClass]
    public class IzmeniTakmicenjeTest
    {
        [TestMethod]
        public void IzmeniTakmicenjeUspesno()
        {
            var ocekivaniRezultat = 1;

            const string testStringSufiks = "TEST";

            var takmicenjeZaIzmenu = new VratiJednoTakmicenje().IzvrsiSO(new Takmicenje()) as Takmicenje;
            Assert.IsNotNull(takmicenjeZaIzmenu);

            var izmenjenoTakmicenje = new Takmicenje()
            {
                TakmicenjeID = takmicenjeZaIzmenu.TakmicenjeID,
                Naziv = takmicenjeZaIzmenu.Naziv + testStringSufiks,
                Kategorija = takmicenjeZaIzmenu.Kategorija,
                Datum = DateTime.Now.AddDays(1),
                Staza = new TakmicarskaStaza { StazaID = 1 },
                Delegat = new Delegat { DelegatID = 1 },
            };

            var rezultat = new IzmeniTakmicenje().IzvrsiSO(izmenjenoTakmicenje);

            Assert.IsTrue(Convert.ToInt32(rezultat) == ocekivaniRezultat);
        }

        [TestMethod]
        public void IzmeniTakmicenjeKojeNePostojiNeuspesno()
        {
            var ocekivaniRezultat = 0;
            const string testString = "IzmeniTakmicenjeKojeNePostojiNeuspesnoTEST";

            var izmenjenoTakmicenje = new Takmicenje()
            {
                TakmicenjeID = -1,
                Naziv = testString,
                Datum = DateTime.Now,
                Kategorija = "Seniori",
                Delegat = new Delegat { DelegatID = 1},
                Staza = new TakmicarskaStaza { StazaID = 1}
            };

            var rezultat = new IzmeniTakmicenje().IzvrsiSO(izmenjenoTakmicenje);

            Assert.IsTrue(Convert.ToInt32(rezultat) == ocekivaniRezultat);
        }
    }
}
