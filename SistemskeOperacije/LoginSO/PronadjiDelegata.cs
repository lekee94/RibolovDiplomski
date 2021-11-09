using Biblioteka;

namespace SistemskeOperacije.LoginSO
{
    public class PronadjiDelegata : OpstaSO
    {
        public override object Izvrsi(IOpstiDomenskiObjekat odo) 
            => Sesija.Broker.DajSesiju().DajZaUslovVise(odo);
    }
}
