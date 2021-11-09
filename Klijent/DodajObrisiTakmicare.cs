using Biblioteka;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Klijent
{
    public partial class DodajObrisiTakmicare : Form
    {
        KontrolerKorisnickogInterfejsa.KontrolerKI kki = new KontrolerKorisnickogInterfejsa.KontrolerKI();
        BindingList<Takmicar> takmicari = new BindingList<Takmicar>();

        public DodajObrisiTakmicare()
        {
            InitializeComponent();
        }

        private void DodajObrisiTakmicare_Load(object sender, EventArgs e)
        {
            kki.PopuniPoljaDodajObrisiTakmicare(dgvTakmicari, takmicari);
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            kki.DodajTakmicara(dgvTakmicari, txtStartniBroj);
            dgvTakmicari.Refresh();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            kki.ObrisiTakmicara(dgvTakmicari);
            dgvTakmicari.Refresh();
        }

        private void btnNazadNaDetaljeTakmicenja_Click(object sender, EventArgs e) => Close();

        private void btnNoviTakmicar_Click(object sender, EventArgs e) 
            => new UnosTakmicara(takmicari).ShowDialog();

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvTakmicari_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbTakmicari_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
