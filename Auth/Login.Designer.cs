namespace D1_MIFTA_SETYA_PRATAMA
{
    partial class Login
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
            System.Windows.Forms.Label kataSandiLabel;
            System.Windows.Forms.Label namaPenggunaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.kataSandiTextBox = new System.Windows.Forms.TextBox();
            this.namaPenggunaTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.loginBtn = new System.Windows.Forms.Button();
            this.penggunaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            kataSandiLabel = new System.Windows.Forms.Label();
            namaPenggunaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.penggunaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // kataSandiLabel
            // 
            kataSandiLabel.AutoSize = true;
            kataSandiLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            kataSandiLabel.Location = new System.Drawing.Point(206, 282);
            kataSandiLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            kataSandiLabel.Name = "kataSandiLabel";
            kataSandiLabel.Size = new System.Drawing.Size(107, 28);
            kataSandiLabel.TabIndex = 1;
            kataSandiLabel.Text = "Kata Sandi";
            // 
            // namaPenggunaLabel
            // 
            namaPenggunaLabel.AutoSize = true;
            namaPenggunaLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            namaPenggunaLabel.Location = new System.Drawing.Point(206, 191);
            namaPenggunaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            namaPenggunaLabel.Name = "namaPenggunaLabel";
            namaPenggunaLabel.Size = new System.Drawing.Size(163, 28);
            namaPenggunaLabel.TabIndex = 3;
            namaPenggunaLabel.Text = "Nama Pengguna";
            // 
            // kataSandiTextBox
            // 
            this.kataSandiTextBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.kataSandiTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.kataSandiTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.kataSandiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.penggunaBindingSource, "KataSandi", true));
            this.kataSandiTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kataSandiTextBox.Location = new System.Drawing.Point(211, 325);
            this.kataSandiTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.kataSandiTextBox.Name = "kataSandiTextBox";
            this.kataSandiTextBox.Size = new System.Drawing.Size(249, 32);
            this.kataSandiTextBox.TabIndex = 2;
            this.kataSandiTextBox.UseSystemPasswordChar = true;
            // 
            // namaPenggunaTextBox
            // 
            this.namaPenggunaTextBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.namaPenggunaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.namaPenggunaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.penggunaBindingSource, "NamaPengguna", true));
            this.namaPenggunaTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namaPenggunaTextBox.Location = new System.Drawing.Point(211, 239);
            this.namaPenggunaTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.namaPenggunaTextBox.Name = "namaPenggunaTextBox";
            this.namaPenggunaTextBox.Size = new System.Drawing.Size(249, 32);
            this.namaPenggunaTextBox.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(504, 187);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(272, 233);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(409, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 40);
            this.label1.TabIndex = 7;
            this.label1.Text = "Esem Net";
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(2)))), ((int)(((byte)(116)))));
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.loginBtn.Location = new System.Drawing.Point(211, 379);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(249, 41);
            this.loginBtn.TabIndex = 8;
            this.loginBtn.Text = "Masuk";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // penggunaBindingSource
            // 
            this.penggunaBindingSource.DataSource = typeof(D1_MIFTA_SETYA_PRATAMA.Pengguna);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(kataSandiLabel);
            this.Controls.Add(this.kataSandiTextBox);
            this.Controls.Add(namaPenggunaLabel);
            this.Controls.Add(this.namaPenggunaTextBox);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.penggunaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource penggunaBindingSource;
        private System.Windows.Forms.TextBox kataSandiTextBox;
        private System.Windows.Forms.TextBox namaPenggunaTextBox;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button loginBtn;
    }
}

