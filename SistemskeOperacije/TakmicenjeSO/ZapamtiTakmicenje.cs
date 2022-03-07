using Biblioteka;

namespace SistemskeOperacije.TakmicenjeSO
{
    public class ZapamtiTakmicenje : OpstaSO
    {
        protected override object Izvrsi(IOpstiDomenskiObjekat odo)
        {
            var t = odo as Takmicenje;

            t.TakmicenjeID = Sesija.Broker.DajSesiju().DajSifru(odo);

            Sesija.Broker.DajSesiju().Sacuvaj(odo); 

            foreach (var sp in t.ListaTakmicara)
            {
                switch (sp.Status)
                {

                    case Status.Dodat:
                        sp.TakmicenjeID = t.TakmicenjeID;
                        Sesija.Broker.DajSesiju().Sacuvaj(sp);
                        break;
                    case Status.Obrisan:
                        Sesija.Broker.DajSesiju().Obrisi(sp);
                        break;
                    case Status.Izmenjen:
                        Sesija.Broker.DajSesiju().Izmeni(sp);
                        break;
                    case Status.Nepromenjen:
                        break;
                    default:
                        break;
                }
            }

            return 1;
        }
    }
}
