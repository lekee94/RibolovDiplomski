using Biblioteka;

namespace SistemskeOperacije.TakmicarSO
{
    public class IzmeniTakmicara : OpstaSO
    {
        public override object Izvrsi(IOpstiDomenskiObjekat odo) 
            => Sesija.Broker.DajSesiju().Izmeni(odo);
    }
}
