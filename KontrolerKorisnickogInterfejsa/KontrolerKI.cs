﻿using System;
using System.Collections.Generic;
using Biblioteka;
using System.Windows.Forms;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Linq;
using System.ComponentModel;

namespace KontrolerKorisnickogInterfejsa
{
    public class KontrolerKI
    {
        public static Komunikacija.Komunikacija komunikacija;
        public static Delegat delegat;
        public static Takmicar takmicar;
        public static Takmicenje takmicenje;

        public static bool PoveziSeNaServer()
        {
            komunikacija = new Komunikacija.Komunikacija();
            return komunikacija.PoveziSeNaServer();
        }

        public void PopuniPoljaTakmicenja(TextBox txtnaziv, ComboBox cmbKategorija, DateTimePicker dtpDatum, ComboBox cmbStaza, Button btnDodajObrisiTakmicara, Button btnUnosRezultata, DataGridView dataGridView1)
        {
            cmbStaza.DataSource = komunikacija.VratiSveStaze();

            txtnaziv.Text = takmicenje.Naziv;
            dtpDatum.Value = takmicenje.Datum;
            cmbKategorija.Text = takmicenje.Kategorija;
            cmbStaza.Text = takmicenje.Staza.ToString();

            if (takmicenje.Datum < DateTime.Now)
            {
                btnDodajObrisiTakmicara.Hide();
                btnUnosRezultata.Show();
            }

            if (takmicenje.Datum >= DateTime.Now)
            {
                btnUnosRezultata.Hide();
                btnDodajObrisiTakmicara.Show();
            }

            dataGridView1.DataSource = takmicenje.ListaTakmicara;

            dataGridView1.Columns[1].Visible = true;
            dataGridView1.Columns[2].Visible = true;
            if (takmicenje.Datum > DateTime.Now)
            {
                dataGridView1.Columns[1].Visible = false;
                dataGridView1.Columns[2].Visible = false;
            }
            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[3].ReadOnly = true;
            dataGridView1.Columns[2].ReadOnly = true;
        }

        public void PopuniPoljaUnosTakmicenja(ComboBox cmbKategorija, ComboBox cmbStaza, DataGridView dataGridView1)
        {
            takmicenje = new Takmicenje
            {
                Delegat = delegat
            };

            dataGridView1.DataSource = takmicenje.ListaTakmicara;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[3].ReadOnly = true;

            cmbStaza.DataSource = komunikacija.VratiSveStaze();

            cmbKategorija.Text = "Izaberite kategoriju!";
            cmbStaza.Text = "Izaberite stazu!";
        }

