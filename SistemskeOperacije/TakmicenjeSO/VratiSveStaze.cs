using System.Linq;
using Biblioteka;

namespace SistemskeOperacije.TakmicenjeSO
{
    public class VratiSveStaze : OpstaSO
    {
        public override object Izvrsi(IOpstiDomenskiObjekat odo) 
            => Sesija.Broker.DajSesiju().DajSve(odo).OfType<TakmicarskaStaza>().ToList();
    }
}
