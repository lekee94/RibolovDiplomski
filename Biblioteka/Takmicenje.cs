using System;
using System.ComponentModel;
using System.Data;

namespace Biblioteka
{
    [Serializable]
    public class Takmicenje : IOpstiDomenskiObjekat
    {
        public Takmicenje() => 
            listaTakmicara = new BindingList<Biblioteka.SpisakTakmicara>();

        int takmicenjeID;
        string naziv;
        DateTime datum;
        string kategorija;
        Delegat delegat;
        TakmicarskaStaza staza;
        BindingList<SpisakTakmicara> listaTakmicara;

        [Browsable(false)]
        public int TakmicenjeID
        {
            get => takmicenjeID;
            set => takmicenjeID = value;
        }

        public string Naziv
        {
            get => naziv;
            set => naziv = value;
        }

        public DateTime Datum
        {
            get => datum;
            set => datum = value;
        }

        public string Kategorija
        {
            get => kategorija;
            set => kategorija = value;
        }

        [Browsable(false)]
        public Delegat Delegat
        {
            get => delegat;
            set => delegat = value;
        }

        [Browsable(false)]
        public TakmicarskaStaza Staza
        {
            get => staza;
            set => staza = value;
        }

        public BindingList<SpisakTakmicara> ListaTakmicara
        {
            get => listaTakmicara;
            set => listaTakmicara = value;
        }

        #region ODO
        [Browsable(false)]
        public string Tabela => "Takmicenje";

        [Browsable(false)]
        public string Kljuc => "TakmicenjeID";

        [Browsable(false)]
        public string UslovJedan => " TakmicenjeID=" + TakmicenjeID;

        [Browsable(false)]
        public string Uslov;

        [Browsable(false)]
        public string UslovVise => Uslov;

        [Browsable(false)]
        public string Azuriranje => " Naziv='" + naziv + "', Datum='" + datum.ToShortDateString() + "', Kategorija='" + kategorija + "', Delegat=" + delegat.DelegatID + ",Staza=" + staza.StazaID + "";

        [Browsable(false)]
        public string Upisivanje => $" (TakmicenjeID, Naziv, Datum, Kategorija, Delegat, Staza) values ({takmicenjeID}, '{naziv}', '{datum.ToShortDateString()}', '{kategorija}', {delegat.DelegatID}, {staza.StazaID})";

        public IOpstiDomenskiObjekat Napuni(DataRow red)
        {
            Takmicenje t = new Takmicenje();
            t.TakmicenjeID = Convert.ToInt32(red["TakmicenjeID"]);
            t.Naziv = red["Naziv"].ToString();
            t.Datum = Convert.ToDateTime(red["Datum"]);
            t.Kategorija = red["Kategorija"].ToString();
            t.Delegat = new Delegat();
            t.Delegat.DelegatID = Convert.ToInt32(red["Delegat"]);
            t.Staza = new TakmicarskaStaza();
            t.Staza.StazaID = Convert.ToInt32(red["Staza"]);
            return t;
        }
        #endregion
    }
}
