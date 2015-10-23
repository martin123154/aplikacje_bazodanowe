namespace Zadanie_10
{
    partial class Zakup
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
            this.zakupidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zakupdatazakupuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zakupklientidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.klientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_baza = new Zadanie_10.DataSet_baza();
            this.zakupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zakupTableAdapter = new Zadanie_10.DataSet_bazaTableAdapters.zakupTableAdapter();
            this.klientTableAdapter = new Zadanie_10.DataSet_bazaTableAdapters.klientTableAdapter();
            this.label6 = new System.Windows.Forms.Label();
            this.btnZapisz = new System.Windows.Forms.Button();
            this.btnUsun = new System.Windows.Forms.Button();
            this.txtMiejsce = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.multiColumnComboBox1 = new MultiColumnComboBox.MultiColumnComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_baza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakupBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.zakupidDataGridViewTextBoxColumn,
            this.zakupdatazakupuDataGridViewTextBoxColumn,
            this.zakupklientidDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.zakupBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-3, -1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(368, 424);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // zakupidDataGridViewTextBoxColumn
            // 
            this.zakupidDataGridViewTextBoxColumn.DataPropertyName = "zakup_id";
            this.zakupidDataGridViewTextBoxColumn.HeaderText = "zakup_id";
            this.zakupidDataGridViewTextBoxColumn.Name = "zakupidDataGridViewTextBoxColumn";
            this.zakupidDataGridViewTextBoxColumn.ReadOnly = true;
            this.zakupidDataGridViewTextBoxColumn.Visible = false;
            // 
            // zakupdatazakupuDataGridViewTextBoxColumn
            // 
            this.zakupdatazakupuDataGridViewTextBoxColumn.DataPropertyName = "zakup_data_zakupu";
            this.zakupdatazakupuDataGridViewTextBoxColumn.HeaderText = "Data zakupu";
            this.zakupdatazakupuDataGridViewTextBoxColumn.Name = "zakupdatazakupuDataGridViewTextBoxColumn";
            // 
            // zakupklientidDataGridViewTextBoxColumn
            // 
            this.zakupklientidDataGridViewTextBoxColumn.DataPropertyName = "zakup_klient_id";
            this.zakupklientidDataGridViewTextBoxColumn.DataSource = this.klientBindingSource;
            this.zakupklientidDataGridViewTextBoxColumn.DisplayMember = "klient_nazwisko";
            this.zakupklientidDataGridViewTextBoxColumn.HeaderText = "Klient";
            this.zakupklientidDataGridViewTextBoxColumn.Name = "zakupklientidDataGridViewTextBoxColumn";
            this.zakupklientidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.zakupklientidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.zakupklientidDataGridViewTextBoxColumn.ValueMember = "klient_id";
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
            // zakupBindingSource
            // 
            this.zakupBindingSource.DataMember = "zakup";
            this.zakupBindingSource.DataSource = this.dataSet_baza;
            // 
            // zakupTableAdapter
            // 
            this.zakupTableAdapter.ClearBeforeFill = true;
            // 
            // klientTableAdapter
            // 
            this.klientTableAdapter.ClearBeforeFill = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(388, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Data zakupu";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // btnZapisz
            // 
            this.btnZapisz.Location = new System.Drawing.Point(581, 301);
            this.btnZapisz.Name = "btnZapisz";
            this.btnZapisz.Size = new System.Drawing.Size(75, 23);
            this.btnZapisz.TabIndex = 20;
            this.btnZapisz.Text = "Zapisz";
            this.btnZapisz.UseVisualStyleBackColor = true;
            this.btnZapisz.Click += new System.EventHandler(this.btnZapisz_Click);
            // 
            // btnUsun
            // 
            this.btnUsun.Location = new System.Drawing.Point(686, 301);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(75, 23);
            this.btnUsun.TabIndex = 19;
            this.btnUsun.Text = "Usuń";
            this.btnUsun.UseVisualStyleBackColor = true;
            this.btnUsun.Click += new System.EventHandler(this.btnUsun_Click);
            // 
            // txtMiejsce
            // 
            this.txtMiejsce.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zakupBindingSource, "zakup_data_zakupu", true));
            this.txtMiejsce.Location = new System.Drawing.Point(462, 47);
            this.txtMiejsce.Name = "txtMiejsce";
            this.txtMiejsce.Size = new System.Drawing.Size(405, 20);
            this.txtMiejsce.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(423, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Klient";
            // 
            // multiColumnComboBox1
            // 
            this.multiColumnComboBox1.DisplayDataMember = "klient_nazwisko";
            this.multiColumnComboBox1.DisplayDataSource = this.klientBindingSource;
            this.multiColumnComboBox1.Location = new System.Drawing.Point(462, 74);
            this.multiColumnComboBox1.Name = "multiColumnComboBox1";
            this.multiColumnComboBox1.SaveDataMember = "klient_imie";
            this.multiColumnComboBox1.SaveDataSource = this.klientBindingSource;
            this.multiColumnComboBox1.Size = new System.Drawing.Size(432, 20);
            this.multiColumnComboBox1.TabIndex = 32;
            // 
            // Zakup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 424);
            this.Controls.Add(this.multiColumnComboBox1);
            this.Controls.Add(this.txtMiejsce);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnZapisz);
            this.Controls.Add(this.btnUsun);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Zakup";
            this.Text = "Zakup";
            this.Load += new System.EventHandler(this.Zakup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_baza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakupBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet_baza dataSet_baza;
        private System.Windows.Forms.BindingSource zakupBindingSource;
        private DataSet_bazaTableAdapters.zakupTableAdapter zakupTableAdapter;
        private System.Windows.Forms.BindingSource klientBindingSource;
        private DataSet_bazaTableAdapters.klientTableAdapter klientTableAdapter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnZapisz;
        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.TextBox txtMiejsce;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn zakupidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zakupdatazakupuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn zakupklientidDataGridViewTextBoxColumn;
        private MultiColumnComboBox.MultiColumnComboBox multiColumnComboBox1;
    }
}