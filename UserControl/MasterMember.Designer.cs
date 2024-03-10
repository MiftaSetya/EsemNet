namespace D1_MIFTA_SETYA_PRATAMA
{
    partial class MasterMember
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
            this.batalBtn = new System.Windows.Forms.Button();
            this.simpanBtn = new System.Windows.Forms.Button();
            this.Harga = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tambahBtn = new System.Windows.Forms.Button();
            this.Nomor = new System.Windows.Forms.Label();
            this.memberDataGridView = new System.Windows.Forms.DataGridView();
            this.welcome = new System.Windows.Forms.Label();
            this.namaTB = new System.Windows.Forms.TextBox();
            this.alamatTB = new System.Windows.Forms.TextBox();
            this.nonaktifkan = new System.Windows.Forms.Button();
            this.aktifkan = new System.Windows.Forms.Button();
            this.teleponTB = new System.Windows.Forms.TextBox();
            this.ubahBtn = new System.Windows.Forms.Button();
            this.hapusBtn = new System.Windows.Forms.Button();
            this.memberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teleponDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alamatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masihAktifDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.transaksiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.memberDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // batalBtn
            // 
            this.batalBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(82)))), ((int)(((byte)(173)))));
            this.batalBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.batalBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.batalBtn.Location = new System.Drawing.Point(428, 490);
            this.batalBtn.Margin = new System.Windows.Forms.Padding(4);
            this.batalBtn.Name = "batalBtn";
            this.batalBtn.Size = new System.Drawing.Size(119, 44);
            this.batalBtn.TabIndex = 41;
            this.batalBtn.Text = "Batal";
            this.batalBtn.UseVisualStyleBackColor = false;
            this.batalBtn.Click += new System.EventHandler(this.batalBtn_Click);
            // 
            // simpanBtn
            // 
            this.simpanBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(82)))), ((int)(((byte)(173)))));
            this.simpanBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.simpanBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.simpanBtn.Location = new System.Drawing.Point(555, 490);
            this.simpanBtn.Margin = new System.Windows.Forms.Padding(4);
            this.simpanBtn.Name = "simpanBtn";
            this.simpanBtn.Size = new System.Drawing.Size(119, 44);
            this.simpanBtn.TabIndex = 40;
            this.simpanBtn.Text = "Simpan";
            this.simpanBtn.UseVisualStyleBackColor = false;
            this.simpanBtn.Click += new System.EventHandler(this.simpanBtn_Click);
            // 
            // Harga
            // 
            this.Harga.AutoSize = true;
            this.Harga.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Harga.Location = new System.Drawing.Point(30, 418);
            this.Harga.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Harga.Name = "Harga";
            this.Harga.Size = new System.Drawing.Size(58, 19);
            this.Harga.TabIndex = 38;
            this.Harga.Text = "Telepon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(396, 349);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 19);
            this.label2.TabIndex = 37;
            this.label2.Text = "Alamat";
            // 
            // tambahBtn
            // 
            this.tambahBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(82)))), ((int)(((byte)(173)))));
            this.tambahBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tambahBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.tambahBtn.Location = new System.Drawing.Point(555, 290);
            this.tambahBtn.Margin = new System.Windows.Forms.Padding(4);
            this.tambahBtn.Name = "tambahBtn";
            this.tambahBtn.Size = new System.Drawing.Size(119, 44);
            this.tambahBtn.TabIndex = 35;
            this.tambahBtn.Text = "Tambah";
            this.tambahBtn.UseVisualStyleBackColor = false;
            this.tambahBtn.Click += new System.EventHandler(this.tambahBtn_Click);
            // 
            // Nomor
            // 
            this.Nomor.AutoSize = true;
            this.Nomor.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nomor.Location = new System.Drawing.Point(29, 349);
            this.Nomor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Nomor.Name = "Nomor";
            this.Nomor.Size = new System.Drawing.Size(46, 19);
            this.Nomor.TabIndex = 36;
            this.Nomor.Text = "Nama";
            // 
            // memberDataGridView
            // 
            this.memberDataGridView.AllowUserToAddRows = false;
            this.memberDataGridView.AllowUserToDeleteRows = false;
            this.memberDataGridView.AllowUserToResizeColumns = false;
            this.memberDataGridView.AllowUserToResizeRows = false;
            this.memberDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.memberDataGridView.AutoGenerateColumns = false;
            this.memberDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.memberDataGridView.ColumnHeadersHeight = 35;
            this.memberDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.memberDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.namaDataGridViewTextBoxColumn,
            this.teleponDataGridViewTextBoxColumn,
            this.alamatDataGridViewTextBoxColumn,
            this.masihAktifDataGridViewCheckBoxColumn,
            this.transaksiDataGridViewTextBoxColumn});
            this.memberDataGridView.DataSource = this.tableBindingSource;
            this.memberDataGridView.Location = new System.Drawing.Point(32, 53);
            this.memberDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.memberDataGridView.Name = "memberDataGridView";
            this.memberDataGridView.ReadOnly = true;
            this.memberDataGridView.RowHeadersVisible = false;
            this.memberDataGridView.RowTemplate.Height = 35;
            this.memberDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.memberDataGridView.Size = new System.Drawing.Size(642, 229);
            this.memberDataGridView.TabIndex = 34;
            // 
            // welcome
            // 
            this.welcome.AutoSize = true;
            this.welcome.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome.Location = new System.Drawing.Point(27, 17);
            this.welcome.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(168, 30);
            this.welcome.TabIndex = 33;
            this.welcome.Text = "Master Member";
            // 
            // namaTB
            // 
            this.namaTB.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.namaTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.namaTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memberBindingSource, "Nama", true));
            this.namaTB.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namaTB.Location = new System.Drawing.Point(32, 378);
            this.namaTB.Name = "namaTB";
            this.namaTB.Size = new System.Drawing.Size(287, 32);
            this.namaTB.TabIndex = 43;
            // 
            // alamatTB
            // 
            this.alamatTB.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.alamatTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.alamatTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memberBindingSource, "Alamat", true));
            this.alamatTB.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alamatTB.Location = new System.Drawing.Point(400, 378);
            this.alamatTB.Multiline = true;
            this.alamatTB.Name = "alamatTB";
            this.alamatTB.Size = new System.Drawing.Size(274, 101);
            this.alamatTB.TabIndex = 44;
            // 
            // nonaktifkan
            // 
            this.nonaktifkan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(82)))), ((int)(((byte)(173)))));
            this.nonaktifkan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nonaktifkan.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.nonaktifkan.Location = new System.Drawing.Point(32, 290);
            this.nonaktifkan.Margin = new System.Windows.Forms.Padding(4);
            this.nonaktifkan.Name = "nonaktifkan";
            this.nonaktifkan.Size = new System.Drawing.Size(119, 44);
            this.nonaktifkan.TabIndex = 45;
            this.nonaktifkan.Text = "Nonaktifkan";
            this.nonaktifkan.UseVisualStyleBackColor = false;
            this.nonaktifkan.Click += new System.EventHandler(this.nonaktifkan_Click);
            // 
            // aktifkan
            // 
            this.aktifkan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(82)))), ((int)(((byte)(173)))));
            this.aktifkan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aktifkan.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.aktifkan.Location = new System.Drawing.Point(156, 290);
            this.aktifkan.Margin = new System.Windows.Forms.Padding(4);
            this.aktifkan.Name = "aktifkan";
            this.aktifkan.Size = new System.Drawing.Size(119, 44);
            this.aktifkan.TabIndex = 46;
            this.aktifkan.Text = "Aktifkan";
            this.aktifkan.UseVisualStyleBackColor = false;
            this.aktifkan.Click += new System.EventHandler(this.aktifkan_Click);
            // 
            // teleponTB
            // 
            this.teleponTB.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.teleponTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.teleponTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memberBindingSource, "Telepon", true));
            this.teleponTB.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teleponTB.Location = new System.Drawing.Point(32, 447);
            this.teleponTB.Name = "teleponTB";
            this.teleponTB.Size = new System.Drawing.Size(287, 32);
            this.teleponTB.TabIndex = 47;
            // 
            // ubahBtn
            // 
            this.ubahBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(82)))), ((int)(((byte)(173)))));
            this.ubahBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ubahBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ubahBtn.Location = new System.Drawing.Point(432, 290);
            this.ubahBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ubahBtn.Name = "ubahBtn";
            this.ubahBtn.Size = new System.Drawing.Size(119, 44);
            this.ubahBtn.TabIndex = 48;
            this.ubahBtn.Text = "Ubah";
            this.ubahBtn.UseVisualStyleBackColor = false;
            this.ubahBtn.Click += new System.EventHandler(this.ubahBtn_Click);
            // 
            // hapusBtn
            // 
            this.hapusBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(82)))), ((int)(((byte)(173)))));
            this.hapusBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hapusBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.hapusBtn.Location = new System.Drawing.Point(309, 290);
            this.hapusBtn.Margin = new System.Windows.Forms.Padding(4);
            this.hapusBtn.Name = "hapusBtn";
            this.hapusBtn.Size = new System.Drawing.Size(119, 44);
            this.hapusBtn.TabIndex = 49;
            this.hapusBtn.Text = "Hapus";
            this.hapusBtn.UseVisualStyleBackColor = false;
            this.hapusBtn.Click += new System.EventHandler(this.hapusBtn_Click);
            // 
            // memberBindingSource
            // 
            this.memberBindingSource.DataSource = typeof(D1_MIFTA_SETYA_PRATAMA.Member);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // namaDataGridViewTextBoxColumn
            // 
            this.namaDataGridViewTextBoxColumn.DataPropertyName = "Nama";
            this.namaDataGridViewTextBoxColumn.HeaderText = "Nama";
            this.namaDataGridViewTextBoxColumn.Name = "namaDataGridViewTextBoxColumn";
            this.namaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // teleponDataGridViewTextBoxColumn
            // 
            this.teleponDataGridViewTextBoxColumn.DataPropertyName = "Telepon";
            this.teleponDataGridViewTextBoxColumn.HeaderText = "Telepon";
            this.teleponDataGridViewTextBoxColumn.Name = "teleponDataGridViewTextBoxColumn";
            this.teleponDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // alamatDataGridViewTextBoxColumn
            // 
            this.alamatDataGridViewTextBoxColumn.DataPropertyName = "Alamat";
            this.alamatDataGridViewTextBoxColumn.HeaderText = "Alamat";
            this.alamatDataGridViewTextBoxColumn.Name = "alamatDataGridViewTextBoxColumn";
            this.alamatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // masihAktifDataGridViewCheckBoxColumn
            // 
            this.masihAktifDataGridViewCheckBoxColumn.DataPropertyName = "MasihAktif";
            this.masihAktifDataGridViewCheckBoxColumn.HeaderText = "MasihAktif";
            this.masihAktifDataGridViewCheckBoxColumn.Name = "masihAktifDataGridViewCheckBoxColumn";
            this.masihAktifDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // transaksiDataGridViewTextBoxColumn
            // 
            this.transaksiDataGridViewTextBoxColumn.DataPropertyName = "Transaksi";
            this.transaksiDataGridViewTextBoxColumn.HeaderText = "Transaksi";
            this.transaksiDataGridViewTextBoxColumn.Name = "transaksiDataGridViewTextBoxColumn";
            this.transaksiDataGridViewTextBoxColumn.ReadOnly = true;
            this.transaksiDataGridViewTextBoxColumn.Visible = false;
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataSource = typeof(D1_MIFTA_SETYA_PRATAMA.Member);
            // 
            // MasterMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.hapusBtn);
            this.Controls.Add(this.ubahBtn);
            this.Controls.Add(this.teleponTB);
            this.Controls.Add(this.aktifkan);
            this.Controls.Add(this.nonaktifkan);
            this.Controls.Add(this.alamatTB);
            this.Controls.Add(this.namaTB);
            this.Controls.Add(this.batalBtn);
            this.Controls.Add(this.simpanBtn);
            this.Controls.Add(this.Harga);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tambahBtn);
            this.Controls.Add(this.Nomor);
            this.Controls.Add(this.memberDataGridView);
            this.Controls.Add(this.welcome);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MasterMember";
            this.Size = new System.Drawing.Size(707, 561);
            this.Load += new System.EventHandler(this.MasterMember_Load);
            ((System.ComponentModel.ISupportInitialize)(this.memberDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button batalBtn;
        private System.Windows.Forms.Button simpanBtn;
        private System.Windows.Forms.Label Harga;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button tambahBtn;
        private System.Windows.Forms.Label Nomor;
        private System.Windows.Forms.DataGridView memberDataGridView;
        private System.Windows.Forms.Label welcome;
        private System.Windows.Forms.TextBox namaTB;
        private System.Windows.Forms.TextBox alamatTB;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private System.Windows.Forms.Button nonaktifkan;
        private System.Windows.Forms.Button aktifkan;
        private System.Windows.Forms.BindingSource memberBindingSource;
        private System.Windows.Forms.TextBox teleponTB;
        private System.Windows.Forms.Button ubahBtn;
        private System.Windows.Forms.Button hapusBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teleponDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn masihAktifDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transaksiDataGridViewTextBoxColumn;
    }
}
