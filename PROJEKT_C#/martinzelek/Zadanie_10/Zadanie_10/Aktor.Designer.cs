namespace Zadanie_10
{
    partial class Aktor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.aktoridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aktorimieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aktornazwiskoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aktorpeselDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aktorzdjecieDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.aktorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_baza = new Zadanie_10.DataSet_baza();
            this.aktorTableAdapter = new Zadanie_10.DataSet_bazaTableAdapters.aktorTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtImie = new System.Windows.Forms.TextBox();
            this.txtNazwisko = new System.Windows.Forms.TextBox();
            this.txtPesel = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnZapisz = new System.Windows.Forms.Button();
            this.btnUsun = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aktorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_baza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aktoridDataGridViewTextBoxColumn,
            this.aktorimieDataGridViewTextBoxColumn,
            this.aktornazwiskoDataGridViewTextBoxColumn,
            this.aktorpeselDataGridViewTextBoxColumn,
            this.aktorzdjecieDataGridViewImageColumn});
            this.dataGridView1.DataSource = this.aktorBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 276);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // aktoridDataGridViewTextBoxColumn
            // 
            this.aktoridDataGridViewTextBoxColumn.DataPropertyName = "aktor_id";
            this.aktoridDataGridViewTextBoxColumn.HeaderText = "aktor_id";
            this.aktoridDataGridViewTextBoxColumn.Name = "aktoridDataGridViewTextBoxColumn";
            this.aktoridDataGridViewTextBoxColumn.ReadOnly = true;
            this.aktoridDataGridViewTextBoxColumn.Visible = false;
            // 
            // aktorimieDataGridViewTextBoxColumn
            // 
            this.aktorimieDataGridViewTextBoxColumn.DataPropertyName = "aktor_imie";
            this.aktorimieDataGridViewTextBoxColumn.HeaderText = "Imię";
            this.aktorimieDataGridViewTextBoxColumn.Name = "aktorimieDataGridViewTextBoxColumn";
            // 
            // aktornazwiskoDataGridViewTextBoxColumn
            // 
            this.aktornazwiskoDataGridViewTextBoxColumn.DataPropertyName = "aktor_nazwisko";
            this.aktornazwiskoDataGridViewTextBoxColumn.HeaderText = "Nazwisko";
            this.aktornazwiskoDataGridViewTextBoxColumn.Name = "aktornazwiskoDataGridViewTextBoxColumn";
            // 
            // aktorpeselDataGridViewTextBoxColumn
            // 
            this.aktorpeselDataGridViewTextBoxColumn.DataPropertyName = "aktor_pesel";
            this.aktorpeselDataGridViewTextBoxColumn.HeaderText = "Pesel";
            this.aktorpeselDataGridViewTextBoxColumn.Name = "aktorpeselDataGridViewTextBoxColumn";
            // 
            // aktorzdjecieDataGridViewImageColumn
            // 
            this.aktorzdjecieDataGridViewImageColumn.DataPropertyName = "aktor_zdjecie";
            this.aktorzdjecieDataGridViewImageColumn.HeaderText = "Zdjęcie aktora";
            this.aktorzdjecieDataGridViewImageColumn.Name = "aktorzdjecieDataGridViewImageColumn";
            // 
            // aktorBindingSource
            // 
            this.aktorBindingSource.DataMember = "aktor";
            this.aktorBindingSource.DataSource = this.dataSet_baza;
            // 
            // dataSet_baza
            // 
            this.dataSet_baza.DataSetName = "DataSet_baza";
            this.dataSet_baza.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aktorTableAdapter
            // 
            this.aktorTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(577, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Imię";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(577, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Pesel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(577, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nazwisko";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtImie
            // 
            this.txtImie.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aktorBindingSource, "aktor_imie", true));
            this.txtImie.Location = new System.Drawing.Point(653, 27);
            this.txtImie.Name = "txtImie";
            this.txtImie.Size = new System.Drawing.Size(89, 20);
            this.txtImie.TabIndex = 9;
            this.txtImie.TextChanged += new System.EventHandler(this.txtImie_TextChanged);
            // 
            // txtNazwisko
            // 
            this.txtNazwisko.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aktorBindingSource, "aktor_nazwisko", true));
            this.txtNazwisko.Location = new System.Drawing.Point(653, 56);
            this.txtNazwisko.Name = "txtNazwisko";
            this.txtNazwisko.Size = new System.Drawing.Size(89, 20);
            this.txtNazwisko.TabIndex = 11;
            // 
            // txtPesel
            // 
            this.txtPesel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aktorBindingSource, "aktor_pesel", true));
            this.txtPesel.Location = new System.Drawing.Point(653, 84);
            this.txtPesel.Name = "txtPesel";
            this.txtPesel.Size = new System.Drawing.Size(89, 20);
            this.txtPesel.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(555, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 33;
            this.button1.Text = "Wczytaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnZapisz
            // 
            this.btnZapisz.Location = new System.Drawing.Point(682, 396);
            this.btnZapisz.Name = "btnZapisz";
            this.btnZapisz.Size = new System.Drawing.Size(75, 23);
            this.btnZapisz.TabIndex = 32;
            this.btnZapisz.Text = "Zapisz";
            this.btnZapisz.UseVisualStyleBackColor = true;
            this.btnZapisz.Click += new System.EventHandler(this.btnZapisz_Click_1);
            // 
            // btnUsun
            // 
            this.btnUsun.Location = new System.Drawing.Point(782, 396);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(75, 23);
            this.btnUsun.TabIndex = 31;
            this.btnUsun.Text = "Usuń";
            this.btnUsun.UseVisualStyleBackColor = true;
            this.btnUsun.Click += new System.EventHandler(this.btnUsun_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.aktorBindingSource, "aktor_zdjecie", true));
            this.pictureBox1.Location = new System.Drawing.Point(636, 147);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 220);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(568, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Zdjęcie";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Aktor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 444);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnZapisz);
            this.Controls.Add(this.btnUsun);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtPesel);
            this.Controls.Add(this.txtNazwisko);
            this.Controls.Add(this.txtImie);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Aktor";
            this.Text = "Aktor";
            this.Load += new System.EventHandler(this.Aktor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aktorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_baza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet_baza dataSet_baza;
        private System.Windows.Forms.BindingSource aktorBindingSource;
        private DataSet_bazaTableAdapters.aktorTableAdapter aktorTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtImie;
        private System.Windows.Forms.TextBox txtNazwisko;
        private System.Windows.Forms.TextBox txtPesel;
        private System.Windows.Forms.DataGridViewTextBoxColumn aktoridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aktorimieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aktornazwiskoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aktorpeselDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn aktorzdjecieDataGridViewImageColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnZapisz;
        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}