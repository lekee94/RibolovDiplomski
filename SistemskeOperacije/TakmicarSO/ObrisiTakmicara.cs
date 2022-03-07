using Biblioteka;

namespace SistemskeOperacije.TakmicarSO
{
    public class ObrisiTakmicara : OpstaSO
    {
        protected override object Izvrsi(IOpstiDomenskiObjekat odo) 
            => Sesija.Broker.DajSesiju().Obrisi(odo);
    }
}
