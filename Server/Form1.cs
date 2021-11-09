using Biblioteka;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

namespace Server
{
    public partial class Form1 : Form
    {
        Server s;
        Timer t;

        public Form1() => InitializeComponent();

        private void Form1_Load(object sender, EventArgs e) => Text = "Server nije pokrenut!";

        private void BtnPokreni_Click(object sender, EventArgs e)
        {
            s = new Server();

            if (s.PokreniServer())
            {
                Text = "Pokrenut!";
                t = new Timer();
                t.Interval = 1000;
                t.Tick += Osvezi;
                t.Start();
                btnPokreni.Enabled = false;
                btnZaustavi.Enabled = true;
            }
        }

        private void Osvezi(object sender, EventArgs e)
        {
            List<Delegat> lista = (Server.listaUlogovanihDelegata).ToList();
            dataGridView1.DataSource = lista;
        }

        private void BtnZaustavi_Click(object sender, EventArgs e)
        {
            if (Server.listaUlogovanihDelegata.Count > 0)
            {
                MessageBox.Show("Postoje ulogovani delegati!");
                return;
            }

            if (s.ZaustaviServer())
            {
                Text = "Server nije pokrenut!";
                t.Stop();
                btnPokreni.Enabled = true;
                btnZaustavi.Enabled = false;
            }
        }
    }
}
