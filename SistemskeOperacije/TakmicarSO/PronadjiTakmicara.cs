using Biblioteka;

namespace SistemskeOperacije.TakmicarSO
{
    public class PronadjiTakmicara : OpstaSO
    {
        protected override object Izvrsi(IOpstiDomenskiObjekat odo)
        {
            var t = odo as Takmicar;
            t.Zemlja = Sesija.Broker.DajSesiju().DajZaUslovJedan(t.Zemlja) as Zemlja;
            return t;
        }
    }
}
