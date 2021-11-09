using System.Linq;
using Biblioteka;

namespace SistemskeOperacije.TakmicarSO
{
    public class VratiSveZemlje : OpstaSO
    {
        public override object Izvrsi(IOpstiDomenskiObjekat odo) 
            => Sesija.Broker.DajSesiju().DajSve(odo).OfType<Zemlja>().ToList();
    }
}
