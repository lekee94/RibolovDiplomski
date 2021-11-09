using System;
using System.ComponentModel;
using System.Data;

namespace Biblioteka
{
    [Serializable]
    public class Delegat : IOpstiDomenskiObjekat
    {
        public override string ToString() => $"{ime} {prezime}";

        int delegatID;
        string ime;
        string prezime;
        string username;
        string password;

        [Browsable(false)]
        public int DelegatID
        {
            get => delegatID;
            set => delegatID = value;
        }

        public string Ime
        {
            get => ime;
            set => ime = value;
        }

        public string Prezime
        {
            get => prezime;
            set => prezime = value;
        }

        public string Username
        {
            get => username;
            set => username = value;
        }
        [Browsable(false)]
        public string Password
        {
            get => password;
            set => password = value;
        }

        #region ODO
        [Browsable(false)]
        public string Tabela => "Delegat";

        [Browsable(false)]
        public string Kljuc => null;

        [Browsable(false)]
        public string UslovJedan => " DelegatID=" + delegatID;

        [Browsable(false)]
        public string Uslov;

        [Browsable(false)]
        public string UslovVise => Uslov;

        [Browsable(false)]
        public string Azuriranje => null;

        [Browsable(false)]
        public string Upisivanje => null;

        [Browsable(false)]
        public IOpstiDomenskiObjekat Napuni(DataRow red) => new Delegat
        {
            DelegatID = Convert.ToInt32(red["DelegatID"]),
            Ime = red["Ime"].ToString(),
            Prezime = red["Prezime"].ToString(),
            Username = red["Username"].ToString(),
            Password = red["Password"].ToString()
        };
        #endregion
    }
}
