using System.Linq;
using Biblioteka;

namespace SistemskeOperacije.TakmicenjeSO
{
    public class VratiSveTakmicare : OpstaSO
    {
        public override object Izvrsi(IOpstiDomenskiObjekat odo)
        {
            Takmicar t = new Takmicar();
            t.Uslov = "Ime is null";
            Sesija.Broker.DajSesiju().ObrisiZaUslovVise(t);
            return Sesija.Broker.DajSesiju().DajSve(odo).OfType<Takmicar>().ToList();
        }
    }
}
