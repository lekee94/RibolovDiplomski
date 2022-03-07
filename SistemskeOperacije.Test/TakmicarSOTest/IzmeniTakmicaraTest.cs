using Biblioteka;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SistemskeOperacije.TakmicarSO;
using System;

namespace SistemskeOperacije.Test.TakmicarSOTest
{
    [TestClass]
    public class IzmeniTakmicaraTest
    {
        [TestMethod]
        public void IzmeniTakmicaraUspesno()
        {
            var ocekivaniRezultat = 1;

            const string testStringSufiks = "TEST";
            const string testBrojSufiks = "000";

            var takmicarZaIzmenu = new VratiJednogTakmicara().IzvrsiSO(new Takmicar()) as Takmicar;
            Assert.IsNotNull(takmicarZaIzmenu);

            var izmenjenTakmicar = new Takmicar()
            {
                TakmicarID = takmicarZaIzmenu.TakmicarID,
                Ime = takmicarZaIzmenu.Ime + testStringSufiks,
                Prezime = takmicarZaIzmenu.Prezime + testStringSufiks,
                Oslovljavanje = Oslovljavanje.Neodređeno,
                Jmbg = takmicarZaIzmenu.Jmbg + testBrojSufiks,
                Email = takmicarZaIzmenu.Email + testStringSufiks,
                DatumRodjenja = takmicarZaIzmenu.DatumRodjenja.AddDays(1),
                BrojTelefona = takmicarZaIzmenu.BrojTelefona + testBrojSufiks,
                Zemlja = takmicarZaIzmenu.Zemlja,
                Adresa = takmicarZaIzmenu.Adresa + testStringSufiks,
                PostanskiBroj = takmicarZaIzmenu.PostanskiBroj + testBrojSufiks
            };

            var rezultat = new IzmeniTakmicara().IzvrsiSO(izmenjenTakmicar);

            Assert.IsTrue(Convert.ToInt32(rezultat) == ocekivaniRezultat);
        }

        [TestMethod]
        public void IzmeniTakmicaraKojiNePostojiNeuspesno()
        {
            var ocekivaniRezultat = 0;
            const string testString = "IzmeniTakmicaraKojiNePostojiNeuspesnoTEST";
            const string testBroj = "123456789";

            var izmenjenTakmicar = new Takmicar()
            {
                TakmicarID = -1,
                Ime = testString,
                Prezime = testString,
                Oslovljavanje = Oslovljavanje.Neodređeno,
                Jmbg = testBroj,
                Email = testString + "@gmail.com",
                DatumRodjenja = DateTime.Now.AddYears(-20),
                BrojTelefona = testBroj,
                Zemlja = new Zemlja { ZemljaID = 1},
                Adresa = testString,
                PostanskiBroj = testBroj
            };

            var rezultat = new IzmeniTakmicara().IzvrsiSO(izmenjenTakmicar);

            Assert.IsTrue(Convert.ToInt32(rezultat) == ocekivaniRezultat);
        }

    }
}
