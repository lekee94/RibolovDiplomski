using Biblioteka;
using System.Linq;

namespace SistemskeOperacije.LoginSO
{
    public class VratiSveDelegate : OpstaSO
    {
        protected override object Izvrsi(IOpstiDomenskiObjekat odo) 
            => Sesija.Broker.DajSesiju().DajSve(odo).OfType<Delegat>().ToList();
    }
}
