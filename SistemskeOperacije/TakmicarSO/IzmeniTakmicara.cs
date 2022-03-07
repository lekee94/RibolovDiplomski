using Biblioteka;

namespace SistemskeOperacije.TakmicarSO
{
    public class IzmeniTakmicara : OpstaSO
    {
        protected override object Izvrsi(IOpstiDomenskiObjekat odo) 
            => Sesija.Broker.DajSesiju().Izmeni(odo);
    }
}
