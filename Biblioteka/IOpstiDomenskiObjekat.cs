using System.Data;

namespace Biblioteka
{
    public interface IOpstiDomenskiObjekat
    {
        string Tabela
        {
            get;
        }

        string Kljuc
        {
            get;
        }

        string UslovJedan
        {
            get;
        }

        string UslovVise
        {
            get;
        }

        string Azuriranje
        {
            get;
        }

        string Upisivanje
        {
            get;
        }

        IOpstiDomenskiObjekat Napuni(DataRow red);
    }
}
