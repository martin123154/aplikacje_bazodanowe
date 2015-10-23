namespace Zadanie_10
{
    partial class Klient
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
            this.klientidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.klientimieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.klientnazwiskoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.klientpeselDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.klientzdjecieDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.klientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_baza = new Zadanie_10.DataSet_baza();
            this.klientTableAdapter = new Zadanie_10.DataSet_bazaTableAdapters.klientTableAdapter();
            this.btnZapisz = new System.Windows.Forms.Button();
            this.btnUsun = new System.Windows.Forms.Button();
            this.txtPesel = new System.Windows.Forms.TextBox();
            this.txtNazwisko = new System.Windows.Forms.TextBox();
            this.txtImie = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_baza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.klientidDataGridViewTextBoxColumn,
            this.klientimieDataGridViewTextBoxColumn,
            this.klientnazwiskoDataGridViewTextBoxColumn,
            this.klientpeselDataGridViewTextBoxColumn,
            this.klientzdjecieDataGridViewImageColumn});
            this.dataGridView1.DataSource = this.klientBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(544, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // klientidDataGridViewTextBoxColumn
            // 
            this.klientidDataGridViewTextBoxColumn.DataPropertyName = "klient_id";
            this.klientidDataGridViewTextBoxColumn.HeaderText = "klient_id";
            this.klientidDataGridViewTextBoxColumn.Name = "klientidDataGridViewTextBoxColumn";
            this.klientidDataGridViewTextBoxColumn.ReadOnly = true;
            this.klientidDataGridViewTextBoxColumn.Visible = false;
            // 
            // klientimieDataGridViewTextBoxColumn
            // 
            this.klientimieDataGridViewTextBoxColumn.DataPropertyName = "klient_imie";
            this.klientimieDataGridViewTextBoxColumn.HeaderText = "Imię";
            this.klientimieDataGridViewTextBoxColumn.Name = "klientimieDataGridViewTextBoxColumn";
            // 
            // klientnazwiskoDataGridViewTextBoxColumn
            // 
            this.klientnazwiskoDataGridViewTextBoxColumn.DataPropertyName = "klient_nazwisko";
            this.klientnazwiskoDataGridViewTextBoxColumn.HeaderText = "Nazwisko";
            this.klientnazwiskoDataGridViewTextBoxColumn.Name = "klientnazwiskoDataGridViewTextBoxColumn";
            // 
            // klientpeselDataGridViewTextBoxColumn
            // 
            this.klientpeselDataGridViewTextBoxColumn.DataPropertyName = "klient_pesel";
            this.klientpeselDataGridViewTextBoxColumn.HeaderText = "Pesel";
            this.klientpeselDataGridViewTextBoxColumn.Name = "klientpeselDataGridViewTextBoxColumn";
            // 
            // klientzdjecieDataGridViewImageColumn
            // 
            this.klientzdjecieDataGridViewImageColumn.DataPropertyName = "klient_zdjecie";
            this.klientzdjecieDataGridViewImageColumn.HeaderText = "Zdjęcie";
            this.klientzdjecieDataGridViewImageColumn.Name = "klientzdjecieDataGridViewImageColumn";
            // 
            // klientBindingSource
            // 
            this.klientBindingSource.DataMember = "klient";
            this.klientBindingSource.DataSource = this.dataSet_baza;
            // 
            // dataSet_baza
            // 
            this.dataSet_baza.DataSetName = "DataSet_baza";
            this.dataSet_baza.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // klientTableAdapter
            // 
            this.klientTableAdapter.ClearBeforeFill = true;
            // 
            // btnZapisz
            // 
            this.btnZapisz.Location = new System.Drawing.Point(736, 405);
            this.btnZapisz.Name = "btnZapisz";
            this.btnZapisz.Size = new System.Drawing.Size(75, 23);
            this.btnZapisz.TabIndex = 28;
            this.btnZapisz.Text = "Zapisz";
            this.btnZapisz.UseVisualStyleBackColor = true;
            this.btnZapisz.Click += new System.EventHandler(this.btnZapisz_Click);
            // 
            // btnUsun
            // 
            this.btnUsun.Location = new System.Drawing.Point(836, 405);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(75, 23);
            this.btnUsun.TabIndex = 27;
            this.btnUsun.Text = "Usuń";
            this.btnUsun.UseVisualStyleBackColor = true;
            this.btnUsun.Click += new System.EventHandler(this.btnUsun_Click);
            // 
            // txtPesel
            // 
            this.txtPesel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klientBindingSource, "klient_pesel", true));
            this.txtPesel.Location = new System.Drawing.Point(653, 71);
            this.txtPesel.Name = "txtPesel";
            this.txtPesel.Size = new System.Drawing.Size(89, 20);
            this.txtPesel.TabIndex = 26;
            // 
            // txtNazwisko
            // 
            this.txtNazwisko.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klientBindingSource, "klient_nazwisko", true));
            this.txtNazwisko.Location = new System.Drawing.Point(653, 43);
            this.txtNazwisko.Name = "txtNazwisko";
            this.txtNazwisko.Size = new System.Drawing.Size(89, 20);
            this.txtNazwisko.TabIndex = 25;
            // 
            // txtImie
            // 
            this.txtImie.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klientBindingSource, "klient_imie", true));
            this.txtImie.Location = new System.Drawing.Point(653, 14);
            this.txtImie.Name = "txtImie";
            this.txtImie.Size = new System.Drawing.Size(89, 20);
            this.txtImie.TabIndex = 24;
            // 
            // pictureBox1
            // 
            this.pictureBox1.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.klientBindingSource, "klient_zdjecie", true));
            this.pictureBox1.Location = new System.Drawing.Point(653, 153);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 220);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(577, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Nazwisko";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(577, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Pesel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(568, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Zdjęcie";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(577, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Imię";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(555, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 29;
            this.button1.Text = "Wczytaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Klient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnZapisz);
            this.Controls.Add(this.btnUsun);
            this.Controls.Add(this.txtPesel);
            this.Controls.Add(this.txtNazwisko);
            this.Controls.Add(this.txtImie);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Klient";
            this.Text = "Klient";
            this.Load += new System.EventHandler(this.Klient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_baza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet_baza dataSet_baza;
        private System.Windows.Forms.BindingSource klientBindingSource;
        private DataSet_bazaTableAdapters.klientTableAdapter klientTableAdapter;
        private System.Windows.Forms.Button btnZapisz;
        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.TextBox txtPesel;
        private System.Windows.Forms.TextBox txtNazwisko;
        private System.Windows.Forms.TextBox txtImie;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn klientidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn klientimieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn klientnazwiskoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn klientpeselDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn klientzdjecieDataGridViewImageColumn;
        private System.Windows.Forms.Button button1;
    }
}