using System;

namespace Biblioteka
{
    public enum Operacije 
    { 
        Kraj=1,
        PronadjiDelegata = 2,
        IzmeniTakmicara = 3,
        ZapamtiTakmicara = 4,
        ObrisiTakmicara = 5,
        PretraziTakmicare = 6,
        PronadjiTakmicara = 7,
        VratiSveZemlje = 8,
        VratiSveTakmicare = 9,
        VratiSveStaze = 10,
        IzmeniTakmicenje = 11,
        ZapamtiTakmicenje = 12,
        ObrisiTakmicenje = 13,
        PretraziTakmicenja = 14,
        PronadjiTakmicenje = 15,
        GenerisiIzvestaj = 16,
        DajIDTakmicara = 17,
        DajIDTakmicenja = 18
    }

    [Serializable]
    public class TransferKlasa
    {
        Operacije operacija;
        object transferObjekat;

        public Operacije Operacija
        {
            get => operacija;
            set => operacija = value;
        }

        public object TransferObjekat
        {
            get => transferObjekat;
            set => transferObjekat = value;
        }
        object rezultat;

        public object Rezultat
        {
            get => rezultat;
            set => rezultat = value;
        }
    }
}
