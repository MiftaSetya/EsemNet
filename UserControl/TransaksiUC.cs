using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D1_MIFTA_SETYA_PRATAMA
{
    public partial class TransaksiUC : UserControl
    {
        EsemNetEntities db = new EsemNetEntities();

        public TransaksiUC()
        {
            InitializeComponent();
        }

        private void FormTransaksi_Load(object sender, EventArgs e)
        {
            tableBindingSource.Clear();
            tableBindingSource.DataSource = db.Transaksi.ToList();
        }

        private void transaksiDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (transaksiDataGridView.Rows[e.RowIndex].DataBoundItem is Transaksi transaksi)
            {
                var komputer = transaksi.Komputer ?? db.Komputer.Find(transaksi.IDKomputer);
                var paket = transaksi.Paket ?? db.Paket.Find(transaksi.IDPaket);
                var operate = transaksi.Pengguna ?? db.Pengguna.Find(transaksi.DibuatOleh);

                if (e.ColumnIndex == Komputer.Index)
                {
                    e.Value = komputer.Merek;
                }

                if (e.ColumnIndex == Paket.Index)
                {
                    e.Value = paket.Nama;
                }

                if (e.ColumnIndex == Operator.Index)
                {
                    e.Value = operate.NamaPengguna;
                }
            }
        }
    }
}
