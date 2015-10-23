namespace Zadanie_10
{
    partial class Wystep
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
            this.wystepidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wysteppremieraidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.premieraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_baza = new Zadanie_10.DataSet_baza();
            this.wystepaktoridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.aktorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wystepBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wystepTableAdapter = new Zadanie_10.DataSet_bazaTableAdapters.wystepTableAdapter();
            this.premieraTableAdapter = new Zadanie_10.DataSet_bazaTableAdapters.premieraTableAdapter();
            this.aktorTableAdapter = new Zadanie_10.DataSet_bazaTableAdapters.aktorTableAdapter();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnZapisz = new System.Windows.Forms.Button();
            this.btnUsun = new System.Windows.Forms.Button();
            this.multiColumnComboBox1 = new MultiColumnComboBox.MultiColumnComboBox();
            this.multiColumnComboBox2 = new MultiColumnComboBox.MultiColumnComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.premieraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_baza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aktorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wystepBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.wystepidDataGridViewTextBoxColumn,
            this.wysteppremieraidDataGridViewTextBoxColumn,
            this.wystepaktoridDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.wystepBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(345, 260);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // wystepidDataGridViewTextBoxColumn
            // 
            this.wystepidDataGridViewTextBoxColumn.DataPropertyName = "wystep_id";
            this.wystepidDataGridViewTextBoxColumn.HeaderText = "wystep_id";
            this.wystepidDataGridViewTextBoxColumn.Name = "wystepidDataGridViewTextBoxColumn";
            this.wystepidDataGridViewTextBoxColumn.ReadOnly = true;
            this.wystepidDataGridViewTextBoxColumn.Visible = false;
            // 
            // wysteppremieraidDataGridViewTextBoxColumn
            // 
            this.wysteppremieraidDataGridViewTextBoxColumn.DataPropertyName = "wystep_premiera_id";
            this.wysteppremieraidDataGridViewTextBoxColumn.DataSource = this.premieraBindingSource;
            this.wysteppremieraidDataGridViewTextBoxColumn.DisplayMember = "premiera_tytul";
            this.wysteppremieraidDataGridViewTextBoxColumn.HeaderText = "Tytuł spektaklu";
            this.wysteppremieraidDataGridViewTextBoxColumn.Name = "wysteppremieraidDataGridViewTextBoxColumn";
            this.wysteppremieraidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.wysteppremieraidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.wysteppremieraidDataGridViewTextBoxColumn.ValueMember = "premiera_id";
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
            // wystepaktoridDataGridViewTextBoxColumn
            // 
            this.wystepaktoridDataGridViewTextBoxColumn.DataPropertyName = "wystep_aktor_id";
            this.wystepaktoridDataGridViewTextBoxColumn.DataSource = this.aktorBindingSource;
            this.wystepaktoridDataGridViewTextBoxColumn.DisplayMember = "aktor_nazwisko";
            this.wystepaktoridDataGridViewTextBoxColumn.HeaderText = "Aktor";
            this.wystepaktoridDataGridViewTextBoxColumn.Name = "wystepaktoridDataGridViewTextBoxColumn";
            this.wystepaktoridDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.wystepaktoridDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.wystepaktoridDataGridViewTextBoxColumn.ValueMember = "aktor_id";
            // 
            // aktorBindingSource
            // 
            this.aktorBindingSource.DataMember = "aktor";
            this.aktorBindingSource.DataSource = this.dataSet_baza;
            // 
            // wystepBindingSource
            // 
            this.wystepBindingSource.DataMember = "wystep";
            this.wystepBindingSource.DataSource = this.dataSet_baza;
            // 
            // wystepTableAdapter
            // 
            this.wystepTableAdapter.ClearBeforeFill = true;
            // 
            // premieraTableAdapter
            // 
            this.premieraTableAdapter.ClearBeforeFill = true;
            // 
            // aktorTableAdapter
            // 
            this.aktorTableAdapter.ClearBeforeFill = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(407, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Aktor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(368, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Tytuł spektaklu";
            // 
            // btnZapisz
            // 
            this.btnZapisz.Location = new System.Drawing.Point(694, 210);
            this.btnZapisz.Name = "btnZapisz";
            this.btnZapisz.Size = new System.Drawing.Size(75, 23);
            this.btnZapisz.TabIndex = 34;
            this.btnZapisz.Text = "Zapisz";
            this.btnZapisz.UseVisualStyleBackColor = true;
            this.btnZapisz.Click += new System.EventHandler(this.btnZapisz_Click);
            // 
            // btnUsun
            // 
            this.btnUsun.Location = new System.Drawing.Point(801, 210);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(75, 23);
            this.btnUsun.TabIndex = 33;
            this.btnUsun.Text = "Usuń";
            this.btnUsun.UseVisualStyleBackColor = true;
            this.btnUsun.Click += new System.EventHandler(this.btnUsun_Click);
            // 
            // multiColumnComboBox1
            // 
            this.multiColumnComboBox1.DisplayDataMember = "premiera_tytul";
            this.multiColumnComboBox1.DisplayDataSource = this.premieraBindingSource;
            this.multiColumnComboBox1.Location = new System.Drawing.Point(469, 56);
            this.multiColumnComboBox1.Name = "multiColumnComboBox1";
            this.multiColumnComboBox1.SaveDataMember = "premiera_data_rozp";
            this.multiColumnComboBox1.SaveDataSource = this.premieraBindingSource;
            this.multiColumnComboBox1.Size = new System.Drawing.Size(432, 20);
            this.multiColumnComboBox1.TabIndex = 35;
            // 
            // multiColumnComboBox2
            // 
            this.multiColumnComboBox2.DisplayDataMember = "aktor_nazwisko";
            this.multiColumnComboBox2.DisplayDataSource = this.aktorBindingSource;
            this.multiColumnComboBox2.Location = new System.Drawing.Point(469, 82);
            this.multiColumnComboBox2.Name = "multiColumnComboBox2";
            this.multiColumnComboBox2.SaveDataMember = "aktor_imie";
            this.multiColumnComboBox2.SaveDataSource = this.aktorBindingSource;
            this.multiColumnComboBox2.Size = new System.Drawing.Size(432, 20);
            this.multiColumnComboBox2.TabIndex = 36;
            // 
            // Wystep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 262);
            this.Controls.Add(this.multiColumnComboBox2);
            this.Controls.Add(this.multiColumnComboBox1);
            this.Controls.Add(this.btnZapisz);
            this.Controls.Add(this.btnUsun);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Wystep";
            this.Text = "Wystep";
            this.Load += new System.EventHandler(this.Wystep_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.premieraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_baza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aktorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wystepBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet_baza dataSet_baza;
        private System.Windows.Forms.BindingSource wystepBindingSource;
        private DataSet_bazaTableAdapters.wystepTableAdapter wystepTableAdapter;
        private System.Windows.Forms.BindingSource premieraBindingSource;
        private DataSet_bazaTableAdapters.premieraTableAdapter premieraTableAdapter;
        private System.Windows.Forms.BindingSource aktorBindingSource;
        private DataSet_bazaTableAdapters.aktorTableAdapter aktorTableAdapter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnZapisz;
        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.DataGridViewTextBoxColumn wystepidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn wysteppremieraidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn wystepaktoridDataGridViewTextBoxColumn;
        private MultiColumnComboBox.MultiColumnComboBox multiColumnComboBox1;
        private MultiColumnComboBox.MultiColumnComboBox multiColumnComboBox2;
    }
}