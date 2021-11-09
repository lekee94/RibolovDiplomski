using Biblioteka;

namespace SistemskeOperacije.TakmicarSO
{
    public class ObrisiTakmicara : OpstaSO
    {
        public override object Izvrsi(IOpstiDomenskiObjekat odo) 
            => Sesija.Broker.DajSesiju().Obrisi(odo);
    }
}
