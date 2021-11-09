using System;
using System.Windows.Forms;

namespace Klijent
{
    public partial class DetaljiTakmicara : Form
    {
        KontrolerKorisnickogInterfejsa.KontrolerKI kki = new KontrolerKorisnickogInterfejsa.KontrolerKI();
        public DetaljiTakmicara() => InitializeComponent();

        private void DetaljiTakmicara_Load(object sender, EventArgs e) => 
            kki.PopuniDetaljeTakmicara(txtIme, txtPrezime, cmbBoxOslovljavanje, txtJmbg, txtEmail, dtpDatum, txtBrojTelefona, cmbZemlja, txtAdresa, txtPostanskiBroj);

        private void button2_Click(object sender, EventArgs e)
        {
            if (kki.IzmeniTakmicara(txtIme, txtPrezime, cmbBoxOslovljavanje, txtJmbg, txtEmail, dtpDatum, txtBrojTelefona, cmbZemlja, txtAdresa, txtPostanskiBroj)) 
                Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (kki.ObrisiTakmicara()) 
                Close();
        }

        private void gbProizvod_Enter(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
