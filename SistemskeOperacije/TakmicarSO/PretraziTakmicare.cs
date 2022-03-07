using System.Linq;
using Biblioteka;

namespace SistemskeOperacije.TakmicarSO
{
    public class PretraziTakmicare : OpstaSO
    {
        protected override object Izvrsi(IOpstiDomenskiObjekat odo) 
            => Sesija.Broker.DajSesiju().DajSveZaUslovVise(odo).OfType<Takmicar>().ToList();
    }
}
