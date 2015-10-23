namespace Zadanie_10
{
    partial class Bilet
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
            this.biletidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.biletcenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.biletrodzajDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.biletrzadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.biletmiejsceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.biletpremieraidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.premieraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_baza = new Zadanie_10.DataSet_baza();
            this.biletzakupidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.zakupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.biletBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.biletTableAdapter = new Zadanie_10.DataSet_bazaTableAdapters.biletTableAdapter();
            this.premieraTableAdapter = new Zadanie_10.DataSet_bazaTableAdapters.premieraTableAdapter();
            this.zakupTableAdapter = new Zadanie_10.DataSet_bazaTableAdapters.zakupTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnZapisz = new System.Windows.Forms.Button();
            this.btnUsun = new System.Windows.Forms.Button();
            this.txtCena = new System.Windows.Forms.TextBox();
            this.txtMiejsce = new System.Windows.Forms.TextBox();
            this.txtRzad = new System.Windows.Forms.TextBox();
            this.txtRodzaj = new System.Windows.Forms.TextBox();
            this.multiColumnComboBox1 = new MultiColumnComboBox.MultiColumnComboBox();
            this.multiColumnComboBox2 = new MultiColumnComboBox.MultiColumnComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.premieraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_baza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.biletBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.biletidDataGridViewTextBoxColumn,
            this.biletcenaDataGridViewTextBoxColumn,
            this.biletrodzajDataGridViewTextBoxColumn,
            this.biletrzadDataGridViewTextBoxColumn,
            this.biletmiejsceDataGridViewTextBoxColumn,
            this.biletpremieraidDataGridViewTextBoxColumn,
            this.biletzakupidDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.biletBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(647, 410);
            this.dataGridView1.TabIndex = 0;
            // 
            // biletidDataGridViewTextBoxColumn
            // 
            this.biletidDataGridViewTextBoxColumn.DataPropertyName = "bilet_id";
            this.biletidDataGridViewTextBoxColumn.HeaderText = "bilet_id";
            this.biletidDataGridViewTextBoxColumn.Name = "biletidDataGridViewTextBoxColumn";
            this.biletidDataGridViewTextBoxColumn.ReadOnly = true;
            this.biletidDataGridViewTextBoxColumn.Visible = false;
            // 
            // biletcenaDataGridViewTextBoxColumn
            // 
            this.biletcenaDataGridViewTextBoxColumn.DataPropertyName = "bilet_cena";
            this.biletcenaDataGridViewTextBoxColumn.HeaderText = "Cena";
            this.biletcenaDataGridViewTextBoxColumn.Name = "biletcenaDataGridViewTextBoxColumn";
            // 
            // biletrodzajDataGridViewTextBoxColumn
            // 
            this.biletrodzajDataGridViewTextBoxColumn.DataPropertyName = "bilet_rodzaj";
            this.biletrodzajDataGridViewTextBoxColumn.HeaderText = "Rodzaj";
            this.biletrodzajDataGridViewTextBoxColumn.Name = "biletrodzajDataGridViewTextBoxColumn";
            // 
            // biletrzadDataGridViewTextBoxColumn
            // 
            this.biletrzadDataGridViewTextBoxColumn.DataPropertyName = "bilet_rzad";
            this.biletrzadDataGridViewTextBoxColumn.HeaderText = "Rząd";
            this.biletrzadDataGridViewTextBoxColumn.Name = "biletrzadDataGridViewTextBoxColumn";
            // 
            // biletmiejsceDataGridViewTextBoxColumn
            // 
            this.biletmiejsceDataGridViewTextBoxColumn.DataPropertyName = "bilet_miejsce";
            this.biletmiejsceDataGridViewTextBoxColumn.HeaderText = "Miejsce";
            this.biletmiejsceDataGridViewTextBoxColumn.Name = "biletmiejsceDataGridViewTextBoxColumn";
            // 
            // biletpremieraidDataGridViewTextBoxColumn
            // 
            this.biletpremieraidDataGridViewTextBoxColumn.DataPropertyName = "bilet_premiera_id";
            this.biletpremieraidDataGridViewTextBoxColumn.DataSource = this.premieraBindingSource;
            this.biletpremieraidDataGridViewTextBoxColumn.DisplayMember = "premiera_tytul";
            this.biletpremieraidDataGridViewTextBoxColumn.HeaderText = "Tytuł spektaklu";
            this.biletpremieraidDataGridViewTextBoxColumn.Name = "biletpremieraidDataGridViewTextBoxColumn";
            this.biletpremieraidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.biletpremieraidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.biletpremieraidDataGridViewTextBoxColumn.ValueMember = "premiera_id";
            // 
            // premieraBindingSource
            // 
            this.premieraBindingSource.DataMember = "premiera";
            this.premieraBindingSource.DataSource = this.dataSet_baza;
            // 
            // dataSet_baza
            // 
            this.dataSet_baza.DataSetName = "DataSet_baza";
            this.dataSet_baza.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // biletzakupidDataGridViewTextBoxColumn
            // 
            this.biletzakupidDataGridViewTextBoxColumn.DataPropertyName = "bilet_zakup_id";
            this.biletzakupidDataGridViewTextBoxColumn.DataSource = this.zakupBindingSource;
            this.biletzakupidDataGridViewTextBoxColumn.DisplayMember = "zakup_data_zakupu";
            this.biletzakupidDataGridViewTextBoxColumn.HeaderText = "Data zakupu";
            this.biletzakupidDataGridViewTextBoxColumn.Name = "biletzakupidDataGridViewTextBoxColumn";
            this.biletzakupidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.biletzakupidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.biletzakupidDataGridViewTextBoxColumn.ValueMember = "zakup_id";
            // 
            // zakupBindingSource
            // 
            this.zakupBindingSource.DataMember = "zakup";
            this.zakupBindingSource.DataSource = this.dataSet_baza;
            // 
            // biletBindingSource
            // 
            this.biletBindingSource.DataMember = "bilet";
            this.biletBindingSource.DataSource = this.dataSet_baza;
            // 
            // biletTableAdapter
            // 
            this.biletTableAdapter.ClearBeforeFill = true;
            // 
            // premieraTableAdapter
            // 
            this.premieraTableAdapter.ClearBeforeFill = true;
            // 
            // zakupTableAdapter
            // 
            this.zakupTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(672, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cena";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(672, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Rząd";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(672, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Rodzaj";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(672, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Miejsce";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(672, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tytuł spektaklu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(672, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Data zakupu";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // btnZapisz
            // 
            this.btnZapisz.Location = new System.Drawing.Point(994, 373);
            this.btnZapisz.Name = "btnZapisz";
            this.btnZapisz.Size = new System.Drawing.Size(75, 23);
            this.btnZapisz.TabIndex = 12;
            this.btnZapisz.Text = "Zapisz";
            this.btnZapisz.UseVisualStyleBackColor = true;
            this.btnZapisz.Click += new System.EventHandler(this.btnZapisz_Click);
            // 
            // btnUsun
            // 
            this.btnUsun.Location = new System.Drawing.Point(1086, 373);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(75, 23);
            this.btnUsun.TabIndex = 14;
            this.btnUsun.Text = "Usuń";
            this.btnUsun.UseVisualStyleBackColor = true;
            this.btnUsun.Click += new System.EventHandler(this.btnUsun_Click);
            // 
            // txtCena
            // 
            this.txtCena.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.biletBindingSource, "bilet_cena", true));
            this.txtCena.Location = new System.Drawing.Point(750, 66);
            this.txtCena.Name = "txtCena";
            this.txtCena.Size = new System.Drawing.Size(411, 20);
            this.txtCena.TabIndex = 15;
            // 
            // txtMiejsce
            // 
            this.txtMiejsce.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.biletBindingSource, "bilet_miejsce", true));
            this.txtMiejsce.Location = new System.Drawing.Point(750, 140);
            this.txtMiejsce.Name = "txtMiejsce";
            this.txtMiejsce.Size = new System.Drawing.Size(411, 20);
            this.txtMiejsce.TabIndex = 21;
            // 
            // txtRzad
            // 
            this.txtRzad.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.biletBindingSource, "bilet_rzad", true));
            this.txtRzad.Location = new System.Drawing.Point(750, 114);
            this.txtRzad.Name = "txtRzad";
            this.txtRzad.Size = new System.Drawing.Size(411, 20);
            this.txtRzad.TabIndex = 23;
            // 
            // txtRodzaj
            // 
            this.txtRodzaj.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.biletBindingSource, "bilet_rodzaj", true));
            this.txtRodzaj.Location = new System.Drawing.Point(750, 91);
            this.txtRodzaj.Name = "txtRodzaj";
            this.txtRodzaj.Size = new System.Drawing.Size(411, 20);
            this.txtRodzaj.TabIndex = 25;
            // 
            // multiColumnComboBox1
            // 
            this.multiColumnComboBox1.DisplayDataMember = "premiera_tytul";
            this.multiColumnComboBox1.DisplayDataSource = this.premieraBindingSource;
            this.multiColumnComboBox1.Location = new System.Drawing.Point(759, 166);
            this.multiColumnComboBox1.Name = "multiColumnComboBox1";
            this.multiColumnComboBox1.SaveDataMember = "premiera_data_rozp";
            this.multiColumnComboBox1.SaveDataSource = this.premieraBindingSource;
            this.multiColumnComboBox1.Size = new System.Drawing.Size(432, 20);
            this.multiColumnComboBox1.TabIndex = 33;
            // 
            // multiColumnComboBox2
            // 
            this.multiColumnComboBox2.DisplayDataMember = "zakup_data_zakupu";
            this.multiColumnComboBox2.DisplayDataSource = this.zakupBindingSource;
            this.multiColumnComboBox2.Location = new System.Drawing.Point(759, 192);
            this.multiColumnComboBox2.Name = "multiColumnComboBox2";
            this.multiColumnComboBox2.SaveDataMember = "zakup_data_zakupu";
            this.multiColumnComboBox2.SaveDataSource = this.zakupBindingSource;
            this.multiColumnComboBox2.Size = new System.Drawing.Size(432, 20);
            this.multiColumnComboBox2.TabIndex = 34;
            // 
            // Bilet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 408);
            this.Controls.Add(this.multiColumnComboBox2);
            this.Controls.Add(this.multiColumnComboBox1);
            this.Controls.Add(this.txtRodzaj);
            this.Controls.Add(this.txtRzad);
            this.Controls.Add(this.txtMiejsce);
            this.Controls.Add(this.txtCena);
            this.Controls.Add(this.btnUsun);
            this.Controls.Add(this.btnZapisz);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Bilet";
            this.Text = "Bilet";
            this.Load += new System.EventHandler(this.Bilet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.premieraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_baza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.biletBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet_baza dataSet_baza;
        private System.Windows.Forms.BindingSource biletBindingSource;
        private DataSet_bazaTableAdapters.biletTableAdapter biletTableAdapter;
        private System.Windows.Forms.BindingSource premieraBindingSource;
        private DataSet_bazaTableAdapters.premieraTableAdapter premieraTableAdapter;
        private System.Windows.Forms.BindingSource zakupBindingSource;
        private DataSet_bazaTableAdapters.zakupTableAdapter zakupTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnZapisz;
        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.TextBox txtCena;
        private System.Windows.Forms.TextBox txtMiejsce;
        private System.Windows.Forms.TextBox txtRzad;
        private System.Windows.Forms.TextBox txtRodzaj;
        private System.Windows.Forms.DataGridViewTextBoxColumn biletidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn biletcenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn biletrodzajDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn biletrzadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn biletmiejsceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn biletpremieraidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn biletzakupidDataGridViewTextBoxColumn;
        private MultiColumnComboBox.MultiColumnComboBox multiColumnComboBox1;
        private MultiColumnComboBox.MultiColumnComboBox multiColumnComboBox2;
    }
}