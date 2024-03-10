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
    public partial class MasterKode : UserControl
    {
        EsemNetEntities db = new EsemNetEntities();
        public static int itemId;

        public MasterKode()
        {
            InitializeComponent();
        }

        void Enable()
        {
            numericUpDown1.ReadOnly = false;
            numericUpDown2.ReadOnly = false;
            namaTB.ReadOnly = false;
            kodeTB.ReadOnly = false;
            dateTimePicker1.Enabled = true;
        }

        void Disable()
        {
            numericUpDown1.ReadOnly = true;
            numericUpDown2.ReadOnly = true;
            namaTB.ReadOnly = true;
            kodeTB.ReadOnly = true;
            dateTimePicker1.Enabled = false;
        }

        private void MasterMember_Load(object sender, EventArgs e)
        {
            Disable();

            tableBindingSource.Clear();
            tableBindingSource.DataSource = db.KodePotonganHarga.ToList();

            kodePotonganHargaBindingSource.Clear();
            kodePotonganHargaBindingSource.AddNew();
        }

        private void simpanBtn_Click(object sender, EventArgs e)
        {
            if (kodePotonganHargaBindingSource.Current is KodePotonganHarga kode)
            {
                kode.ID = itemId;
                db.KodePotonganHarga.AddOrUpdate(kode);
                db.SaveChanges();
                OnLoad(EventArgs.Empty);
            }
        }

        private void batalBtn_Click(object sender, EventArgs e)
        {
            OnLoad(EventArgs.Empty);
        }

        private void komputerDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (kodeDataGridView.Rows[e.RowIndex].DataBoundItem is KodePotonganHarga kode)
            {
                if (e.ColumnIndex == Ubah.Index)
                {
                    itemId = kode.ID;
                    kodePotonganHargaBindingSource.Clear();
                    kodePotonganHargaBindingSource.DataSource = db.KodePotonganHarga.AsNoTracking().First(k => k.ID == kode.ID);
                    Enable();
                }

                if (e.ColumnIndex == Hapus.Index)
                {
                    DialogResult result = MessageBox.Show("Apakah anda yakin akan menghapus data ini ?", "Konfirmasi Hapus", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        db.KodePotonganHarga.Remove(kode);
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