        public void UnesiUlovZaTakmicara(DataGridView dgvTakmicari, TextBox txtUlov)
        {
            //SpisakTakmicara sp = cmbTakmicariRang.SelectedItem as SpisakTakmicara;
            SpisakTakmicara sp = dgvTakmicari.CurrentRow.DataBoundItem as SpisakTakmicara;

            try
            {
                foreach (var t in takmicenje.ListaTakmicara.Where(t => t.Takmicar.TakmicarID == sp.Takmicar.TakmicarID))
                {
                    t.Ulov = Convert.ToInt32(txtUlov.Text);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Niste ispravno uneli ulov");
                txtUlov.Focus();
                return;
            }

            sp.Status = Status.Izmenjen;

            dgvTakmicari.Refresh();
        }

        public void PopuniPoljaUnesiRezultate(DataGridView dgvTakmicari, BindingList<SpisakTakmicara> spBindingList)
        {
            //cmbTakmicari.Text = "Izaberite igrača!";

            foreach (var t in takmicenje.ListaTakmicara)
            {
                //cmbTakmicari.Items.Add(t);
                spBindingList.Add(t);
            }

            dgvTakmicari.DataSource = spBindingList;

            dgvTakmicari.Columns[1].Visible = true;
            dgvTakmicari.Columns[2].Visible = true;
            dgvTakmicari.Columns[0].ReadOnly = true;
            dgvTakmicari.Columns[3].ReadOnly = true;
            dgvTakmicari.Columns[2].ReadOnly = true;
        }

        public void PopuniPoljaDodajObrisiTakmicare(DataGridView dgvTakmicari, BindingList<Takmicar> takmicariB)
        {
            //cmbTakmicari.Text = "Izaberite igrača!";

            var takmicari = komunikacija.VratiSveTakmicare() as List<Takmicar>;

            var takmicariLoop = (from t in takmicari
                                 select t).ToList();

            foreach (var takmicarIzBaze in takmicenje.ListaTakmicara.SelectMany(takmicarUTakmicenju => takmicariLoop.Where(takmicarIzBaze => takmicarIzBaze.TakmicarID == takmicarUTakmicenju.Takmicar.TakmicarID)))
            {
                takmicari.Remove(takmicarIzBaze);
            }

            //foreach (Takmicar t in takmicari)
            //{
            //    cmbTakmicari.Items.Add(t);
            //}

            ////var bindingTakmicari = new BindingList<Takmicar>();
            foreach (var t in takmicari)
            {
                takmicariB.Add(t);
            }

            dgvTakmicari.DataSource = takmicariB;

            //dgvTakmicari.DataSource = takmicenje.ListaTakmicara;
            dgvTakmicari.Columns[1].Visible = false;
            dgvTakmicari.Columns[2].Visible = false;
            dgvTakmicari.Columns[3].ReadOnly = true;
            dgvTakmicari.Columns[0].ReadOnly = true;
        }

        public void PopuniPoljaUnosTakmicara(ComboBox cmbZemlja, ComboBox cmbOslovljavanje)
        {
            cmbOslovljavanje.DataSource = Enum.GetValues(typeof(Oslovljavanje));
            cmbZemlja.DataSource = komunikacija.VratiSveZemlje();
            cmbZemlja.SelectedItem = null;
            cmbZemlja.Text = "Izaberite zemlju!";
        }

        public void IzracunajRezultate()
        {
            for (int i = takmicenje.ListaTakmicara.Count - 1; i >= 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (takmicenje.ListaTakmicara[j].Ulov < takmicenje.ListaTakmicara[j + 1].Ulov)
                    {
                        SpisakTakmicara pom = takmicenje.ListaTakmicara[j];
                        takmicenje.ListaTakmicara[j] = takmicenje.ListaTakmicara[j + 1];
                        takmicenje.ListaTakmicara[j + 1] = pom;
                    }
                }
            }

            for (int i = 0; i < takmicenje.ListaTakmicara.Count; i++)
            {
                if (i == 0) 
                    takmicenje.ListaTakmicara[i].Rang = 1;
                else
                {
                    if (takmicenje.ListaTakmicara[i].Ulov == takmicenje.ListaTakmicara[i - 1].Ulov) takmicenje.ListaTakmicara[i].Rang = takmicenje.ListaTakmicara[i - 1].Rang;
                    else
                    {
                        takmicenje.ListaTakmicara[i].Rang = i + 1;
                    }
                }
                takmicenje.ListaTakmicara[i].Status = Status.Izmenjen;
            }
        }

        public void UnosRezultata(DataGridView dataGridView1)
        {
            dataGridView1.Columns[1].Visible = true;
            dataGridView1.Columns[2].Visible = true;
            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[3].ReadOnly = true;
            dataGridView1.Columns[2].ReadOnly = true;

        }

        public bool ObrisiTakmicenje()
        {
            if (takmicenje.ListaTakmicara.Count > 0)
            {
                foreach (var sp in takmicenje.ListaTakmicara)
                {
                    komunikacija.ObrisiSpisakTakmicara(sp);
                }
            }
            object rez = komunikacija.ObrisiTakmicenje(takmicenje);
            

            if (rez == null)
            {
                MessageBox.Show("Sistem ne može da obriše takmičenje!");
                return false;
            }
            else
            {
                
                MessageBox.Show("Sistem je obrisao takmičenje!");
                return true;
            }
        }

