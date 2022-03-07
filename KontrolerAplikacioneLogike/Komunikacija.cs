using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.Net.Sockets;
using Biblioteka;

namespace Komunikacija
{
    public class Komunikacija
    {
        TcpClient klijent;
        BinaryFormatter formater;
        NetworkStream tok;

        public bool PoveziSeNaServer()
        {
            try
            {
                klijent = new TcpClient("127.0.0.1", 20000);
                tok = klijent.GetStream();
                formater = new BinaryFormatter();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


        public void Kraj() 
        {
            var transfer = new TransferKlasa
            {
                Operacija = Operacije.Kraj
            };
            formater.Serialize(tok, transfer);
        }

        public object PronadjiDelegata(Delegat d)
        {
            var transfer = new TransferKlasa
            {
                Operacija = Operacije.PronadjiDelegata,
                TransferObjekat = d
            };
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat;
        }

        public object ZapamtiTakmicara(Takmicar t)
        {

            var transfer = new TransferKlasa
            {
                Operacija = Operacije.ZapamtiTakmicara,
                TransferObjekat = t
            };
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat;
        }

        public object IzmeniTakmicara(Takmicar t)
        {

            var transfer = new TransferKlasa
            {
                Operacija = Operacije.IzmeniTakmicara,
                TransferObjekat = t
            };
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat;
        }

        public object ObrisiTakmicara(Takmicar t)
        {

            var transfer = new TransferKlasa
            {
                Operacija = Operacije.ObrisiTakmicara,
                TransferObjekat = t
            };
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat;
        }

        public object PronadjiTakmicara(Takmicar t)
        {

            var transfer = new TransferKlasa
            {
                Operacija = Operacije.PronadjiTakmicara,
                TransferObjekat = t
            };
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat;
        }

        public object PretraziTakmicare(Takmicar t)
        {

            var transfer = new TransferKlasa
            {
                Operacija = Operacije.PretraziTakmicare,
                TransferObjekat = t
            };
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat;
        }

        public object VratiSveZemlje()
        {

            var transfer = new TransferKlasa
            {
                Operacija = Operacije.VratiSveZemlje,
                TransferObjekat = new Zemlja()
            };
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat;
        }

        public object VratiSveTakmicare()
        {

            var transfer = new TransferKlasa
            {
                Operacija = Operacije.VratiSveTakmicare,
                TransferObjekat = new Takmicar()
            };
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat;
        }

        public object VratiSveStaze()
        {

            var transfer = new TransferKlasa
            {
                Operacija = Operacije.VratiSveStaze,
                TransferObjekat = new TakmicarskaStaza()
            };
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat;
        }

        public object ZapamtiTakmicenje(Takmicenje t)
        {

            var transfer = new TransferKlasa
            {
                Operacija = Operacije.ZapamtiTakmicenje,
                TransferObjekat = t
            };
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat;
        }

        public object IzmeniTakmicenje(Takmicenje t)
        {

            var transfer = new TransferKlasa
            {
                Operacija = Operacije.IzmeniTakmicenje,
                TransferObjekat = t
            };
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat;
        }

        public object GenerisiIzvestaj(Takmicenje t)
        {

            var transfer = new TransferKlasa
            {
                Operacija = Operacije.GenerisiIzvestaj,
                TransferObjekat = t
            };
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat;
        }

        public object ObrisiTakmicenje(Takmicenje t)
        {

            var transfer = new TransferKlasa
            {
                Operacija = Operacije.ObrisiTakmicenje,
                TransferObjekat = t
            };
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat;
        }
        public object ObrisiSpisakTakmicara(SpisakTakmicara sp)
        {

            var transfer = new TransferKlasa
            {
                Operacija = Operacije.ObrisiSpisakTakmicara,
                TransferObjekat = sp
            };
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat;
        }

        public object PretraziTakmicenja(Takmicenje t)
        {

            var transfer = new TransferKlasa
            {
                Operacija = Operacije.PretraziTakmicenja,
                TransferObjekat = t
            };
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat;
        }

        public object PronadjiTakmicenje(Takmicenje t)
        {

            var transfer = new TransferKlasa
            {
                Operacija = Operacije.PronadjiTakmicenje,
                TransferObjekat = t
            };
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat;
        }
    }
}
