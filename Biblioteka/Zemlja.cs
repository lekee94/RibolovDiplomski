using System;
using System.Data;

namespace Biblioteka
{
    [Serializable]
    public class Zemlja : IOpstiDomenskiObjekat
    {
        int zemljaID;
        string naziv;

        public override string ToString() => naziv;

        public int ZemljaID
        {
            get => zemljaID;
            set => zemljaID = value;
        }

        public string Naziv
        {
            get => naziv;
            set => naziv = value;
        }

        #region ODO
        public string Tabela => "Zemlja";

        public string Kljuc => null;

        public string UslovJedan => " ZemljaID=" + zemljaID;

        public string Uslov;

        public string UslovVise => Uslov;

        public string Azuriranje => null;

        public string Upisivanje => null;

        public IOpstiDomenskiObjekat Napuni(DataRow red) => new Zemlja
        {
            ZemljaID = Convert.ToInt32(red["ZemljaID"]),
            Naziv = red["Naziv"].ToString()
        };

        public override bool Equals(object obj) =>
            obj is Zemlja zemlja && zemljaID == zemlja.zemljaID;
        #endregion
    }
}
