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
    public partial class Zakup : Form
    {
        public Zakup()
        {
            InitializeComponent();
        }

        private void Zakup_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet_baza.klient' table. You can move, or remove it, as needed.
            this.klientTableAdapter.Fill(this.dataSet_baza.klient);
            // TODO: This line of code loads data into the 'dataSet_baza.zakup' table. You can move, or remove it, as needed.
            this.zakupTableAdapter.Fill(this.dataSet_baza.zakup);

        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                dataGridView1.CurrentRow.Selected = true;
                //usuwa zaznaczony wiersz
                dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
            }
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            klientTableAdapter.Update(dataSet_baza.klient);
            zakupTableAdapter.Update(dataSet_baza.zakup);
        }
        private void Zakup_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Czy chcesz zapisać wszystkie zmiany, które wprowadziłeś?", "UWAGA!!!", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                zakupTableAdapter.Update(dataSet_baza.zakup);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

    }
}
