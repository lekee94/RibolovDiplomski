using Biblioteka;
using System.Linq;

namespace SistemskeOperacije.TakmicenjeSO
{
    public class VratiJednoTakmicenje : OpstaSO
    {
        public override object Izvrsi(IOpstiDomenskiObjekat odo) 
            => (Sesija.Broker.DajSesiju().DajSve(odo).OfType<Takmicenje>().ToList()).FirstOrDefault();
    }
}
