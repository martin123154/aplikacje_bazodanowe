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
    public partial class Bilet : Form
    {
        public Bilet()
        {
            InitializeComponent();
        }

        private void Bilet_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet_baza.zakup' table. You can move, or remove it, as needed.
            this.zakupTableAdapter.Fill(this.dataSet_baza.zakup);
            // TODO: This line of code loads data into the 'dataSet_baza.premiera' table. You can move, or remove it, as needed.
            this.premieraTableAdapter.Fill(this.dataSet_baza.premiera);
            // TODO: This line of code loads data into the 'dataSet_baza.bilet' table. You can move, or remove it, as needed.
            this.biletTableAdapter.Fill(this.dataSet_baza.bilet);

        }

        private void label6_Click(object sender, EventArgs e)
        {

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
            biletTableAdapter.Update(dataSet_baza.bilet);
            zakupTableAdapter.Update(dataSet_baza.zakup);
            premieraTableAdapter.Update(dataSet_baza.premiera);
        }
        private void Bilet_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Czy chcesz zapisać wszystkie zmiany, które wprowadziłeś?", "UWAGA!!!", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                biletTableAdapter.Update(dataSet_baza.bilet);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
