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
    public partial class Premiera : Form
    {
        public Premiera()
        {
            InitializeComponent();
        }

        private void Premiera_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet_baza.premiera' table. You can move, or remove it, as needed.
            this.premieraTableAdapter.Fill(this.dataSet_baza.premiera);

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
            premieraTableAdapter.Update(dataSet_baza.premiera);
        }
        private void Premiera_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Czy chcesz zapisać wszystkie zmiany, które wprowadziłeś?", "UWAGA!!!", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                premieraTableAdapter.Update(dataSet_baza.premiera);
            }
        }
    }
}
