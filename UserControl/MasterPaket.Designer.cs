namespace D1_MIFTA_SETYA_PRATAMA
{
    partial class MasterPaket
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
            this.welcome = new System.Windows.Forms.Label();
            this.paketDataGridView = new System.Windows.Forms.DataGridView();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tambahBtn = new System.Windows.Forms.Button();
            this.Nama = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Harga = new System.Windows.Forms.Label();
            this.namaTB = new System.Windows.Forms.TextBox();
            this.paketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.simpanBtn = new System.Windows.Forms.Button();
            this.batalBtn = new System.Windows.Forms.Button();
            this.jenisCombo = new System.Windows.Forms.ComboBox();
            this.jenisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jenis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ubah = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Hapus = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.paketDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paketBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jenisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // welcome
            // 
            this.welcome.AutoSize = true;
            this.welcome.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome.Location = new System.Drawing.Point(27, 17);
            this.welcome.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(140, 30);
            this.welcome.TabIndex = 6;
            this.welcome.Text = "Master Paket";
            // 
            // paketDataGridView
            // 
            this.paketDataGridView.AllowUserToAddRows = false;
            this.paketDataGridView.AllowUserToDeleteRows = false;
            this.paketDataGridView.AllowUserToResizeColumns = false;
            this.paketDataGridView.AllowUserToResizeRows = false;
            this.paketDataGridView.AutoGenerateColumns = false;
            this.paketDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.paketDataGridView.ColumnHeadersHeight = 35;
            this.paketDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.paketDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.Jenis,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn6,
            this.Ubah,
            this.Hapus});
            this.paketDataGridView.DataSource = this.tableBindingSource;
            this.paketDataGridView.Location = new System.Drawing.Point(31, 53);
            this.paketDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.paketDataGridView.Name = "paketDataGridView";
            this.paketDataGridView.ReadOnly = true;
            this.paketDataGridView.RowHeadersVisible = false;
            this.paketDataGridView.RowTemplate.Height = 35;
            this.paketDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.paketDataGridView.Size = new System.Drawing.Size(642, 261);
            this.paketDataGridView.TabIndex = 7;
            this.paketDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.paketDataGridView_CellContentClick);
            this.paketDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.paketDataGridView_CellFormatting);
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataSource = typeof(D1_MIFTA_SETYA_PRATAMA.Paket);
            // 
            // tambahBtn
            // 
            this.tambahBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(82)))), ((int)(((byte)(173)))));
            this.tambahBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tambahBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.tambahBtn.Location = new System.Drawing.Point(558, 322);
            this.tambahBtn.Margin = new System.Windows.Forms.Padding(4);
            this.tambahBtn.Name = "tambahBtn";
            this.tambahBtn.Size = new System.Drawing.Size(115, 44);
            this.tambahBtn.TabIndex = 8;
            this.tambahBtn.Text = "Tambah";
            this.tambahBtn.UseVisualStyleBackColor = false;
            this.tambahBtn.Click += new System.EventHandler(this.tambahBtn_Click);
            // 
            // Nama
            // 
            this.Nama.AutoSize = true;
            this.Nama.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nama.Location = new System.Drawing.Point(28, 387);
            this.Nama.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Nama.Name = "Nama";
            this.Nama.Size = new System.Drawing.Size(46, 19);
            this.Nama.TabIndex = 11;
            this.Nama.Text = "Nama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(395, 387);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "Jenis";
            // 
            // Harga
            // 
            this.Harga.AutoSize = true;
            this.Harga.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Harga.Location = new System.Drawing.Point(28, 472);
            this.Harga.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Harga.Name = "Harga";
            this.Harga.Size = new System.Drawing.Size(99, 19);
            this.Harga.TabIndex = 13;
            this.Harga.Text = "Harga Per Jam";
            // 
            // namaTB
            // 
            this.namaTB.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.namaTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.namaTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paketBindingSource, "Nama", true));
            this.namaTB.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namaTB.Location = new System.Drawing.Point(32, 416);
            this.namaTB.Name = "namaTB";
            this.namaTB.Size = new System.Drawing.Size(287, 32);
            this.namaTB.TabIndex = 14;
            // 
            // paketBindingSource
            // 
            this.paketBindingSource.DataSource = typeof(D1_MIFTA_SETYA_PRATAMA.Paket);
            // 
            // simpanBtn
            // 
            this.simpanBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(82)))), ((int)(((byte)(173)))));
            this.simpanBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.simpanBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.simpanBtn.Location = new System.Drawing.Point(554, 489);
            this.simpanBtn.Margin = new System.Windows.Forms.Padding(4);
            this.simpanBtn.Name = "simpanBtn";
            this.simpanBtn.Size = new System.Drawing.Size(119, 44);
            this.simpanBtn.TabIndex = 18;
            this.simpanBtn.Text = "Simpan";
            this.simpanBtn.UseVisualStyleBackColor = false;
            this.simpanBtn.Click += new System.EventHandler(this.simpanBtn_Click);
            // 
            // batalBtn
            // 
            this.batalBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(82)))), ((int)(((byte)(173)))));
            this.batalBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.batalBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.batalBtn.Location = new System.Drawing.Point(427, 489);
            this.batalBtn.Margin = new System.Windows.Forms.Padding(4);
            this.batalBtn.Name = "batalBtn";
            this.batalBtn.Size = new System.Drawing.Size(119, 44);
            this.batalBtn.TabIndex = 19;
            this.batalBtn.Text = "Batal";
            this.batalBtn.UseVisualStyleBackColor = false;
            this.batalBtn.Click += new System.EventHandler(this.batalBtn_Click);
            // 
            // jenisCombo
            // 
            this.jenisCombo.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.paketBindingSource, "IDJenis", true));
            this.jenisCombo.DataSource = this.jenisBindingSource;
            this.jenisCombo.DisplayMember = "Jenis1";
            this.jenisCombo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jenisCombo.FormattingEnabled = true;
            this.jenisCombo.Location = new System.Drawing.Point(399, 415);
            this.jenisCombo.Name = "jenisCombo";
            this.jenisCombo.Size = new System.Drawing.Size(274, 33);
            this.jenisCombo.TabIndex = 20;
            this.jenisCombo.ValueMember = "ID";
            // 
            // jenisBindingSource
            // 
            this.jenisBindingSource.DataSource = typeof(D1_MIFTA_SETYA_PRATAMA.Jenis);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.paketBindingSource, "HargaPerJam", true));
            this.numericUpDown1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(31, 500);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(288, 33);
            this.numericUpDown1.TabIndex = 21;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nama";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nama";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "IDJenis";
            this.dataGridViewTextBoxColumn3.HeaderText = "IDJenis";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // Jenis
            // 
            this.Jenis.DataPropertyName = "Jenis";
            this.Jenis.HeaderText = "Jenis";
            this.Jenis.Name = "Jenis";
            this.Jenis.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "HargaPerJam";
            this.dataGridViewTextBoxColumn4.HeaderText = "HargaPerJam";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Transaksi";
            this.dataGridViewTextBoxColumn6.HeaderText = "Transaksi";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // Ubah
            // 
            this.Ubah.HeaderText = "";
            this.Ubah.Name = "Ubah";
            this.Ubah.ReadOnly = true;
            this.Ubah.Text = "Ubah";
            this.Ubah.UseColumnTextForButtonValue = true;
            // 
            // Hapus
            // 
            this.Hapus.HeaderText = "";
            this.Hapus.Name = "Hapus";
            this.Hapus.ReadOnly = true;
            this.Hapus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Hapus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Hapus.Text = "Hapus";
            this.Hapus.UseColumnTextForButtonValue = true;
            // 
            // MasterPaket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.jenisCombo);
            this.Controls.Add(this.batalBtn);
            this.Controls.Add(this.simpanBtn);
            this.Controls.Add(this.namaTB);
            this.Controls.Add(this.Harga);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nama);
            this.Controls.Add(this.tambahBtn);
            this.Controls.Add(this.paketDataGridView);
            this.Controls.Add(this.welcome);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MasterPaket";
            this.Size = new System.Drawing.Size(707, 561);
            this.Load += new System.EventHandler(this.MasterPaket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.paketDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paketBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jenisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcome;
        private System.Windows.Forms.BindingSource paketBindingSource;
        private System.Windows.Forms.DataGridView paketDataGridView;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private System.Windows.Forms.Button tambahBtn;
        private System.Windows.Forms.Label Nama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Harga;
        private System.Windows.Forms.TextBox namaTB;
        private System.Windows.Forms.Button simpanBtn;
        private System.Windows.Forms.Button batalBtn;
        private System.Windows.Forms.ComboBox jenisCombo;
        private System.Windows.Forms.BindingSource jenisBindingSource;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jenis;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewButtonColumn Ubah;
        private System.Windows.Forms.DataGridViewButtonColumn Hapus;
    }
}