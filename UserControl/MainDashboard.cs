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
    public partial class MainDashboard : UserControl
    {
        EsemNetEntities db = new EsemNetEntities();

        public MainDashboard()
        {
            InitializeComponent();
        }

        private void MainDashboard_Load(object sender, EventArgs e)
        {
            var user = db.Pengguna.Find(Login.Id);
            welcome.Text = $"Selamat Datang {user.NamaPengguna}";

            DateLabel.Text = DateTime.Now.ToString("dd MMMM yyyy");          
            
            foreach (var item in db.Transaksi.ToList())
            {
                KomputerUC us = new KomputerUC()
                {
                    Tag = item,
                };
                flowLayoutPanel1.Controls.Add(us);
            }

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateLabel.Text = DateTime.Now.ToString(" dd MMMM yyyy HH:mm");
        }
    }
}
