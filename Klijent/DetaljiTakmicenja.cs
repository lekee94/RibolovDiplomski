using KontrolerKorisnickogInterfejsa;
using System;
using System.Windows.Forms;

namespace Klijent
{
    public partial class DetaljiTakmicenja : Form
    {
        private readonly KontrolerKI kki = new KontrolerKI();
        private readonly DataGridView dgvTakmicenja;

        public DetaljiTakmicenja() => InitializeComponent();

        public DetaljiTakmicenja(DataGridView dgvTakmicenja) 
        {
            this.dgvTakmicenja = dgvTakmicenja;
            InitializeComponent();
        } 

        private void DetaljiTakmicenja_Load(object sender, EventArgs e) 
            => kki.PopuniPoljaTakmicenja(txtnaziv, cmbKategorija, dtpDatum, cmbStaza, btn_DodajObrisiTakmicara, btn_UnosRezultata, dataGridView1);

        private void button2_Click(object sender, EventArgs e)
        {
            if (kki.IzmeniTakmicenje(cmbKategorija, cmbStaza, txtnaziv, dtpDatum))
                Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (kki.ObrisiTakmicenje())
                Close();
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e) 
            => kki.IzracunajRezultate();

        private void btn_GenerisiIzvestaj_Click(object sender, EventArgs e)
        {
            if (kki.GenerisiIzvestaj(cmbKategorija, cmbStaza, txtnaziv, dtpDatum)) 
                Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btn_UnosRezultata_Click(object sender, EventArgs e)
        {
            new UnosRezultata().ShowDialog();
        }

        private void btn_DodajObrisiTakmicara_Click(object sender, EventArgs e)
        {
            new DodajObrisiTakmicare().ShowDialog();
        }
    }
}
