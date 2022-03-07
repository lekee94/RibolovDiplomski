using Biblioteka;

namespace SistemskeOperacije.TakmicarSO
{
    public class ZapamtiTakmicara : OpstaSO
    {
        protected override object Izvrsi(IOpstiDomenskiObjekat odo)
        {
            var t = odo as Takmicar;

            t.TakmicarID = Sesija.Broker.DajSesiju().DajSifru(odo);

            return Sesija.Broker.DajSesiju().Sacuvaj(t) == 1 ? t : null;
        }
    }
}
