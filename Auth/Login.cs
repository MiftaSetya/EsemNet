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
    public partial class Login : Form
    {
        EsemNetEntities db = new EsemNetEntities();
        public static int Id;

        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            namaPenggunaTextBox.Text = "Budi";
            kataSandiTextBox.Text = "Sandi123";
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            var username = namaPenggunaTextBox.Text;
            var password = kataSandiTextBox.Text;

            var user = db.Pengguna.Where(u => u.NamaPengguna == username && u.KataSandi == password).FirstOrDefault();
            if (user != null)
            {
                Id = user.ID;
                new Dashboard().Show();
                this.Hide();
            }
        }
    }
}
