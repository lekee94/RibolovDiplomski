using Biblioteka;

namespace SistemskeOperacije.TakmicarSO
{
    public class PronadjiTakmicara : OpstaSO
    {
        public override object Izvrsi(IOpstiDomenskiObjekat odo)
        {
            Takmicar t = odo as Takmicar;
            t.Zemlja = Sesija.Broker.DajSesiju().DajZaUslovJedan(t.Zemlja) as Zemlja;
            return t;
        }
    }
}
