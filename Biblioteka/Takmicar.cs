using System;
using System.ComponentModel;
using System.Data;

namespace Biblioteka
{
    public enum Oslovljavanje
    {
        Neodređeno = 0,
        Gospodin = 1,
        Gospođa = 2,
        Gospođica = 3,
    }

    [Serializable]
    public class Takmicar : IOpstiDomenskiObjekat
    {
        public override string ToString() => $"{ime} {prezime}";

        int takmicarID;
        string ime;
        string prezime;
        DateTime datumRodjenja;
        Zemlja zemlja;
        string adresa;
        string postanskiBroj;
        string jmbg;
        string email;
        string brojTelefona;
        Oslovljavanje oslovljavanje;

        [Browsable(false)]
        public int TakmicarID
        {
            get => takmicarID;
            set => takmicarID = value;
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
        public Oslovljavanje Oslovljavanje
        {
            get => oslovljavanje;
            set => oslovljavanje = value;
        }

        [Browsable(false)]
        public string Jmbg
        {
            get => jmbg;
            set => jmbg = value;
        }
        public string Email
        {
            get => email;
            set => email = value;
        }


        public DateTime DatumRodjenja
        {
            get => datumRodjenja;
            set => datumRodjenja = value;
        }

        [Browsable(false)]
        public string BrojTelefona
        {
            get => brojTelefona;
            set => brojTelefona = value;
        }

        [Browsable(false)]
        public Zemlja Zemlja
        {
            get => zemlja;
            set => zemlja = value;
        }

        [Browsable(false)]
        public string Adresa
        {
            get => adresa;
            set => adresa = value;
        }

        [Browsable(false)]
        public string PostanskiBroj
        {
            get => postanskiBroj;
            set => postanskiBroj = value;
        }

        #region ODO
        [Browsable(false)]
        public string Tabela => "Takmicar";

        [Browsable(false)]
        public string Kljuc => "TakmicarID";

        [Browsable(false)]
        public string UslovJedan => " TakmicarID=" + takmicarID;

        [Browsable(false)]
        public string Uslov;

        [Browsable(false)]

        public string UslovVise => Uslov;

        [Browsable(false)]
        public string Azuriranje =>
            $" Ime='{ime}', Prezime='{prezime}', Oslovljavanje={Convert.ToInt32(oslovljavanje)}, Jmbg='{jmbg}', Email='{email}', DatumRodjenja='{datumRodjenja.ToShortDateString()}', BrojTelefona='{brojTelefona}', ZemljaID={zemlja.ZemljaID}, Adresa='{adresa}', PostanskiBroj='{postanskiBroj}'";

        [Browsable(false)]
        public string Upisivanje =>
            $" (TakmicarID, Ime, Prezime, Oslovljavanje, Jmbg, Email, DatumRodjenja, BrojTelefona, ZemljaID, Adresa, PostanskiBroj) values ({takmicarID}, '{ime}', '{prezime}', {Convert.ToInt32(oslovljavanje)}, '{jmbg}', '{email}', '{DatumRodjenja.ToShortDateString()}', '{brojTelefona}', {zemlja.ZemljaID}, '{adresa}', '{postanskiBroj}')";

        public IOpstiDomenskiObjekat Napuni(DataRow red)
        {
            Takmicar t = new Takmicar();
            t.takmicarID = Convert.ToInt32(red["TakmicarID"]);
            t.Ime = red["Ime"].ToString();
            t.Prezime = red["Prezime"].ToString();
            t.Oslovljavanje = (Oslovljavanje)Convert.ToInt32(red["Oslovljavanje"]);
            t.Jmbg = red["Jmbg"].ToString();
            t.Email = red["Email"].ToString();
            t.datumRodjenja =Convert.ToDateTime( red["DatumRodjenja"]);
            t.BrojTelefona = red["BrojTelefona"].ToString();
            t.Zemlja = new Zemlja();
            t.zemlja.ZemljaID=Convert.ToInt32( red["ZemljaID"]);
            t.Adresa = red["Adresa"].ToString();
            t.PostanskiBroj = red["PostanskiBroj"].ToString();
            return t;
        }
        #endregion
    }
}
