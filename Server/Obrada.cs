using System;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using Biblioteka;
using System.Threading;
using SistemskeOperacije.LoginSO;
using SistemskeOperacije.TakmicarSO;
using SistemskeOperacije.TakmicenjeSO;

namespace Server
{
    public class Obrada
    {
        BinaryFormatter formater;
        NetworkStream tok;
        Delegat d;

        public Obrada(NetworkStream tok)
        {
            this.tok = tok;
            formater = new BinaryFormatter();

            ThreadStart ts = ObradiKlijenta;
            var nit = new Thread(ts);
            nit.Start();
        }

        private void ObradiKlijenta()
        {
            try
            {
                var operacija = 0;
                while (operacija != (int)Operacije.Kraj)
                {
                    var transfer = formater.Deserialize(tok) as TransferKlasa;
                    switch (transfer.Operacija)
                    {
                        case Operacije.PronadjiDelegata:
                            var pd = new PronadjiDelegata();
                            transfer.Rezultat = pd.IzvrsiSO(transfer.TransferObjekat as IOpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            d = transfer.Rezultat as Delegat;
                            if (d != null) Server.listaUlogovanihDelegata.Add(d);
                            break;

                        case Operacije.ZapamtiTakmicara:
                            var zt = new ZapamtiTakmicara();
                            transfer.Rezultat = zt.IzvrsiSO(transfer.TransferObjekat as IOpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.IzmeniTakmicara:
                            var it = new IzmeniTakmicara();
                            transfer.Rezultat = it.IzvrsiSO(transfer.TransferObjekat as IOpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.GenerisiIzvestaj:
                            var gi = new GenerisiIzvestaj();
                            transfer.Rezultat = gi.IzvrsiSO(transfer.TransferObjekat as IOpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.ObrisiTakmicara:
                            var ot = new ObrisiTakmicara();
                            transfer.Rezultat = ot.IzvrsiSO(transfer.TransferObjekat as IOpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.ObrisiSpisakTakmicara:
                            var ost = new ObrisiSpisakTakmicara();
                            transfer.Rezultat = ost.IzvrsiSO(transfer.TransferObjekat as IOpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                            
                        case Operacije.PretraziTakmicare:
                            var pt = new PretraziTakmicare();
                            transfer.Rezultat = pt.IzvrsiSO(transfer.TransferObjekat as IOpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.PronadjiTakmicara:
                            var prot = new PronadjiTakmicara();
                            transfer.Rezultat = prot.IzvrsiSO(transfer.TransferObjekat as IOpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.VratiSveZemlje:
                            var vsz = new VratiSveZemlje();
                            transfer.Rezultat = vsz.IzvrsiSO(transfer.TransferObjekat as IOpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.VratiSveTakmicare:
                            var vst = new VratiSveTakmicare();
                            transfer.Rezultat = vst.IzvrsiSO(transfer.TransferObjekat as IOpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.VratiSveStaze:
                            var vss = new VratiSveStaze();
                            transfer.Rezultat = vss.IzvrsiSO(transfer.TransferObjekat as IOpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.ZapamtiTakmicenje:
                            var ztk = new ZapamtiTakmicenje();
                            transfer.Rezultat = ztk.IzvrsiSO(transfer.TransferObjekat as IOpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.IzmeniTakmicenje:
                            var itakmicenje = new IzmeniTakmicenje();
                            transfer.Rezultat = itakmicenje.IzvrsiSO(transfer.TransferObjekat as IOpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.ObrisiTakmicenje:
                            var obt = new ObrisiTakmicenje();
                            transfer.Rezultat = obt.IzvrsiSO(transfer.TransferObjekat as IOpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.PretraziTakmicenja:
                            var ptt = new PretraziTakmicenja();
                            transfer.Rezultat = ptt.IzvrsiSO(transfer.TransferObjekat as IOpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.PronadjiTakmicenje:
                            var prt = new PronadjiTakmicenje();
                            transfer.Rezultat = prt.IzvrsiSO(transfer.TransferObjekat as IOpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.Kraj:
                            operacija = 1;
                            Server.listaUlogovanihDelegata.Remove(d);
                            break;
                    }
                }
            }
            catch (Exception)
            {
                Server.listaUlogovanihDelegata.Remove(d);
            }
        }
    }
}
