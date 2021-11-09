using Biblioteka;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Klijent
{
    public partial class UnosRezultata : Form
    {
        KontrolerKorisnickogInterfejsa.KontrolerKI kki = new KontrolerKorisnickogInterfejsa.KontrolerKI();
        BindingList<SpisakTakmicara> spBindingList = new BindingList<SpisakTakmicara>();

        public UnosRezultata() => InitializeComponent();

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnNazadNaDetaljeTakmicenja_Click(object sender, EventArgs e) => Close();

        private void UnosRezultata_Load(object sender, EventArgs e)
        {
            kki.PopuniPoljaUnesiRezultate(dgvTakmicari, spBindingList);
        }

        private void btnDodajUlov_Click(object sender, EventArgs e)
        {
            kki.UnesiUlovZaTakmicara(dgvTakmicari, txtUlov);
            kki.IzracunajRezultate();
        }

        private void dgvTakmicari_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
