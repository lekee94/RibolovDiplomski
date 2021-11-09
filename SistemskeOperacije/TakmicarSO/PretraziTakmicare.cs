using System.Linq;
using Biblioteka;

namespace SistemskeOperacije.TakmicarSO
{
    public class PretraziTakmicare : OpstaSO
    {
        public override object Izvrsi(IOpstiDomenskiObjekat odo) 
            => Sesija.Broker.DajSesiju().DajSveZaUslovVise(odo).OfType<Takmicar>().ToList();
    }
}
