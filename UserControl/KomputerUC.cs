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
    public partial class KomputerUC : UserControl
    {
        public DateTime clock;
        EsemNetEntities db =  new EsemNetEntities();

        public KomputerUC()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void KomputerUC_Load(object sender, EventArgs e)
        {
            if (this.Tag is Transaksi transaksi )
            {
                var trans = db.Transaksi.FirstOrDefault(f => f.ID == transaksi.ID);
                label1.Text = trans.Komputer.Merek;
            }
        }
    }
}
