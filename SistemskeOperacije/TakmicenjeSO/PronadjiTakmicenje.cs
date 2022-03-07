using System.Collections.Generic;
using System.Linq;
using Biblioteka;

namespace SistemskeOperacije.TakmicenjeSO
{
    public class PronadjiTakmicenje : OpstaSO
    {
        protected override object Izvrsi(IOpstiDomenskiObjekat odo)
        {
            var t = odo as Takmicenje;
            t.Delegat = Sesija.Broker.DajSesiju().DajZaUslovJedan(t.Delegat) as Delegat;
            t.Staza = Sesija.Broker.DajSesiju().DajZaUslovJedan(t.Staza) as TakmicarskaStaza;
            t.Staza.Zemlja = Sesija.Broker.DajSesiju().DajZaUslovJedan(t.Staza.Zemlja) as Zemlja;

            var s = new SpisakTakmicara
            {
                Uslov = " TakmicenjeID =" + t.TakmicenjeID + " order by Rang asc"
            };

            var lista = Sesija.Broker.DajSesiju().DajSveZaUslovVise(s).OfType<SpisakTakmicara>().ToList();
            
            foreach (var sp in lista)
            {
                sp.Takmicar = Sesija.Broker.DajSesiju().DajZaUslovJedan(sp.Takmicar) as Takmicar;
                sp.Takmicar.Zemlja = Sesija.Broker.DajSesiju().DajZaUslovJedan(sp.Takmicar.Zemlja) as Zemlja;
                t.ListaTakmicara.Add(sp);
            }

            return t;
        }
    }
}