        public void PretraziTakmicenja(TextBox txtFilter, DataGridView dataGridView1)
        {
            takmicenje = new Takmicenje();
            takmicenje.Uslov = "Naziv like '"+txtFilter.Text+"%' or Kategorija like '"+txtFilter.Text+"%'";

            List<Takmicenje> lista = komunikacija.PretraziTakmicenja(takmicenje) as List<Takmicenje>;
            dataGridView1.DataSource = lista;
            if (lista == null)
                MessageBox.Show("Sistem ne može da pronađe takmičenja!");
            if (lista.Count == 0)
                MessageBox.Show("Sistem ne može da pronađe takmičenja!");
        }

        public bool PronadjiTakmicenje(DataGridView dataGridView1)
        {
            try
            {
                takmicenje = dataGridView1.CurrentRow.DataBoundItem as Takmicenje;
                takmicenje = komunikacija.PronadjiTakmicenje(takmicenje) as Takmicenje;
                if (takmicenje == null)
                {
                    MessageBox.Show("Sistem ne može da pronađe takmičenje!");
                    return false;
                }
                else
                {
                    MessageBox.Show("Sistem je pronašao takmičenje!");
                    return true;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Niste odabrali takmičenje!");
                return false;
            }
        }

        public bool GenerisiIzvestaj(ComboBox cmbKategorija, ComboBox cmbStaza, TextBox txtnaziv, DateTimePicker dtpDatum)
        {
            takmicenje.Datum = dtpDatum.Value;
            takmicenje.Staza = cmbStaza.SelectedItem as TakmicarskaStaza;
            if (takmicenje.Staza == null)
            {
                MessageBox.Show("Niste odabrali stazu!");
                cmbStaza.Focus();
                return false;
            }

            takmicenje.Naziv = txtnaziv.Text;
            if (takmicenje.Naziv == "")
            {
                MessageBox.Show("Niste uneli naziv takmičenja!");
                txtnaziv.Focus();
                return false;
            }

            if (cmbKategorija.SelectedItem == null)
            {
                MessageBox.Show("Niste uneli kategoriju");
                cmbKategorija.Focus();
                return false;
            }
            takmicenje.Kategorija = cmbKategorija.SelectedItem.ToString();

            object rez = komunikacija.GenerisiIzvestaj(takmicenje);

            if (rez == null)
            {
                MessageBox.Show("Sistem ne može da izgeneriše izveštaj!");
                return false;
            }
            else
            {
                MessageBox.Show("Sistem je izgenerisao izveštaj!");
                return true;
            }
        }

        public bool ZapamtiTakmicenje(ComboBox cmbKategorija, ComboBox cmbStaza, TextBox txtnaziv, DateTimePicker dtpDatum)
        {
            takmicenje.Datum = dtpDatum.Value;
            takmicenje.Staza = cmbStaza.SelectedItem as TakmicarskaStaza;
            if (takmicenje.Staza == null)
            {
                MessageBox.Show("Niste odabrali stazu!");
                cmbStaza.Focus();
                return false;
            }

            takmicenje.Naziv = txtnaziv.Text;
            if (takmicenje.Naziv == "")
            {
                MessageBox.Show("Niste uneli naziv takmičenja!");
                txtnaziv.Focus();
                return false;
            }

            if (cmbKategorija.SelectedItem == null)
            {
                MessageBox.Show("Niste uneli kategoriju");
                cmbKategorija.Focus();
                return false;
            }
            takmicenje.Kategorija = cmbKategorija.SelectedItem.ToString();

            object rez = komunikacija.ZapamtiTakmicenje(takmicenje);

            if (rez == null)
            {
                MessageBox.Show("Sistem ne može da zapamti takmičenje!");
                return false;
            }
            else
            {
                MessageBox.Show("Sistem je zapamtio takmičenje!");
                return true;
            }

        }

        public bool IzmeniTakmicenje(ComboBox cmbKategorija, ComboBox cmbStaza, TextBox txtnaziv, DateTimePicker dtpDatum)
        {
            takmicenje.Datum = dtpDatum.Value;
            takmicenje.Staza = cmbStaza.SelectedItem as TakmicarskaStaza;
            if (takmicenje.Staza == null)
            {
                MessageBox.Show("Niste odabrali stazu!");
                cmbStaza.Focus();
                return false;
            }

            takmicenje.Naziv = txtnaziv.Text;
            if (takmicenje.Naziv == "")
            {
                MessageBox.Show("Niste uneli naziv takmičenja!");
                txtnaziv.Focus();
                return false;
            }

            if (cmbKategorija.SelectedItem == null)
            {
                MessageBox.Show("Niste uneli kategoriju");
                cmbKategorija.Focus();
                return false;
            }
            takmicenje.Kategorija = cmbKategorija.SelectedItem.ToString();

            object rez = komunikacija.IzmeniTakmicenje(takmicenje);

            if (rez == null)
            {
                MessageBox.Show("Sistem ne može da zapamti takmičenje!");
                return false;
            }
            else
            {
                MessageBox.Show("Sistem je zapamtio takmičenje!");
                return true;
            }

        }

        public void ObrisiTakmicara(DataGridView dataGridView1)
        {
            try
            {
                SpisakTakmicara sp = dataGridView1.CurrentRow.DataBoundItem as SpisakTakmicara;
                if (sp.Status == Status.Dodat)
                    takmicenje.ListaTakmicara.Remove(sp);
                
                else
                    sp.Status = Status.Obrisan;
                //cmbTakmicar.Items.Add(sp.Takmicar);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void ObojiGrid(DataGridView dgvGrid)
        {
            foreach (DataGridViewRow red in dgvGrid.Rows)
            {
                try
                {
                    SpisakTakmicara sp = red.DataBoundItem as SpisakTakmicara;
                    if (sp.Status == Status.Obrisan) 
                        red.DefaultCellStyle.BackColor = Color.Red;
                }
                catch (Exception)
                {
                }
            }
        }

        public void DodajTakmicara(DataGridView dgvTakmicari, TextBox txtStartniBroj)
        {
            SpisakTakmicara sp = new SpisakTakmicara();
            sp.TakmicenjeID = takmicenje.TakmicenjeID;
            sp.Status = Status.Dodat;
            sp.Takmicar = dgvTakmicari.CurrentRow.DataBoundItem as Takmicar;
            var selectedRowIndex = dgvTakmicari.CurrentRow.Index;
            if (sp.Takmicar == null)
            {
                MessageBox.Show("Niste odabrali takmičara!");
                dgvTakmicari.Focus();
                return;
            }
           
            try
            {
                sp.RedniBroj = Convert.ToInt32(txtStartniBroj.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Niste ispravno uneli startni broj!");
                txtStartniBroj.Focus();
                return;
            }

            foreach (var _ in takmicenje.ListaTakmicara.Where(s => s.RedniBroj == sp.RedniBroj && s.Status != Status.Obrisan).Select(s => new { }))
            {
                MessageBox.Show("Redni broj je već dodeljen!");
                return;
            }

            takmicenje.ListaTakmicara.Add(sp);
            txtStartniBroj.Clear();
            dgvTakmicari.Rows.RemoveAt(selectedRowIndex);
        }



        public void PopuniDetaljeTakmicara(TextBox txtIme, TextBox txtPrezime, ComboBox cmbOslovljavanje, TextBox txtJmbg, TextBox txtEmail, DateTimePicker dtpDatum, TextBox txtBrojTelefona, ComboBox cmbZemlja, TextBox txtAdresa, TextBox txtPostanskiBroj)
        {
            cmbZemlja.DataSource = komunikacija.VratiSveZemlje();
            cmbOslovljavanje.DataSource = Enum.GetValues(typeof(Oslovljavanje));

            txtIme.Text = takmicar.Ime;
            txtPrezime.Text = takmicar.Prezime;
            cmbOslovljavanje.SelectedItem = takmicar.Oslovljavanje;
            txtJmbg.Text = takmicar.Jmbg;
            txtEmail.Text = takmicar.Email;
            dtpDatum.Value = takmicar.DatumRodjenja;
            txtBrojTelefona.Text = takmicar.BrojTelefona;
            cmbZemlja.SelectedItem = takmicar.Zemlja;
            txtAdresa.Text = takmicar.Adresa;
            txtPostanskiBroj.Text = takmicar.PostanskiBroj;
        }

        public bool ObrisiTakmicara()
        {
            object rez = komunikacija.ObrisiTakmicara(takmicar);

            if (rez == null)
            {
                MessageBox.Show("Sistem ne može da obriše takmičara!");
                return false;
            }
            else
            {
                MessageBox.Show("Sistem je obrisao takmičara!");
                return true;
            }
        }

        public void PretraziTakmicare(TextBox txtFilter, DataGridView dataGridView1)
        {
            takmicar = new Takmicar();
            takmicar.Uslov = " Ime like '"+txtFilter.Text+"%' or Prezime like '"+txtFilter.Text+ "%' or Email like '" + txtFilter.Text + "%'";

            List<Takmicar> lista = komunikacija.PretraziTakmicare(takmicar) as List<Takmicar>;
            dataGridView1.DataSource = lista;
            if (lista == null)
            {
                MessageBox.Show("Sistem ne može da pronađe takmičare!");
                return;
            }
            if (lista.Count == 0)
            {
                MessageBox.Show("Ne postoje takmičari za uneti kriterijum!");
                return;
            }            
        }

        public bool PronadjiTakmicara(DataGridView dataGridView1)
        {
            try
            {
                takmicar = dataGridView1.CurrentRow.DataBoundItem as Takmicar;

                takmicar = komunikacija.PronadjiTakmicara(takmicar) as Takmicar;

                if (takmicar == null)
                {
                    MessageBox.Show("Sistem ne može da pronađe takmičara!");
                    return false;
                }
                else
                {
                    MessageBox.Show("Sistem je pronašao takmičara!");
                    return true;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Niste odabrali takmičara!");
                return false;
            }
        }

        public bool ZapamtiTakmicara(TextBox txtIme, TextBox txtPrezime, ComboBox cmbOslovljavanje, TextBox txtJmbg, TextBox txtEmail, DateTimePicker dtpDatum, TextBox txtBrojTelefona, ComboBox cmbZemlja, TextBox txtAdresa, TextBox txtPostanskiBroj, BindingList<Takmicar> takmicariB = null)
        {
            takmicar = new Takmicar();

            takmicar.Ime = txtIme.Text;
            if (takmicar.Ime == "")
            {
                MessageBox.Show("Niste uneli ime!");
                txtIme.Focus();
                return false;
            }

            foreach (var _ in takmicar.Ime.Where(c => !char.IsLetter(c) && c != ' ').Select(c => new { }))
            {
                MessageBox.Show("Ime mora da sadrži samo slova!");
                txtIme.Focus();
                return false;
            }

            takmicar.Prezime = txtPrezime.Text;

            if (takmicar.Prezime == "")
            {
                MessageBox.Show("Niste uneli prezime!");
                txtPrezime.Focus();
                return false;
            }

            foreach (var _ in takmicar.Prezime.Where(c => !char.IsLetter(c) && c != ' ').Select(c => new { }))
            {
                MessageBox.Show("Prezime mora da sadrži samo slova!");
                txtPrezime.Focus();
                return false;
            }

            takmicar.Oslovljavanje = (Oslovljavanje)cmbOslovljavanje.SelectedItem;

            takmicar.Jmbg = txtJmbg.Text;

            if (takmicar.Jmbg == "")
            {
                MessageBox.Show("Niste uneli JMBG!");
                txtJmbg.Focus();
                return false;
            }

            foreach (var _ in takmicar.Jmbg.Where(c => !char.IsDigit(c) || c == ' ').Select(c => new { }))
            {
                MessageBox.Show("JMBG mora da sadrži samo brojeve!");
                txtJmbg.Focus();
                return false;
            }

            takmicar.Email = txtEmail.Text;

            if (takmicar.Email == "")
            {
                MessageBox.Show("Niste uneli e-mail!");
                txtEmail.Focus();
                return false;
            }

            if (!DaLiJeMailValidan(takmicar.Email))
            {
                MessageBox.Show("E-mail koji ste uneli je nevalidan");
                txtEmail.Focus();
                return false;
            }

            takmicar.DatumRodjenja = dtpDatum.Value;
            if (takmicar.DatumRodjenja.AddYears(18) >= DateTime.Now)
            {
                MessageBox.Show("Takmičar mora biti punoletan! ");
                dtpDatum.Focus();
                return false;
            }

            takmicar.BrojTelefona = txtBrojTelefona.Text;

            if (takmicar.BrojTelefona == "")
            {
                MessageBox.Show("Niste uneli broj telefona!");
                txtBrojTelefona.Focus();
                return false;
            }

            foreach (var _ in takmicar.BrojTelefona.Where(c => char.IsLetter(c)).Select(c => new { }))
            {
                MessageBox.Show("Broj telefona ne sme da sadrži slova!");
                txtBrojTelefona.Focus();
                return false;
            }

            if (takmicar.BrojTelefona.Length > 20)
            {
                MessageBox.Show("Broj telefona koji ste uneli je predugačak");
                txtBrojTelefona.Focus();
                return false;
            }


            takmicar.Zemlja = cmbZemlja.SelectedItem as Zemlja;
            if (takmicar.Zemlja == null)
            {
                MessageBox.Show("Niste odabrali zemlju takmičara!");
                cmbZemlja.Focus();
                return false;
            }

            takmicar.Adresa = txtAdresa.Text;

            if (takmicar.Adresa == "")
            {
                MessageBox.Show("Niste uneli adresu!");
                txtAdresa.Focus();
                return false;
            }
            if (takmicar.Adresa.Length > 100)
            {
                MessageBox.Show("Adresa je predugačka!");
                txtAdresa.Focus();
                return false;
            }

            takmicar.PostanskiBroj = txtPostanskiBroj.Text;

            if (takmicar.PostanskiBroj == "")
            {
                MessageBox.Show("Niste uneli poštanski broj!");
                txtPostanskiBroj.Focus();
                return false;
            }

            foreach (var _ in takmicar.PostanskiBroj.Where(c => !char.IsDigit(c) || c == ' ').Select(c => new { }))
            {
                MessageBox.Show("Poštanski broj mora da sadrži samo brojeve!");
                txtPostanskiBroj.Focus();
                return false;
            }

            object rez = komunikacija.ZapamtiTakmicara(takmicar);

            if (rez == null)
            {
                MessageBox.Show("Sistem ne može da zapamti takmičara!");
                return false;
            }
            else
            {
                if (takmicariB.Count > 0)
                //cmbTakmicari.Items.Add(takmicar);
                {
                    takmicariB.Add(takmicar);
                }

                MessageBox.Show("Sistem je zapamtio takmičara!");
                return true;
            }
        }

        public bool IzmeniTakmicara(TextBox txtIme, TextBox txtPrezime, ComboBox cmbOslovljavanje, TextBox txtJmbg, TextBox txtEmail, DateTimePicker dtpDatum, TextBox txtBrojTelefona, ComboBox cmbZemlja, TextBox txtAdresa, TextBox txtPostanskiBroj)
        {
            takmicar.Ime = txtIme.Text;
            if (takmicar.Ime == "")
            {
                MessageBox.Show("Niste uneli ime!");
                txtIme.Focus();
                return false;
            }

            foreach (var _ in takmicar.Ime.Where(c => !char.IsLetter(c) && c != ' ').Select(c => new { }))
            {
                MessageBox.Show("Ime mora da sadrži samo slova!");
                txtIme.Focus();
                return false;
            }

            takmicar.Prezime = txtPrezime.Text;

            if (takmicar.Prezime == "")
            {
                MessageBox.Show("Niste uneli prezime!");
                txtPrezime.Focus();
                return false;
            }

            foreach (var _ in takmicar.Prezime.Where(c => !char.IsLetter(c) && c != ' ').Select(c => new { }))
            {
                MessageBox.Show("Prezime mora da sadrži samo slova!");
                txtPrezime.Focus();
                return false;
            }

            takmicar.Oslovljavanje = (Oslovljavanje)cmbOslovljavanje.SelectedItem;

            takmicar.Jmbg = txtJmbg.Text;

            if (takmicar.Jmbg == "")
            {
                MessageBox.Show("Niste uneli JMBG!");
                txtJmbg.Focus();
                return false;
            }

            foreach (var _ in takmicar.Jmbg.Where(c => !char.IsDigit(c) || c == ' ').Select(c => new { }))
            {
                MessageBox.Show("JMBG mora da sadrži samo brojeve!");
                txtJmbg.Focus();
                return false;
            }

            takmicar.Email = txtEmail.Text;

            if (takmicar.Email == "")
            {
                MessageBox.Show("Niste uneli e-mail!");
                txtEmail.Focus();
                return false;
            }

            if (!DaLiJeMailValidan(takmicar.Email))
            {
                MessageBox.Show("E-mail koji ste uneli je nevalidan");
                txtEmail.Focus();
                return false;
            }

            takmicar.DatumRodjenja = dtpDatum.Value;
            if (takmicar.DatumRodjenja.AddYears(18) >= DateTime.Now)
            {
                MessageBox.Show("Takmičar mora biti punoletan!");
                dtpDatum.Focus();
                return false;
            }


            takmicar.BrojTelefona = txtBrojTelefona.Text;

            if (takmicar.BrojTelefona == "")
            {
                MessageBox.Show("Niste uneli broj telefona!");
                txtBrojTelefona.Focus();
                return false;
            }

            foreach (var _ in takmicar.BrojTelefona.Where(c => char.IsLetter(c)).Select(c => new { }))
            {
                MessageBox.Show("Broj telefona ne sme da sadrži slova!");
                txtBrojTelefona.Focus();
                return false;
            }

            takmicar.Zemlja = cmbZemlja.SelectedItem as Zemlja;
            if (takmicar.Zemlja == null)
            {
                MessageBox.Show("Niste odabrali zemlju takmičara!");
                cmbZemlja.Focus();
                return false;
            }

            takmicar.Adresa = txtAdresa.Text;
            if (takmicar.Adresa == "")
            {
                MessageBox.Show("Niste uneli adresu!");
                txtAdresa.Focus();
                return false;
            }
            if (takmicar.Adresa.Length > 100)
            {
                MessageBox.Show("Adresa je predugačka!");
                txtAdresa.Focus();
                return false;
            }

            takmicar.PostanskiBroj = txtPostanskiBroj.Text;
            if (takmicar.PostanskiBroj == "")
            {
                MessageBox.Show("Niste uneli poštanski broj!");
                txtPostanskiBroj.Focus();
                return false;
            }

            foreach (var _ in takmicar.PostanskiBroj.Where(c => !char.IsDigit(c) || c == ' ').Select(c => new { }))
            {
                MessageBox.Show("Poštanski broj mora da sadrži samo brojeve!");
                txtPostanskiBroj.Focus();
                return false;
            }

            object rez = komunikacija.IzmeniTakmicara(takmicar);

            if (rez == null)
            {
                MessageBox.Show("Sistem ne može da izmeni takmičara!");
                return false;
            }
            else
            {
                MessageBox.Show("Sistem je izmenio takmičara!");
                return true;
            }
        }

        public void Kraj()
        {
            komunikacija.Kraj();
        }

        public bool PronadjiDelegata(TextBox txtUser, TextBox txtPass)
        {
            delegat = new Delegat();
            delegat.Uslov = " Username='"+txtUser.Text+"' and Password='"+txtPass.Text+"'";

            delegat = komunikacija.PronadjiDelegata(delegat) as Delegat;

            if (delegat == null)
            {
                MessageBox.Show("Sistem ne može da prijavi delegata!");
                txtUser.Clear();
                txtPass.Clear();
                txtUser.Focus();
                return false;

            }
            else
            {
                MessageBox.Show("Sistem je uspešno prijavio korisnika!");
                return true;
            }
        }

        private bool DaLiJeMailValidan(string email)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);
            if (match.Success)
                return true;
            return false;
        }
    }
}