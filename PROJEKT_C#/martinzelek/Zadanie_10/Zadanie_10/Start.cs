using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie_10
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void aktorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Aktor aktor = new Aktor();
            aktor.MdiParent = this;
            aktor.Show();
        }

        private void biletToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bilet bilet = new Bilet();
            bilet.MdiParent = this;
            bilet.Show();
        }

        private void klientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Klient klient = new Klient();
            klient.MdiParent = this;
            klient.Show();
        }

        private void premieraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Premiera premiera = new Premiera();
            premiera.MdiParent = this;
            premiera.Show();
        }

        private void wystepToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Wystep wystep = new Wystep();
            wystep.MdiParent = this;
            wystep.Show();
        }

        private void zakupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Zakup zakup = new Zakup();
            zakup.MdiParent = this;
            zakup.Show();
        }

    }
}
