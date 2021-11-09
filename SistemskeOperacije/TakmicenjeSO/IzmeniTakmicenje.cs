using Biblioteka;

namespace SistemskeOperacije.TakmicenjeSO
{
    public class IzmeniTakmicenje : OpstaSO
    {
        public override object Izvrsi(IOpstiDomenskiObjekat odo)
        {
            Takmicenje t = odo as Takmicenje;
            foreach (SpisakTakmicara sp in t.ListaTakmicara)
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
                }
            }

            return Sesija.Broker.DajSesiju().Izmeni(odo);
        }
    }
}
