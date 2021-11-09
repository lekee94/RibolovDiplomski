using System;
using System.Windows.Forms;

namespace Klijent
{
    public partial class PretragaTakmicenja : Form
    {
        KontrolerKorisnickogInterfejsa.KontrolerKI kki = new KontrolerKorisnickogInterfejsa.KontrolerKI();
        public PretragaTakmicenja() => InitializeComponent();

        private void PretragaTakmicenja_Load(object sender, EventArgs e) 
            => kki.PretraziTakmicenja(txtFilter, dataGridView1);

        private void txtFilter_TextChanged(object sender, EventArgs e) 
            => kki.PretraziTakmicenja(txtFilter, dataGridView1);

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (kki.PronadjiTakmicenje(dataGridView1)) 
                new DetaljiTakmicenja(dataGridView1).ShowDialog();
            kki.PretraziTakmicenja(txtFilter, dataGridView1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
