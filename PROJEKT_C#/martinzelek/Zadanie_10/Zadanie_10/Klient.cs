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
    public partial class Klient : Form
    {
        public Klient()
        {
            InitializeComponent();
        }

        private void Klient_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet_baza.klient' table. You can move, or remove it, as needed.
            this.klientTableAdapter.Fill(this.dataSet_baza.klient);

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

        

        private void button1_Click(object sender, EventArgs e)
        {
            // open file dialog
            OpenFileDialog open = new OpenFileDialog();
            // image filters
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box
                pictureBox1.Image = new Bitmap(open.FileName);
                // image file path
                
            } 
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            klientTableAdapter.Update(dataSet_baza.klient);
        }
        private void Klient_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Czy chcesz zapisać wszystkie zmiany, które wprowadziłeś?", "UWAGA!!!", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                klientTableAdapter.Update(dataSet_baza.klient);
            }
        }
      
    }
}
