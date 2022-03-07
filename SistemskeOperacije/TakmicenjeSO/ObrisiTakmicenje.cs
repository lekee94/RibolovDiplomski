﻿using Biblioteka;

namespace SistemskeOperacije.TakmicenjeSO
{
    public class ObrisiTakmicenje : OpstaSO
    {
        protected override object Izvrsi(IOpstiDomenskiObjekat odo) 
            => Sesija.Broker.DajSesiju().Obrisi(odo);
    }
}
