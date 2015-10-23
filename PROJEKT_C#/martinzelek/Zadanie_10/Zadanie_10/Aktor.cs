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
    public partial class Aktor : Form
    {
        public Aktor()
        {
            InitializeComponent();
        }

        private void Aktor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet_baza.aktor' table. You can move, or remove it, as needed.
            this.aktorTableAdapter.Fill(this.dataSet_baza.aktor);

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

     
   
       

        private void txtImie_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

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
              
            } 
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnZapisz_Click_1(object sender, EventArgs e)
        {
             
            //aktualizuje bazę o wpisy w 
            aktorTableAdapter.Update(dataSet_baza.aktor);
        }
        private void Aktor_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Czy chcesz zapisać wszystkie zmiany, które wprowadziłeś?", "UWAGA!!!", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                aktorTableAdapter.Update(dataSet_baza.aktor);
            }
        }

        private void btnUsun_Click_1(object sender, EventArgs e)
        {
        //sprawdza czy jest zaznaczony wiersz
            if (dataGridView1.CurrentRow != null)
            {
                dataGridView1.CurrentRow.Selected = true;
                //usuwa zaznaczony wiersz
                dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
            }
        }
        

  
    }
}
