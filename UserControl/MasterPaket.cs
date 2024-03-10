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
    public partial class MasterPaket : UserControl
    {
        EsemNetEntities db = new EsemNetEntities();
        public static int itemId;

        public MasterPaket()
        {
            InitializeComponent();
        }

        void Enable()
        {
            numericUpDown1.ReadOnly = false;
            namaTB.ReadOnly = false;
            jenisCombo.Enabled = true;
        }

        void Disable()
        {
            numericUpDown1.ReadOnly = true;
            namaTB.ReadOnly = true;
            jenisCombo.Enabled = false;
        }

        private void MasterPaket_Load(object sender, EventArgs e)
        {
            Disable();

            jenisBindingSource.Clear();
            jenisBindingSource.DataSource = db.Jenis.ToList();

            tableBindingSource.Clear();
            tableBindingSource.DataSource = db.Paket.ToList();

            paketBindingSource.Clear();
            paketBindingSource.AddNew();
        }

        private void paketDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (paketDataGridView.Rows[e.RowIndex].DataBoundItem is Paket p)
            {
                var jenis = p.Jenis ?? db.Jenis.Find(p.IDJenis);

                if (e.ColumnIndex == Jenis.Index)
                {
                    if (jenis != null)
                    {
                        e.Value = jenis.Jenis1;
                    }
                    else
                    {
                        e.Value = "Anak Owner";
                    }
                }
            }
        }

        private void batalBtn_Click(object sender, EventArgs e)
        {
            OnLoad(EventArgs.Empty);
        }

        private void paketDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (paketDataGridView.Rows[e.RowIndex].DataBoundItem is Paket paket)
            {
                if (e.ColumnIndex == Ubah.Index)
                {
                    itemId = paket.ID;
                    paketBindingSource.Clear();
                    paketBindingSource.DataSource = db.Paket.AsNoTracking().First(p => p.ID == paket.ID);
                    Enable();
                }

                if (e.ColumnIndex == Hapus.Index)
                {
                    DialogResult result = MessageBox.Show("Apakah anda yakin akan menghapus data ini ?", "Konfirmasi Hapus", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        db.Paket.Remove(paket);
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

        private void simpanBtn_Click(object sender, EventArgs e)
        {
            if (paketBindingSource.Current is Paket paket)
            {
                paket.ID = itemId;
                db.Paket.AddOrUpdate(paket);
                db.SaveChanges();
                OnLoad(EventArgs.Empty);
            }
        }
    }
}
