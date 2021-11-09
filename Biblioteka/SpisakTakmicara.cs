using System;
using System.ComponentModel;
using System.Data;

namespace Biblioteka
{
    public enum Status 
    { 
        Nepromenjen,
        Dodat,
        Obrisan, 
        Izmenjen 
    }

    [Serializable]
    public class SpisakTakmicara : IOpstiDomenskiObjekat
    {
        int takmicenjeID;
        int redniBroj;
        int ulov;
        int rang;
        Takmicar takmicar;
        Status status;

        public override string ToString() => takmicar.ToString();

        [Browsable(false)]
        public int TakmicenjeID
        {
            get => takmicenjeID;
            set => takmicenjeID = value;
        }

        public int RedniBroj
        {
            get => redniBroj;
            set => redniBroj = value;
        }

        public int Ulov
        {
            get => ulov;
            set => ulov = value;
        }

        public int Rang
        {
            get => rang;
            set => rang = value;
        }

        public Takmicar Takmicar
        {
            get => takmicar;
            set => takmicar = value;
        }

        public Status Status
        {
            get => status;
            set => status = value;
        }

        #region ODO
        [Browsable(false)]
        public string Tabela => "SpisakTakmicara";

        [Browsable(false)]
        public string Kljuc => null;

        [Browsable(false)]
        public string UslovJedan => " TakmicenjeID=" + TakmicenjeID + " and RedniBroj=" + redniBroj;
        
        [Browsable(false)]
        public string Uslov;

        [Browsable(false)]
        public string UslovVise => Uslov;

        [Browsable(false)]
        public string Azuriranje => " Ulov=" + ulov + ", Rang=" + rang + ", TakmicarID=" + takmicar.TakmicarID + "";

        [Browsable(false)]
        public string Upisivanje => "  values (" + TakmicenjeID + "," + redniBroj + "," + Ulov + "," + Rang + "," + takmicar.TakmicarID + ")";

        public IOpstiDomenskiObjekat Napuni(DataRow red)
        {
            SpisakTakmicara st = new SpisakTakmicara();
            st.TakmicenjeID = Convert.ToInt32(red["TakmicenjeID"]);
            st.RedniBroj = Convert.ToInt32(red["RedniBroj"]);
            st.Ulov =Convert.ToInt32( red["Ulov"]);
            st.Rang = Convert.ToInt32(red["Rang"]);
            st.Takmicar = new Takmicar();
            st.takmicar.TakmicarID = Convert.ToInt32(red["TakmicarID"]);
            return st;
        }
        #endregion
    }
}
