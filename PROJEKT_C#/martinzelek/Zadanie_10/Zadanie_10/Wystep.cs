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
    public partial class Wystep : Form
    {
        public Wystep()
        {
            InitializeComponent();
        }

        private void Wystep_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet_baza.aktor' table. You can move, or remove it, as needed.
            this.aktorTableAdapter.Fill(this.dataSet_baza.aktor);
            // TODO: This line of code loads data into the 'dataSet_baza.premiera' table. You can move, or remove it, as needed.
            this.premieraTableAdapter.Fill(this.dataSet_baza.premiera);
            // TODO: This line of code loads data into the 'dataSet_baza.wystep' table. You can move, or remove it, as needed.
            this.wystepTableAdapter.Fill(this.dataSet_baza.wystep);

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
            //aktualizuje bazę o wpisy w 
            wystepTableAdapter.Update(dataSet_baza.wystep);
            premieraTableAdapter.Update(dataSet_baza.premiera);
            aktorTableAdapter.Update(dataSet_baza.aktor);
        }
        private void Wystep_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Czy chcesz zapisać wszystkie zmiany, które wprowadziłeś?", "UWAGA!!!", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                wystepTableAdapter.Update(dataSet_baza.wystep);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbData_zakupu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
