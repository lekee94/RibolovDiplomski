using Biblioteka;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Klijent
{
    public partial class UnosTakmicara : Form
    {
        KontrolerKorisnickogInterfejsa.KontrolerKI kki = new KontrolerKorisnickogInterfejsa.KontrolerKI();

        BindingList<Takmicar> takmicari;

        public UnosTakmicara() => 
            InitializeComponent();

        public UnosTakmicara(BindingList<Takmicar> takmicari)
        {
            InitializeComponent();
            this.takmicari = takmicari;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (kki.ZapamtiTakmicara(txtIme, txtPrezime, cmbBoxOslovljavanje, txtBoxJmbg, txtBoxEmail, dtpDatum, txtBrojTelefona, cmbZemlja, txtBoxAdresa, txtBoxPostanskiBroj, takmicari))
            {
                Close();
            }
        }

        private void UnosTakmicara_Load_1(object sender, EventArgs e) => 
            kki.PopuniPoljaUnosTakmicara(cmbZemlja, cmbBoxOslovljavanje);

        private void gbProizvod_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void cmbZemlja_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
