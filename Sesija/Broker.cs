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

        public static Broker instanca;

        public static Broker DajSesiju() 
        {
            if (instanca == null)
                instanca = new Broker();
            
            return instanca;
        }

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


        public List<IOpstiDomenskiObjekat> DajSve(IOpstiDomenskiObjekat odo)
        {
            string upit = "SELECT * FROM " + odo.Tabela;
            SqlDataReader citac = null;
            SqlCommand komanda = new SqlCommand(upit, konekcija, transakcija);
            try
            {
                citac = komanda.ExecuteReader();
                DataTable tabela = new DataTable();
                tabela.Load(citac);
                return (from DataRow red in tabela.Rows
                        let pom = odo.Napuni(red)
                        select pom).ToList();
            }
            catch (Exception e)
            {
                throw new Exception("Greška u radu sa bazom!");
            }
            finally
            {
                if (citac != null)
                    citac.Close();
            }
        }

        public List<IOpstiDomenskiObjekat> DajSveZaUslovVise(IOpstiDomenskiObjekat odo)
        {
            string upit = "SELECT * FROM " + odo.Tabela + " WHERE " + odo.UslovVise;
            SqlDataReader citac = null;
            SqlCommand komanda = new SqlCommand(upit, konekcija, transakcija);
            try
            {
                citac = komanda.ExecuteReader();
                DataTable tabela = new DataTable();
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
                if (citac != null)
                    citac.Close();
            }
        }

        public IOpstiDomenskiObjekat DajZaUslovJedan(IOpstiDomenskiObjekat odo)
        {
            string upit = "SELECT * FROM " + odo.Tabela + " WHERE " + odo.UslovJedan;
            SqlDataReader reader = null;
            SqlCommand komanda = new SqlCommand(upit, konekcija, transakcija);
            try
            {
                reader = komanda.ExecuteReader();
                DataTable tabela = new DataTable();
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
                if (reader != null)
                    reader.Close();
            }
        }

        public IOpstiDomenskiObjekat DajZaUslovVise(IOpstiDomenskiObjekat odo)
        {
            string upit = "SELECT * FROM " + odo.Tabela + " WHERE " + odo.UslovVise;
            ;
            SqlDataReader reader = null;
            SqlCommand komanda = new SqlCommand(upit, konekcija, transakcija);
            try
            {
                reader = komanda.ExecuteReader();
                DataTable tabela = new DataTable();
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
                if (reader != null)
                    reader.Close();
            }
        }

        public int Izmeni(IOpstiDomenskiObjekat odo)
        {
            string upit = "UPDATE " + odo.Tabela + " SET " + odo.Azuriranje + " WHERE " + odo.UslovJedan;
            SqlCommand komanda = new SqlCommand(upit, konekcija, transakcija);
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
            string upit = "INSERT INTO " + odo.Tabela + " " + odo.Upisivanje;
            SqlCommand komanda = new SqlCommand(upit, konekcija, transakcija); ;
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
            string upit = "DELETE FROM " + odo.Tabela + " WHERE " + odo.UslovJedan;
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
            string upit = "DELETE FROM " + odo.Tabela + " WHERE " + odo.UslovVise;
            SqlCommand komanda = new SqlCommand(upit, konekcija, transakcija);
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
            string upit = "SELECT MAX(" + odo.Kljuc + ") FROM " + odo.Tabela;
            SqlCommand komanda = new SqlCommand(upit, konekcija, transakcija);
            try
            {                
                var rez = komanda.ExecuteScalar();

                if (rez == DBNull.Value) 
                    return 1;
                return Convert.ToInt32(rez) + 1;
            }
            catch (Exception)
            {
                throw;
            }
        }
           
    }
}
