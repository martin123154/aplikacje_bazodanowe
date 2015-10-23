namespace Zadanie_10
{
    partial class Premiera
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
            this.premieraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_baza = new Zadanie_10.DataSet_baza();
            this.premieraTableAdapter = new Zadanie_10.DataSet_bazaTableAdapters.premieraTableAdapter();
            this.btnZapisz = new System.Windows.Forms.Button();
            this.btnUsun = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtData_zak = new System.Windows.Forms.TextBox();
            this.txtData_rozp = new System.Windows.Forms.TextBox();
            this.txtTytul = new System.Windows.Forms.TextBox();
            this.premieraidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.premieratytulDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.premieradatarozpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.premieradatazakDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.premieraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_baza)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.premieraidDataGridViewTextBoxColumn,
            this.premieratytulDataGridViewTextBoxColumn,
            this.premieradatarozpDataGridViewTextBoxColumn,
            this.premieradatazakDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.premieraBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(345, 259);
            this.dataGridView1.TabIndex = 0;
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
            // premieraTableAdapter
            // 
            this.premieraTableAdapter.ClearBeforeFill = true;
            // 
            // btnZapisz
            // 
            this.btnZapisz.Location = new System.Drawing.Point(475, 218);
            this.btnZapisz.Name = "btnZapisz";
            this.btnZapisz.Size = new System.Drawing.Size(75, 23);
            this.btnZapisz.TabIndex = 20;
            this.btnZapisz.Text = "Zapisz";
            this.btnZapisz.UseVisualStyleBackColor = true;
            this.btnZapisz.Click += new System.EventHandler(this.btnZapisz_Click);
            // 
            // btnUsun
            // 
            this.btnUsun.Location = new System.Drawing.Point(565, 218);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(75, 23);
            this.btnUsun.TabIndex = 19;
            this.btnUsun.Text = "Usuń";
            this.btnUsun.UseVisualStyleBackColor = true;
            this.btnUsun.Click += new System.EventHandler(this.btnUsun_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(451, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Data rozpoczęcia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(451, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Data zakończenia";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(451, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Tytuł spektaklu";
            // 
            // txtData_zak
            // 
            this.txtData_zak.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.premieraBindingSource, "premiera_data_zak", true));
            this.txtData_zak.Location = new System.Drawing.Point(551, 95);
            this.txtData_zak.Name = "txtData_zak";
            this.txtData_zak.Size = new System.Drawing.Size(89, 20);
            this.txtData_zak.TabIndex = 26;
            // 
            // txtData_rozp
            // 
            this.txtData_rozp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.premieraBindingSource, "premiera_data_rozp", true));
            this.txtData_rozp.Location = new System.Drawing.Point(551, 67);
            this.txtData_rozp.Name = "txtData_rozp";
            this.txtData_rozp.Size = new System.Drawing.Size(89, 20);
            this.txtData_rozp.TabIndex = 25;
            // 
            // txtTytul
            // 
            this.txtTytul.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.premieraBindingSource, "premiera_tytul", true));
            this.txtTytul.Location = new System.Drawing.Point(551, 38);
            this.txtTytul.Name = "txtTytul";
            this.txtTytul.Size = new System.Drawing.Size(89, 20);
            this.txtTytul.TabIndex = 24;
            // 
            // premieraidDataGridViewTextBoxColumn
            // 
            this.premieraidDataGridViewTextBoxColumn.DataPropertyName = "premiera_id";
            this.premieraidDataGridViewTextBoxColumn.HeaderText = "premiera_id";
            this.premieraidDataGridViewTextBoxColumn.Name = "premieraidDataGridViewTextBoxColumn";
            this.premieraidDataGridViewTextBoxColumn.ReadOnly = true;
            this.premieraidDataGridViewTextBoxColumn.Visible = false;
            // 
            // premieratytulDataGridViewTextBoxColumn
            // 
            this.premieratytulDataGridViewTextBoxColumn.DataPropertyName = "premiera_tytul";
            this.premieratytulDataGridViewTextBoxColumn.HeaderText = "Tytuł spektaklu";
            this.premieratytulDataGridViewTextBoxColumn.Name = "premieratytulDataGridViewTextBoxColumn";
            // 
            // premieradatarozpDataGridViewTextBoxColumn
            // 
            this.premieradatarozpDataGridViewTextBoxColumn.DataPropertyName = "premiera_data_rozp";
            this.premieradatarozpDataGridViewTextBoxColumn.HeaderText = "Data rozpoczęcia";
            this.premieradatarozpDataGridViewTextBoxColumn.Name = "premieradatarozpDataGridViewTextBoxColumn";
            // 
            // premieradatazakDataGridViewTextBoxColumn
            // 
            this.premieradatazakDataGridViewTextBoxColumn.DataPropertyName = "premiera_data_zak";
            this.premieradatazakDataGridViewTextBoxColumn.HeaderText = "Data zakończenia";
            this.premieradatazakDataGridViewTextBoxColumn.Name = "premieradatazakDataGridViewTextBoxColumn";
            // 
            // Premiera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 262);
            this.Controls.Add(this.txtData_zak);
            this.Controls.Add(this.txtData_rozp);
            this.Controls.Add(this.txtTytul);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnZapisz);
            this.Controls.Add(this.btnUsun);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Premiera";
            this.Text = "Premiera";
            this.Load += new System.EventHandler(this.Premiera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.premieraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_baza)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet_baza dataSet_baza;
        private System.Windows.Forms.BindingSource premieraBindingSource;
        private DataSet_bazaTableAdapters.premieraTableAdapter premieraTableAdapter;
        private System.Windows.Forms.Button btnZapisz;
        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtData_zak;
        private System.Windows.Forms.TextBox txtData_rozp;
        private System.Windows.Forms.TextBox txtTytul;
        private System.Windows.Forms.DataGridViewTextBoxColumn premieraidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn premieratytulDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn premieradatarozpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn premieradatazakDataGridViewTextBoxColumn;
    }
}