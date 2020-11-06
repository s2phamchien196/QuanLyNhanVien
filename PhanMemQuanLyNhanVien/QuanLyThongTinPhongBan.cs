using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PhanMemQuanLyNhanVien
{
    public partial class QuanLyThongTinPhongBan : UserControl
    {
        public QuanLyThongTinPhongBan()
        {
            InitializeComponent();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtMaPhong.Text = "";
            txtChucNang.Text = "";
            txtTenPhong.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (PhongBan.getLoaiPhongBan(txtMaPhong.Text).Rows.Count > 0)
            {
                PhongBan.SuaPb(txtMaPhong.Text, txtTenPhong.Text, txtChucNang.Text);
            }
            else { PhongBan.ThemPB(txtMaPhong.Text, txtTenPhong.Text, txtChucNang.Text); }
            hienthi(PhongBan.getLoaiPhongBan("'or 1='1"));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtMaPhong.Text != "")
            {
                PhongBan.Delete_Pb(txtMaPhong.Text);
                hienthi(PhongBan.getLoaiPhongBan("'or 1='1"));
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            hienthi(PhongBan.TimKien_Pb(txtTK_tenPhong.Text,txtTK_chucNang.Text));
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        void hienthi(DataTable dt)
        {
            LvHienThi.Items.Clear();
             for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi = new ListViewItem(i + 1+"");
                lvi.SubItems.Add(dt.Rows[i][0] +"");
                lvi.SubItems.Add(dt.Rows[i][1] + "");
                lvi.SubItems.Add(dt.Rows[i][2] + "");
                lvi.Tag = dt.Rows[i][0].ToString();
                LvHienThi.Items.Add(lvi);
            }
        }

        private void QuanLyThongTinPhongBan_Load(object sender, EventArgs e)
        {
            hienthi(PhongBan.getLoaiPhongBan("'or 1='1"));
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txtTK_tenPhong.Enabled = true;
            }
            else { txtTK_tenPhong.Text = ""; txtTK_tenPhong.Enabled = false; }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true )
            {
                txtTK_chucNang.Enabled = true;
            }
            else { txtTK_chucNang.Text = ""; txtTK_chucNang.Enabled = false; }
        }

        private void LvHienThi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LvHienThi.SelectedItems.Count == 0) return;
            DataTable dt = PhongBan.getLoaiPhongBan(LvHienThi.SelectedItems[0].Tag + "");
            txtMaPhong.Text = dt.Rows[0][0] + "";
            txtTenPhong.Text = dt.Rows[0][1] + "";
            txtChucNang.Text = dt.Rows[0][2] + "";
        }
    }
}
