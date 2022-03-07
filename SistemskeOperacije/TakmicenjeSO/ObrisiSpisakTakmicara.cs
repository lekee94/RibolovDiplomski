using Biblioteka;

namespace SistemskeOperacije.TakmicenjeSO
{
    public class ObrisiSpisakTakmicara : OpstaSO
    {
        protected override object Izvrsi(IOpstiDomenskiObjekat odo)
            => Sesija.Broker.DajSesiju().Obrisi(odo);
    }
}
