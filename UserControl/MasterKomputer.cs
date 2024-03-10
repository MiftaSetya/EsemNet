using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D1_MIFTA_SETYA_PRATAMA
{
    public partial class MasterKomputer : UserControl
    {
        EsemNetEntities db = new EsemNetEntities();
        private static int itemId;

        public MasterKomputer()
        {
            InitializeComponent();
        }

        void Enable()
        {
            numericUpDown1.ReadOnly = false;
            merkTB.ReadOnly = false;
            jenisCombo.Enabled = true;
        }

        void Disable()
        {
            numericUpDown1.ReadOnly = true;
            merkTB.ReadOnly = true;
            jenisCombo.Enabled = false;
        }

        private void MasterKomputer_Load(object sender, EventArgs e)
        {
            Disable();

            jenisBindingSource.Clear();
            jenisBindingSource.DataSource = db.Jenis.ToList();

            tableBindingSource.Clear();
            tableBindingSource.DataSource = db.Komputer.ToList();

            komputerBindingSource.Clear();
            komputerBindingSource.AddNew();
        }

        private void paketDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (komputerDataGridView.Rows[e.RowIndex].DataBoundItem is Komputer komputer)
            {
                var jenis = komputer.Jenis ?? db.Jenis.Find(komputer.IDJenis);

                if (e.ColumnIndex == Jenis.Index)
                {
                    e.Value = jenis.Jenis1;
                }
            }
        }

        private void batalBtn_Click(object sender, EventArgs e)
        {
            OnLoad(EventArgs.Empty);
        }

        private void simpanBtn_Click(object sender, EventArgs e)
        {
            if (komputerBindingSource.Current is Komputer komputer)
            {
                if (jenisCombo.SelectedIndex == -1)
                {
                    MessageBox.Show("Harus Memilih Jenis");
                }
                else
                {
                    komputer.ID = itemId;
                    db.Komputer.AddOrUpdate(komputer);
                    db.SaveChanges();
                    OnLoad(EventArgs.Empty);
                }
            }
            else
            {
                MessageBox.Show("Failed to insert");
            }
        }

        private void komputerDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (komputerDataGridView.Rows[e.RowIndex].DataBoundItem is Komputer komputer)
            {
                if (e.ColumnIndex == Edit.Index)
                {
                    itemId = komputer.ID;
                    komputerBindingSource.Clear();
                    komputerBindingSource.DataSource = db.Komputer.AsNoTracking().First(k => k.ID == komputer.ID);
                    Enable();
                }

                if (e.ColumnIndex == Hapus.Index)
                {
                    DialogResult result = MessageBox.Show("Apakah anda yakin akan menghapus data ini ?", "Konfirmasi Hapus", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        db.Komputer.Remove(komputer);
                        db.SaveChanges();
                        OnLoad(EventArgs.Empty);
                    }
                }  
            }
        }

        private void tambahBtn_Click(object sender, EventArgs e)
        {
            Enable();
        }
    }
}
