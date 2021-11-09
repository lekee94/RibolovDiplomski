using System;
using System.Windows.Forms;

namespace Klijent
{
    public partial class UnosTakmicenja : Form
    {
        KontrolerKorisnickogInterfejsa.KontrolerKI kki = new KontrolerKorisnickogInterfejsa.KontrolerKI();
        public UnosTakmicenja() => InitializeComponent();

        private void UnosTakmicenja_Load(object sender, EventArgs e) 
            => kki.PopuniPoljaUnosTakmicenja(cmbKategorija, cmbStaza, dataGridView1);

        private void button2_Click(object sender, EventArgs e)
        {
            if (kki.ZapamtiTakmicenje(cmbKategorija, cmbStaza, txtnaziv, dtpDatum)) 
                Close();
        }

        private void cmbKategorija_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDodajObrisiTakmicare_Click(object sender, EventArgs e)
        {
            new DodajObrisiTakmicare().ShowDialog();
        }
    }
}