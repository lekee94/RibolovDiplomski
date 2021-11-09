using System;
using System.Windows.Forms;

namespace Klijent
{
    public partial class GlavnaForma : Form
    {
        KontrolerKorisnickogInterfejsa.KontrolerKI kki = new KontrolerKorisnickogInterfejsa.KontrolerKI();
        public GlavnaForma() => InitializeComponent();

        private void krajRadaToolStripMenuItem_Click(object sender, EventArgs e) => Close();

        private void GlavnaForma_FormClosed(object sender, FormClosedEventArgs e) => kki.Kraj();

        private void GlavnaForma_Load(object sender, EventArgs e) 
            => Text = $" Ulogovan je {KontrolerKorisnickogInterfejsa.KontrolerKI.delegat}";

        private void unosTakmicaraToolStripMenuItem_Click(object sender, EventArgs e) 
            => new UnosTakmicara().ShowDialog();

        private void pregledTakmicaraToolStripMenuItem_Click(object sender, EventArgs e) 
            => new PregledTakmicara().ShowDialog();

        private void unosTakmicenjaToolStripMenuItem_Click(object sender, EventArgs e) 
            => new UnosTakmicenja().ShowDialog();

        private void pretragatakmicenjaToolStripMenuItem_Click(object sender, EventArgs e) 
            => new PretragaTakmicenja().ShowDialog();
    }
}
