namespace D1_MIFTA_SETYA_PRATAMA
{
    partial class MasterKomputer
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
            this.komputerDataGridView = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.merekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDJenisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jenis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transaksiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Hapus = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.komputerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.jenisCombo = new System.Windows.Forms.ComboBox();
            this.jenisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.batalBtn = new System.Windows.Forms.Button();
            this.simpanBtn = new System.Windows.Forms.Button();
            this.merkTB = new System.Windows.Forms.TextBox();
            this.Harga = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Nomor = new System.Windows.Forms.Label();
            this.tambahBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.komputerDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.komputerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jenisBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // welcome
            // 
            this.welcome.AutoSize = true;
            this.welcome.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome.Location = new System.Drawing.Point(27, 17);
            this.welcome.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(185, 30);
            this.welcome.TabIndex = 7;
            this.welcome.Text = "Master Komputer";
            // 
            // komputerDataGridView
            // 
            this.komputerDataGridView.AllowUserToAddRows = false;
            this.komputerDataGridView.AllowUserToDeleteRows = false;
            this.komputerDataGridView.AllowUserToResizeColumns = false;
            this.komputerDataGridView.AllowUserToResizeRows = false;
            this.komputerDataGridView.AutoGenerateColumns = false;
            this.komputerDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.komputerDataGridView.ColumnHeadersHeight = 35;
            this.komputerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.komputerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nomorDataGridViewTextBoxColumn,
            this.merekDataGridViewTextBoxColumn,
            this.iDJenisDataGridViewTextBoxColumn,
            this.Jenis,
            this.transaksiDataGridViewTextBoxColumn,
            this.Edit,
            this.Hapus});
            this.komputerDataGridView.DataSource = this.tableBindingSource;
            this.komputerDataGridView.Location = new System.Drawing.Point(32, 53);
            this.komputerDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.komputerDataGridView.Name = "komputerDataGridView";
            this.komputerDataGridView.ReadOnly = true;
            this.komputerDataGridView.RowHeadersVisible = false;
            this.komputerDataGridView.RowTemplate.Height = 35;
            this.komputerDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.komputerDataGridView.Size = new System.Drawing.Size(642, 262);
            this.komputerDataGridView.TabIndex = 8;
            this.komputerDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.komputerDataGridView_CellContentClick);
            this.komputerDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.paketDataGridView_CellFormatting);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // nomorDataGridViewTextBoxColumn
            // 
            this.nomorDataGridViewTextBoxColumn.DataPropertyName = "Nomor";
            this.nomorDataGridViewTextBoxColumn.HeaderText = "Nomor";
            this.nomorDataGridViewTextBoxColumn.Name = "nomorDataGridViewTextBoxColumn";
            this.nomorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // merekDataGridViewTextBoxColumn
            // 
            this.merekDataGridViewTextBoxColumn.DataPropertyName = "Merek";
            this.merekDataGridViewTextBoxColumn.HeaderText = "Merek";
            this.merekDataGridViewTextBoxColumn.Name = "merekDataGridViewTextBoxColumn";
            this.merekDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDJenisDataGridViewTextBoxColumn
            // 
            this.iDJenisDataGridViewTextBoxColumn.DataPropertyName = "IDJenis";
            this.iDJenisDataGridViewTextBoxColumn.HeaderText = "IDJenis";
            this.iDJenisDataGridViewTextBoxColumn.Name = "iDJenisDataGridViewTextBoxColumn";
            this.iDJenisDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDJenisDataGridViewTextBoxColumn.Visible = false;
            // 
            // Jenis
            // 
            this.Jenis.DataPropertyName = "Jenis";
            this.Jenis.HeaderText = "Jenis";
            this.Jenis.Name = "Jenis";
            this.Jenis.ReadOnly = true;
            // 
            // transaksiDataGridViewTextBoxColumn
            // 
            this.transaksiDataGridViewTextBoxColumn.DataPropertyName = "Transaksi";
            this.transaksiDataGridViewTextBoxColumn.HeaderText = "Transaksi";
            this.transaksiDataGridViewTextBoxColumn.Name = "transaksiDataGridViewTextBoxColumn";
            this.transaksiDataGridViewTextBoxColumn.ReadOnly = true;
            this.transaksiDataGridViewTextBoxColumn.Visible = false;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "";
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Edit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Edit.Text = "Ubah";
            this.Edit.UseColumnTextForButtonValue = true;
            // 
            // Hapus
            // 
            this.Hapus.DataPropertyName = "ID";
            this.Hapus.HeaderText = "";
            this.Hapus.Name = "Hapus";
            this.Hapus.ReadOnly = true;
            this.Hapus.Text = "Hapus";
            this.Hapus.UseColumnTextForButtonValue = true;
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataSource = typeof(D1_MIFTA_SETYA_PRATAMA.Komputer);
            // 
            // komputerBindingSource
            // 
            this.komputerBindingSource.DataSource = typeof(D1_MIFTA_SETYA_PRATAMA.Komputer);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.komputerBindingSource, "Nomor", true));
            this.numericUpDown1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(33, 416);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(288, 33);
            this.numericUpDown1.TabIndex = 32;
            // 
            // jenisCombo
            // 
            this.jenisCombo.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.komputerBindingSource, "IDJenis", true));
            this.jenisCombo.DataSource = this.jenisBindingSource;
            this.jenisCombo.DisplayMember = "Jenis1";
            this.jenisCombo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jenisCombo.FormattingEnabled = true;
            this.jenisCombo.Location = new System.Drawing.Point(400, 416);
            this.jenisCombo.Name = "jenisCombo";
            this.jenisCombo.Size = new System.Drawing.Size(274, 33);
            this.jenisCombo.TabIndex = 31;
            this.jenisCombo.ValueMember = "ID";
            // 
            // jenisBindingSource
            // 
            this.jenisBindingSource.DataSource = typeof(D1_MIFTA_SETYA_PRATAMA.Jenis);
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
            this.batalBtn.TabIndex = 30;
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
            this.simpanBtn.TabIndex = 29;
            this.simpanBtn.Text = "Simpan";
            this.simpanBtn.UseVisualStyleBackColor = false;
            this.simpanBtn.Click += new System.EventHandler(this.simpanBtn_Click);
            // 
            // merkTB
            // 
            this.merkTB.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.merkTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.merkTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.komputerBindingSource, "Merek", true));
            this.merkTB.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.merkTB.Location = new System.Drawing.Point(32, 502);
            this.merkTB.Name = "merkTB";
            this.merkTB.Size = new System.Drawing.Size(287, 32);
            this.merkTB.TabIndex = 28;
            // 
            // Harga
            // 
            this.Harga.AutoSize = true;
            this.Harga.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Harga.Location = new System.Drawing.Point(29, 473);
            this.Harga.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Harga.Name = "Harga";
            this.Harga.Size = new System.Drawing.Size(41, 19);
            this.Harga.TabIndex = 27;
            this.Harga.Text = "Merk";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(396, 388);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 19);
            this.label2.TabIndex = 26;
            this.label2.Text = "Jenis";
            // 
            // Nomor
            // 
            this.Nomor.AutoSize = true;
            this.Nomor.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nomor.Location = new System.Drawing.Point(29, 388);
            this.Nomor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Nomor.Name = "Nomor";
            this.Nomor.Size = new System.Drawing.Size(53, 19);
            this.Nomor.TabIndex = 25;
            this.Nomor.Text = "Nomor";
            // 
            // tambahBtn
            // 
            this.tambahBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(82)))), ((int)(((byte)(173)))));
            this.tambahBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tambahBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.tambahBtn.Location = new System.Drawing.Point(555, 323);
            this.tambahBtn.Margin = new System.Windows.Forms.Padding(4);
            this.tambahBtn.Name = "tambahBtn";
            this.tambahBtn.Size = new System.Drawing.Size(119, 44);
            this.tambahBtn.TabIndex = 22;
            this.tambahBtn.Text = "Tambah";
            this.tambahBtn.UseVisualStyleBackColor = false;
            this.tambahBtn.Click += new System.EventHandler(this.tambahBtn_Click);
            // 
            // MasterKomputer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.jenisCombo);
            this.Controls.Add(this.batalBtn);
            this.Controls.Add(this.simpanBtn);
            this.Controls.Add(this.merkTB);
            this.Controls.Add(this.Harga);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nomor);
            this.Controls.Add(this.tambahBtn);
            this.Controls.Add(this.komputerDataGridView);
            this.Controls.Add(this.welcome);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MasterKomputer";
            this.Size = new System.Drawing.Size(707, 561);
            this.Load += new System.EventHandler(this.MasterKomputer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.komputerDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.komputerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jenisBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcome;
        private System.Windows.Forms.DataGridView komputerDataGridView;
        private System.Windows.Forms.BindingSource komputerBindingSource;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ComboBox jenisCombo;
        private System.Windows.Forms.Button batalBtn;
        private System.Windows.Forms.Button simpanBtn;
        private System.Windows.Forms.TextBox merkTB;
        private System.Windows.Forms.Label Harga;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Nomor;
        private System.Windows.Forms.Button tambahBtn;
        private System.Windows.Forms.BindingSource jenisBindingSource;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn merekDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDJenisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jenis;
        private System.Windows.Forms.DataGridViewTextBoxColumn transaksiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Hapus;
    }
}
