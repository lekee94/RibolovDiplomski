using System;
using System.Windows.Forms;
using KontrolerKorisnickogInterfejsa;

namespace Klijent
{
    public partial class Login : Form
    {
        KontrolerKI kki = new KontrolerKI();
        public Login() => InitializeComponent();

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (KontrolerKI.PoveziSeNaServer())
            {
                if (kki.PronadjiDelegata(txtUser, txtPass))
                {
                    Hide();
                    new GlavnaForma().ShowDialog();
                    Show();
                }
            }
            else
            {
                MessageBox.Show("Nije uspelo povezivanje na server!");
            }
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button1_Click(sender, e);
        }
    }
}
