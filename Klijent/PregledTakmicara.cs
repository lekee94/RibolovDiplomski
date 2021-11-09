using System;
using System.Windows.Forms;

namespace Klijent
{
    public partial class PregledTakmicara : Form
    {
        KontrolerKorisnickogInterfejsa.KontrolerKI kki = new KontrolerKorisnickogInterfejsa.KontrolerKI();
        
        public PregledTakmicara() => InitializeComponent();

        private void PregledTakmicara_Load(object sender, EventArgs e) 
            => kki.PretraziTakmicare(txtFilter, dataGridView1);

        private void txtFilter_TextChanged(object sender, EventArgs e) 
            => kki.PretraziTakmicare(txtFilter, dataGridView1);

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (kki.PronadjiTakmicara(dataGridView1)) 
                new DetaljiTakmicara().ShowDialog();
            txtFilter_TextChanged(sender, e);
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (kki.PronadjiTakmicara(dataGridView1)) 
                    new DetaljiTakmicara().ShowDialog();
                txtFilter_TextChanged(sender, e);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Pretraga_Click(object sender, EventArgs e)
        {

        }
    }
}
