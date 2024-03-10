using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D1_MIFTA_SETYA_PRATAMA
{
    public partial class MasterMember : UserControl
    {
        EsemNetEntities db = new EsemNetEntities();
        public static int itemId;

        public MasterMember()
        {
            InitializeComponent();
        }

        void Enable()
        {
            teleponTB.ReadOnly = false;
            namaTB.ReadOnly = false;
            alamatTB.ReadOnly = false;
        }

        void Disable()
        {
            teleponTB.ReadOnly = true;
            namaTB.ReadOnly = true;
            alamatTB.ReadOnly = true;
        }

        private void MasterMember_Load(object sender, EventArgs e)
        {
            Disable();

            tableBindingSource.Clear();
            tableBindingSource.DataSource = db.Member.ToList();

            memberBindingSource.Clear();
            memberBindingSource.AddNew();
        }

        private void aktifkan_Click(object sender, EventArgs e)
        {
            if (memberDataGridView.SelectedRows[0].DataBoundItem is Member member)
            {
                member.MasihAktif = true;
                db.Member.AddOrUpdate(member);
                db.SaveChanges();
                OnLoad(EventArgs.Empty);
            }
        }

        private void nonaktifkan_Click(object sender, EventArgs e)
        {
            if ( memberDataGridView.SelectedRows[0].DataBoundItem is Member member ) 
            { 
                member.MasihAktif = false;
                db.Member.AddOrUpdate(member);
                db.SaveChanges();
                OnLoad(EventArgs.Empty);
            }
        }

        private void tambahBtn_Click(object sender, EventArgs e)
        {
            Enable();
        }

        private void ubahBtn_Click(object sender, EventArgs e)
        {
            if ( memberDataGridView.SelectedRows[0].DataBoundItem is Member member )
            {
                memberBindingSource.DataSource = db.Member.AsNoTracking().First(m => m.ID == member.ID);
                Enable();
            }
        }

        private void hapusBtn_Click(object sender, EventArgs e)
        {
            if ( memberDataGridView.SelectedRows[0].DataBoundItem is Member member )
            {
                DialogResult result = MessageBox.Show("Apakah anda yakin akan menghapus data ini ?", "Konfirmasi Hapus", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    db.Member.Remove(member);
                    db.SaveChanges();
                    OnLoad(EventArgs.Empty);
                }
            }
        }

        private void simpanBtn_Click(object sender, EventArgs e)
        {
            if (memberBindingSource.Current is Member member)
            {
                if (namaTB.Text == string.Empty || teleponTB.Text == string.Empty || alamatTB.Text == string.Empty) 
                {
                    MessageBox.Show("Harap Masukkan Data");
                } 
                else
                {
                    string pattern = @"^\d+$";

                    if (Regex.IsMatch(teleponTB.Text, pattern))
                    {
                        db.Member.AddOrUpdate(member);
                        db.SaveChanges();
                        OnLoad(EventArgs.Empty);
                    }
                    else
                    {
                        MessageBox.Show("Nomor Telepon Harus Berupa Angka");
                    }
                }
            }
        }

        private void batalBtn_Click(object sender, EventArgs e)
        {
            OnLoad(EventArgs.Empty);
        }

    }
}
