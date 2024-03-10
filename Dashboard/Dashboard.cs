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
    public partial class Dashboard : Form
    {
        EsemNetEntities db = new EsemNetEntities();
        public DateTime dateTime;

        public Dashboard()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            var user = db.Pengguna.Find(Login.Id);


            MainDashboard dashboard = new MainDashboard();
            Helper.OpenContent(panelContent, dashboard);
        }

        private void welcome_Click(object sender, EventArgs e)
        {

        }

        private void masterPaketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MasterPaket us = new MasterPaket();
            Helper.OpenContent(panelContent, us);
        }

        private void masterKomputerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MasterKomputer us = new MasterKomputer();
            Helper.OpenContent(panelContent, us);
        }

        private void Dashboard_click(object sender, EventArgs e)
        {
            MainDashboard us = new MainDashboard();
            Helper.OpenContent(panelContent, us);
        }

        private void masterKodePotonganHargaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Helper.OpenContent(panelContent, new MasterKode());
        }

        private void masterMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Helper.OpenContent(panelContent, new MasterMember());
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Helper.OpenContent(panelContent, new TransaksiUC());
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Close();
        }
    }
}
