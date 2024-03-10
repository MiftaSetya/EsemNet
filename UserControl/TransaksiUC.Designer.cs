namespace D1_MIFTA_SETYA_PRATAMA
{
    partial class TransaksiUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.welcome = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.transaksiDataGridView = new System.Windows.Forms.DataGridView();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transaksiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Komputer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Paket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Durasi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tanggal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Waktu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Operator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detail = new System.Windows.Forms.DataGridViewButtonColumn();
            this.TambahDurasi = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Tambah = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transaksiDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transaksiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // welcome
            // 
            this.welcome.AutoSize = true;
            this.welcome.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome.Location = new System.Drawing.Point(27, 17);
            this.welcome.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(102, 30);
            this.welcome.TabIndex = 34;
            this.welcome.Text = "Transaksi";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(32, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(642, 73);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(411, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(203, 25);
            this.comboBox1.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(81, 25);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(217, 25);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(323, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Komputer :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tanggal :";
            // 
            // transaksiDataGridView
            // 
            this.transaksiDataGridView.AllowUserToAddRows = false;
            this.transaksiDataGridView.AllowUserToDeleteRows = false;
            this.transaksiDataGridView.AllowUserToResizeColumns = false;
            this.transaksiDataGridView.AllowUserToResizeRows = false;
            this.transaksiDataGridView.AutoGenerateColumns = false;
            this.transaksiDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.transaksiDataGridView.ColumnHeadersHeight = 35;
            this.transaksiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.transaksiDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Komputer,
            this.Paket,
            this.Durasi,
            this.Tanggal,
            this.Waktu,
            this.Operator,
            this.Detail,
            this.TambahDurasi,
            this.Tambah,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn14});
            this.transaksiDataGridView.DataSource = this.tableBindingSource;
            this.transaksiDataGridView.Location = new System.Drawing.Point(32, 149);
            this.transaksiDataGridView.Name = "transaksiDataGridView";
            this.transaksiDataGridView.ReadOnly = true;
            this.transaksiDataGridView.RowHeadersVisible = false;
            this.transaksiDataGridView.RowTemplate.Height = 35;
            this.transaksiDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.transaksiDataGridView.Size = new System.Drawing.Size(642, 220);
            this.transaksiDataGridView.TabIndex = 36;
            this.transaksiDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.transaksiDataGridView_CellFormatting);
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataSource = typeof(D1_MIFTA_SETYA_PRATAMA.Transaksi);
            // 
            // transaksiBindingSource
            // 
            this.transaksiBindingSource.DataSource = typeof(D1_MIFTA_SETYA_PRATAMA.Transaksi);
            // 
            // Komputer
            // 
            this.Komputer.DataPropertyName = "Komputer";
            this.Komputer.HeaderText = "Komputer";
            this.Komputer.Name = "Komputer";
            this.Komputer.ReadOnly = true;
            // 
            // Paket
            // 
            this.Paket.DataPropertyName = "Paket";
            this.Paket.HeaderText = "Paket";
            this.Paket.Name = "Paket";
            this.Paket.ReadOnly = true;
            // 
            // Durasi
            // 
            this.Durasi.DataPropertyName = "Durasi";
            this.Durasi.HeaderText = "Durasi";
            this.Durasi.Name = "Durasi";
            this.Durasi.ReadOnly = true;
            // 
            // Tanggal
            // 
            this.Tanggal.DataPropertyName = "Tanggal";
            this.Tanggal.HeaderText = "Tanggal";
            this.Tanggal.Name = "Tanggal";
            this.Tanggal.ReadOnly = true;
            // 
            // Waktu
            // 
            this.Waktu.DataPropertyName = "Waktu";
            this.Waktu.HeaderText = "Waktu";
            this.Waktu.Name = "Waktu";
            this.Waktu.ReadOnly = true;
            // 
            // Operator
            // 
            this.Operator.DataPropertyName = "DibuatOleh";
            this.Operator.HeaderText = "Operator";
            this.Operator.Name = "Operator";
            this.Operator.ReadOnly = true;
            // 
            // Detail
            // 
            this.Detail.HeaderText = "";
            this.Detail.Name = "Detail";
            this.Detail.ReadOnly = true;
            this.Detail.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Detail.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Detail.Text = "Detail";
            this.Detail.UseColumnTextForButtonValue = true;
            // 
            // TambahDurasi
            // 
            this.TambahDurasi.HeaderText = "";
            this.TambahDurasi.Name = "TambahDurasi";
            this.TambahDurasi.ReadOnly = true;
            this.TambahDurasi.Text = "Tambah Durasi";
            this.TambahDurasi.UseColumnTextForButtonValue = true;
            // 
            // Tambah
            // 
            this.Tambah.HeaderText = "";
            this.Tambah.Name = "Tambah";
            this.Tambah.ReadOnly = true;
            this.Tambah.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Tambah.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Tambah.Text = "Tambah";
            this.Tambah.UseColumnTextForButtonValue = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "IDKomputer";
            this.dataGridViewTextBoxColumn2.HeaderText = "IDKomputer";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "IDMember";
            this.dataGridViewTextBoxColumn3.HeaderText = "IDMember";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "IDPaket";
            this.dataGridViewTextBoxColumn4.HeaderText = "IDPaket";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "IDPotonganHarga";
            this.dataGridViewTextBoxColumn5.HeaderText = "IDPotonganHarga";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "KodePotonganHarga";
            this.dataGridViewTextBoxColumn10.HeaderText = "KodePotonganHarga";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Visible = false;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Member";
            this.dataGridViewTextBoxColumn12.HeaderText = "Member";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Visible = false;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Pengguna";
            this.dataGridViewTextBoxColumn14.HeaderText = "Pengguna";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Visible = false;
            // 
            // TransaksiUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.transaksiDataGridView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.welcome);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TransaksiUC";
            this.Size = new System.Drawing.Size(707, 561);
            this.Load += new System.EventHandler(this.FormTransaksi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transaksiDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transaksiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcome;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource transaksiBindingSource;
        private System.Windows.Forms.DataGridView transaksiDataGridView;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Komputer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Paket;
        private System.Windows.Forms.DataGridViewTextBoxColumn Durasi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tanggal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Waktu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Operator;
        private System.Windows.Forms.DataGridViewButtonColumn Detail;
        private System.Windows.Forms.DataGridViewButtonColumn TambahDurasi;
        private System.Windows.Forms.DataGridViewButtonColumn Tambah;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
    }
}
