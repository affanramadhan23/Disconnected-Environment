namespace Disconnected_Environment
{
    partial class data_prodi
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
            this.idprodiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaprodiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kampusDataSet = new Disconnected_Environment.kampusDataSet();
            this.btnOpen = new System.Windows.Forms.Button();
            this.nmp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.prodiTableAdapter = new Disconnected_Environment.kampusDataSetTableAdapters.prodiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kampusDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idprodiDataGridViewTextBoxColumn,
            this.namaprodiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.prodiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(173, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(431, 235);
            this.dataGridView1.TabIndex = 0;
            // 
            // idprodiDataGridViewTextBoxColumn
            // 
            this.idprodiDataGridViewTextBoxColumn.DataPropertyName = "id_prodi";
            this.idprodiDataGridViewTextBoxColumn.HeaderText = "id_prodi";
            this.idprodiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idprodiDataGridViewTextBoxColumn.Name = "idprodiDataGridViewTextBoxColumn";
            this.idprodiDataGridViewTextBoxColumn.Width = 125;
            // 
            // namaprodiDataGridViewTextBoxColumn
            // 
            this.namaprodiDataGridViewTextBoxColumn.DataPropertyName = "nama_prodi";
            this.namaprodiDataGridViewTextBoxColumn.HeaderText = "nama_prodi";
            this.namaprodiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namaprodiDataGridViewTextBoxColumn.Name = "namaprodiDataGridViewTextBoxColumn";
            this.namaprodiDataGridViewTextBoxColumn.Width = 125;
            // 
            // prodiBindingSource
            // 
            this.prodiBindingSource.DataMember = "prodi";
            this.prodiBindingSource.DataSource = this.kampusDataSet;
            // 
            // kampusDataSet
            // 
            this.kampusDataSet.DataSetName = "kampusDataSet";
            this.kampusDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(648, 38);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(89, 39);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // nmp
            // 
            this.nmp.Location = new System.Drawing.Point(290, 327);
            this.nmp.Name = "nmp";
            this.nmp.Size = new System.Drawing.Size(210, 22);
            this.nmp.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(205, 330);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nama Prodi";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(290, 378);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(519, 327);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Add";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(411, 378);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // prodiTableAdapter
            // 
            this.prodiTableAdapter.ClearBeforeFill = true;
            // 
            // data_prodi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nmp);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.dataGridView1);
            this.Name = "data_prodi";
            this.Text = "Data Prodi";
            this.Load += new System.EventHandler(this.data_prodi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kampusDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.TextBox nmp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnClear;
        private kampusDataSet kampusDataSet;
        private System.Windows.Forms.BindingSource prodiBindingSource;
        private kampusDataSetTableAdapters.prodiTableAdapter prodiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idprodiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaprodiDataGridViewTextBoxColumn;
    }
}