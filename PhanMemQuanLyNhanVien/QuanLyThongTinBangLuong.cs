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
    public partial class QuanLyThongTinBangLuong : UserControl
    {
        public QuanLyThongTinBangLuong()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (txtMucLuong.Text != "")
            {
                try
                {
                    string MucLuong = String.Format("{0:G}", Double.Parse(txtMucLuong.Text));
                    txtMucLuong.Text = string.Format("{0:n0}", int.Parse(MucLuong));

                    txtMucLuong.SelectionStart = txtMucLuong.Text.Length;
                    txtMucLuong.SelectionLength = 0;
                }
                catch (Exception ex) { MessageBox.Show("Vượt qua số tiền cho phép"); txtMucLuong.Text = ""; }
            }
        }

        private void txtTk_tu_TextChanged(object sender, EventArgs e)
        {
            if (txtTk_tu.Text != "")
            {
                try
                {
                    string MucLuong = String.Format("{0:G}", Double.Parse(txtTk_tu.Text));
                    txtTk_tu.Text = string.Format("{0:n0}", int.Parse(MucLuong));

                    txtTk_tu.SelectionStart = txtTk_tu.Text.Length;
                    txtTk_tu.SelectionLength = 0;
                }
                catch (Exception ex) { MessageBox.Show("Vượt qua số tiền cho phép"); txtTk_tu.Text = "0"; }
            }
        }

        private void txtTK_Den_TextChanged(object sender, EventArgs e)
        {
            if (txtTK_Den.Text != "")
            {
                try
                {
                    string MucLuong = String.Format("{0:G}", Double.Parse(txtTK_Den.Text));
                    txtTK_Den.Text = string.Format("{0:n0}", int.Parse(MucLuong));

                    txtTK_Den.SelectionStart = txtTK_Den.Text.Length;
                    txtTK_Den.SelectionLength = 0;
                }
                catch (Exception ex) { MessageBox.Show("Vượt qua số tiền cho phép"); txtTK_Den.Text = "0"; }
            }
        }
        void hienthi(DataTable dt)
        {
            LvHienThi.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi = new ListViewItem(i + 1 + "");
                lvi.SubItems.Add(dt.Rows[i][0] + "");
                lvi.SubItems.Add(dt.Rows[i][1] + "");
                lvi.Tag = dt.Rows[i][0].ToString();
                LvHienThi.Items.Add(lvi);
            }
        }
        private void QuanLyThongTinBangLuong_Load(object sender, EventArgs e)
        {
            hienthi(QuanLyLuong.getThongTinLuong());
        }

        private void LvHienThi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LvHienThi.SelectedItems.Count == 0) return;
            DataTable dt = QuanLyLuong.getThongTinLuong_MaLuong(LvHienThi.SelectedItems[0].Tag + "");
            txtMaLuong.Text = dt.Rows[0][0] + "";
            txtMucLuong.Text = dt.Rows[0][1] + "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtMaLuong.Text = "";
            txtMucLuong.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (QuanLyLuong.getThongTinLuong_MaLuong(txtMaLuong.Text).Rows.Count > 0)
            {
                //MessageBox.Show(txtMucLuong.Text.Replace(",",""));
                QuanLyLuong.SuaML(txtMaLuong.Text, int.Parse(txtMucLuong.Text.Replace(",", "")));
            }
            else { QuanLyLuong.ThemML(txtMaLuong.Text, int.Parse(txtMucLuong.Text.Replace(",", ""))); }
            hienthi(QuanLyLuong.getThongTinLuong());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtMaLuong.Text != "")
            {
                try
                {
                    QuanLyLuong.Delete_ML(txtMaLuong.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể xóa dữ liệu này !");
                }
                hienthi(QuanLyLuong.getThongTinLuong());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
                {
                    hienthi(QuanLyLuong.TimKiem(int.Parse(txtTk_tu.Text.Replace(",", "")), int.Parse(txtTK_Den.Text.Replace(",", ""))));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
    }
}
