using Biblioteka;
using System.Linq;

namespace SistemskeOperacije.LoginSO
{
    public class VratiSveDelegate : OpstaSO
    {
        public override object Izvrsi(IOpstiDomenskiObjekat odo) 
            => Sesija.Broker.DajSesiju().DajSve(odo).OfType<Delegat>().ToList();
    }
}
