using System;
using Biblioteka;
using Sesija;

namespace SistemskeOperacije
{
    public abstract class OpstaSO
    {
        public object IzvrsiSO(IOpstiDomenskiObjekat odo)
        {
            object rezultat = null;
            Broker.DajSesiju().OtvoriKonekciju();
            Broker.DajSesiju().ZapocniTransakciju();
            try
            {
                rezultat = Izvrsi(odo);
                Broker.DajSesiju().PotvrdiTransakciju();
            }
            catch (Exception)
            {
                Broker.DajSesiju().PonistiTransakciju();
            }
            finally
            {
                Broker.DajSesiju().ZatvoriKonekciju();
            }

            return rezultat;
        }

        protected abstract object Izvrsi(IOpstiDomenskiObjekat odo);
    }
}
