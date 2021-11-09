using System;
using System.ComponentModel;
using System.Data;

namespace Biblioteka
{
    public enum TipTrke
    {
        Kanal = 1,
        Arena = 2,
        Reka = 3,
        Jezero = 4,
        More = 5
    }

    [Serializable]
    public class TakmicarskaStaza : IOpstiDomenskiObjekat
    {
        public override string ToString() => naziv + "-" + lokacija;

        int stazaID;
        string naziv;
        string lokacija;
        Zemlja zemlja;
        TipTrke tipTrke;

        public int StazaID
        {
            get => stazaID;
            set => stazaID = value;
        }

        public string Naziv
        {
            get => naziv;
            set => naziv = value;
        }

        public string Lokacija
        {
            get => lokacija;
            set => lokacija = value;
        }

        public TipTrke TipTrke
        {
            get => tipTrke;
            set => tipTrke = value;
        }

        public Zemlja Zemlja
        {
            get => zemlja;
            set => zemlja = value;
        }

        #region ODO
        [Browsable(false)]
        public string Tabela => "Staza";

        [Browsable(false)]
        public string Kljuc => null;

        [Browsable(false)]
        public string UslovJedan => " StazaID=" + stazaID;

        [Browsable(false)]
        public string Uslov;

        [Browsable(false)]
        public string UslovVise => Uslov;

        [Browsable(false)]
        public string Azuriranje => null;

        [Browsable(false)]
        public string Upisivanje => null;

        public IOpstiDomenskiObjekat Napuni(DataRow red)
        {
            TakmicarskaStaza ts = new TakmicarskaStaza();
            ts.StazaID = Convert.ToInt32(red["StazaID"]);
            ts.Naziv = red["Naziv"].ToString();
            ts.Lokacija = red["Lokacija"].ToString();
            ts.tipTrke = (TipTrke)Convert.ToInt32(red["Tip"]);
            ts.Zemlja = new Zemlja();
            ts.zemlja.ZemljaID = Convert.ToInt32(red["ZemljaID"]);
            return ts;
        }
        #endregion
    }
}
