using Biblioteka;
using System.Linq;

namespace SistemskeOperacije.TakmicarSO
{
    public class VratiJednogTakmicara : OpstaSO
    {
        public override object Izvrsi(IOpstiDomenskiObjekat odo) 
            => (Sesija.Broker.DajSesiju().DajSve(odo).OfType<Takmicar>().ToList()).FirstOrDefault();
    }
}
