using System.Linq;
using Biblioteka;

namespace SistemskeOperacije.TakmicenjeSO
{
    public class PretraziTakmicenja : OpstaSO
    {
        public override object Izvrsi(IOpstiDomenskiObjekat odo)
            => Sesija.Broker.DajSesiju().DajSveZaUslovVise(odo).OfType<Takmicenje>().ToList<Takmicenje>();
    }
}
