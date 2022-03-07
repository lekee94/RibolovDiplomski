using Biblioteka;
using Izvestaj.Servisi;
using Izvestaj.Servisi.Implementacija;

namespace SistemskeOperacije.TakmicenjeSO
{
    public class GenerisiIzvestaj : OpstaSO
    {
        protected override object Izvrsi(IOpstiDomenskiObjekat odo)
        {
            var t = odo as Takmicenje;

            IPdfGenerator pdfGenerator = new PdfGenerator();
            return pdfGenerator.GenerisiPdf(t);
        }
    }
}
