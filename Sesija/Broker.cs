using System;
using System.Collections.Generic;
using Biblioteka;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Linq;

namespace Sesija
{
    public class Broker
    {
        SqlConnection konekcija;
        SqlTransaction transakcija;

        private static Broker instanca;

        public static Broker DajSesiju() => instanca ?? (instanca = new Broker());

        public void OtvoriKonekciju()
        {
            try
            {
                konekcija = new SqlConnection(@"Data Source=localhost;Initial Catalog=Ribolov;Integrated Security=True");
                konekcija.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Neuspešna konekcija!");
            }
        }

        public void ZatvoriKonekciju()
        {
            try
            {
                konekcija.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Nije moguće zatvoriti konekciju!");
            }
        }

        public void ZapocniTransakciju()
        {
            try
            {
                transakcija = konekcija.BeginTransaction();
            }
            catch (Exception)
            {
                MessageBox.Show("Neuspešna transakcija!");
            }
        }

        public void PonistiTransakciju()
        {
            try
            {
                transakcija.Rollback();
            }
            catch (Exception)
            {
                MessageBox.Show("Neuspešno poništavanje!");
            }
        }

        public void PotvrdiTransakciju()
        {
            try
            {
                transakcija.Commit();
            }
            catch (Exception)
            {
                MessageBox.Show("Neuspešna potvrda transakcije!");
            }
        }


        public IEnumerable<IOpstiDomenskiObjekat> DajSve(IOpstiDomenskiObjekat odo)
        {
            var upit = "SELECT * FROM " + odo.Tabela;
            SqlDataReader citac = null;
            var komanda = new SqlCommand(upit, konekcija, transakcija);
            try
            {
                citac = komanda.ExecuteReader();
                var tabela = new DataTable();
                tabela.Load(citac);
                return (from DataRow red in tabela.Rows
                        let pom = odo.Napuni(red)
                        select pom).ToList();
            }
            catch (Exception)
            {
                throw new Exception("Greška u radu sa bazom!");
            }
            finally
            {
                citac?.Close();
            }
        }

        public IEnumerable<IOpstiDomenskiObjekat> DajSveZaUslovVise(IOpstiDomenskiObjekat odo)
        {
            var upit = "SELECT * FROM " + odo.Tabela + " WHERE " + odo.UslovVise;
            SqlDataReader citac = null;
            var komanda = new SqlCommand(upit, konekcija, transakcija);
            try
            {
                citac = komanda.ExecuteReader();
                var tabela = new DataTable();
                tabela.Load(citac);
                return (from DataRow red in tabela.Rows
                        let pom = odo.Napuni(red)
                        select pom).ToList();
            }
            catch (Exception)
            {
                throw new Exception("Greška u radu sa bazom!");
            }
            finally
            {
                citac?.Close();
            }
        }

        public IOpstiDomenskiObjekat DajZaUslovJedan(IOpstiDomenskiObjekat odo)
        {
            var upit = "SELECT * FROM " + odo.Tabela + " WHERE " + odo.UslovJedan;
            SqlDataReader reader = null;
            var komanda = new SqlCommand(upit, konekcija, transakcija);
            try
            {
                reader = komanda.ExecuteReader();
                var tabela = new DataTable();
                tabela.Load(reader);
                DataRow red;
                if (tabela.Rows.Count == 0)
                    return null;
                
                red = tabela.Rows[0];

                return odo.Napuni(red);
            }
            catch (Exception)
            {
                throw new Exception("Greška u radu sa bazom!");
            }
            finally
            {
                reader?.Close();
            }
        }

        public IOpstiDomenskiObjekat DajZaUslovVise(IOpstiDomenskiObjekat odo)
        {
            var upit = "SELECT * FROM " + odo.Tabela + " WHERE " + odo.UslovVise;
            
            SqlDataReader reader = null;
            var komanda = new SqlCommand(upit, konekcija, transakcija);
            try
            {
                reader = komanda.ExecuteReader();
                var tabela = new DataTable();
                tabela.Load(reader);
                DataRow red;
                if (tabela.Rows.Count == 0)
                    return null;
                
                red = tabela.Rows[0];

                return odo.Napuni(red);
            }
            catch (Exception)
            {
                throw new Exception("Greška u radu sa bazom!");
            }
            finally
            {
                reader?.Close();
            }
        }

        public int Izmeni(IOpstiDomenskiObjekat odo)
        {
            var upit = "UPDATE " + odo.Tabela + " SET " + odo.Azuriranje + " WHERE " + odo.UslovJedan;
            var komanda = new SqlCommand(upit, konekcija, transakcija);
            try
            {
                return komanda.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception("Greška u radu sa bazom!");
            }
        }

        public int Sacuvaj(IOpstiDomenskiObjekat odo)
        {
            var upit = "INSERT INTO " + odo.Tabela + " " + odo.Upisivanje;
            var komanda = new SqlCommand(upit, konekcija, transakcija); ;
            try
            {
                var result =  komanda.ExecuteNonQuery();
                return result;
            }
            catch (Exception)
            {
                throw new Exception("Greška u radu sa bazom!");
            }
        }

        public int Obrisi(IOpstiDomenskiObjekat odo)
        {
            var upit = "DELETE FROM " + odo.Tabela + " WHERE " + odo.UslovJedan;
            IDbCommand komanda = new SqlCommand(upit, konekcija, transakcija);
            try
            {
                return komanda.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception("Greška u radu sa bazom!");
            }
        }

        public int ObrisiZaUslovVise(IOpstiDomenskiObjekat odo)
        {
            var upit = "DELETE FROM " + odo.Tabela + " WHERE " + odo.UslovVise;
            var komanda = new SqlCommand(upit, konekcija, transakcija);
            try
            {
                return komanda.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception("Greška u radu sa bazom!");
            }
        }

        public int DajSifru(IOpstiDomenskiObjekat odo)
        {
            var upit = "SELECT MAX(" + odo.Kljuc + ") FROM " + odo.Tabela;
            var komanda = new SqlCommand(upit, konekcija, transakcija);
            var rez = komanda.ExecuteScalar();

            if (rez == DBNull.Value) 
                return 1;
            return Convert.ToInt32(rez) + 1;
        }
           
    }
}
