using Biblioteka;
using System.Linq;

namespace SistemskeOperacije.TakmicenjeSO
{
    public class ObrisiTakmicenje : OpstaSO
    {
        protected override object Izvrsi(IOpstiDomenskiObjekat odo)
        {
            var t = odo as Takmicenje;

            var st = new SpisakTakmicara
            {
                Uslov = " TakmicenjeID =" + t.TakmicenjeID + " order by Rang asc"
            };

            var lista = Sesija.Broker.DajSesiju().DajSveZaUslovVise(st).OfType<SpisakTakmicara>().ToList();

            foreach (var sp in lista)
                Sesija.Broker.DajSesiju().Obrisi(sp);

            return Sesija.Broker.DajSesiju().Obrisi(odo);
        }
    }
}
