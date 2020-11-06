using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PhanMemQuanLyNhanVien;
namespace PhanMemQuanLyNhanVien
{
    public partial class QuanLyThongTinNhanVien : UserControl
    {
        public QuanLyThongTinNhanVien()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        //
        void HienThiNhanVien()
        {
            LvHienThi.Items.Clear();
            ListViewGroup[] lvg = new ListViewGroup[10];
            for (int i = 0; i < PhongBan.getLoaiPhongBan("'or 1='1").Rows.Count; i++)
            { lvg[i] = new ListViewGroup(PhongBan.getLoaiPhongBan("'or 1='1").Rows[i][1].ToString()); LvHienThi.Groups.Add(lvg[i]); }
            if (QuanLyNV.getThongtinNv().Rows.Count > 0)
            {
                for (int i = 0; i < QuanLyNV.getThongtinNv().Rows.Count; i++)
                {
                    // MessageBox.Show(QuanLyNV.getThongtinNv().Rows[i][0].ToString());
                    ListViewItem lvi = new ListViewItem(QuanLyNV.getThongtinNv().Rows[i][0].ToString());
                    lvi.SubItems.Add(QuanLyNV.getThongtinNv().Rows[i][1].ToString());
                    lvi.SubItems.Add(QuanLyNV.getThongtinNv().Rows[i][2].ToString().Substring(0, 10));
                    lvi.SubItems.Add(QuanLyNV.getThongtinNv().Rows[i][3].ToString() == "0" ? "Nam" : "Nữ");
                    lvi.SubItems.Add(QuanLyNV.getThongtinNv().Rows[i][4].ToString());
                    lvi.SubItems.Add(QuanLyNV.getThongtinNv().Rows[i][5].ToString().Substring(0, 10));
                    lvi.SubItems.Add(QuanLyNV.getThongtinNv().Rows[i][6].ToString().Substring(0, 10));
                    lvi.SubItems.Add(QuanLyNV.getThongtinNv().Rows[i][7].ToString().Substring(0, 10));
                    lvi.SubItems.Add(QuanLyNV.getThongtinNv().Rows[i][8].ToString());
                    lvi.SubItems.Add(QuanLyNV.getThongtinNv().Rows[i][9].ToString());
                    if (QuanLyNV.getThongtinNv().Rows[i][3].ToString() == "0")
                    { lvi.ImageIndex = 0; }
                    else lvi.ImageIndex = 1;
                    lvi.Tag = QuanLyNV.getThongtinNv().Rows[i][0].ToString();
                    LvHienThi.Items.Add(lvi);
                    for (int j = 0; j < PhongBan.getLoaiPhongBan("'or 1='1").Rows.Count; j++)
                    {
                        if (QuanLyNV.getThongtinNv().Rows[i][8].ToString() == PhongBan.getLoaiPhongBan("'or 1='1").Rows[j][1].ToString())
                        {
                            lvi.Group = lvg[j];
                        }
                    }

                }

            }
        }

        //
        void HienThiNhanVien_timKiem(DataTable dt)
        {
            LvHienThi.Items.Clear();
            ListViewGroup[] lvg = new ListViewGroup[10];
            for (int i = 0; i < PhongBan.getLoaiPhongBan("'or 1='1").Rows.Count; i++)
            { lvg[i] = new ListViewGroup(PhongBan.getLoaiPhongBan("'or 1='1").Rows[i][1].ToString()); LvHienThi.Groups.Add(lvg[i]); }
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ListViewItem lvi = new ListViewItem(dt.Rows[i][0].ToString());
                    lvi.SubItems.Add(dt.Rows[i][1].ToString());
                    lvi.SubItems.Add(dt.Rows[i][2].ToString().Substring(0, 10));
                    lvi.SubItems.Add(dt.Rows[i][3].ToString() == "0" ? "Nam" : "Nữ");
                    lvi.SubItems.Add(dt.Rows[i][4].ToString());
                    lvi.SubItems.Add(dt.Rows[i][5].ToString().Substring(0, 10));
                    lvi.SubItems.Add(dt.Rows[i][6].ToString().Substring(0, 10));
                    lvi.SubItems.Add(dt.Rows[i][7].ToString().Substring(0, 10));
                    lvi.SubItems.Add(dt.Rows[i][8].ToString());
                    lvi.SubItems.Add(dt.Rows[i][9].ToString());
                    if (dt.Rows[i][3].ToString() == "0")
                    { lvi.ImageIndex = 0; }
                    else lvi.ImageIndex = 1;
                    lvi.Tag = dt.Rows[i][0].ToString();
                    LvHienThi.Items.Add(lvi);
                    for (int j = 0; j < PhongBan.getLoaiPhongBan("'or 1='1").Rows.Count; j++)
                    {
                        if (dt.Rows[i][8].ToString() == PhongBan.getLoaiPhongBan("'or 1='1").Rows[j][1].ToString())
                        {
                            lvi.Group = lvg[j];
                        }
                    }

                }

            }
        }
        //
        private void QuanLyThongTinNhanVien_Load(object sender, EventArgs e)
        {
            cBPhongBan.DataSource = PhongBan.getLoaiPhongBan("'or 1='1");
            cBPhongBan.ValueMember = "MaPhong";
            cBPhongBan.DisplayMember = "TenPhong";
            cBMucLuong.DataSource = BangLuong.getBangLuong();
            cBMucLuong.ValueMember = "MaBangLuong";
            cBMucLuong.DisplayMember = "MucLuong";
            HienThiNhanVien();

        }

        private void LvHienThi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LvHienThi.SelectedItems.Count == 0) return;
            ListViewItem lvi = LvHienThi.SelectedItems[0];
            string manv = lvi.Tag.ToString();
            DataTable dt = QuanLyNV.getNv_Ma(manv);
            txtMaNV.Text = dt.Rows[0][0].ToString();
            txtTenNv.Text = dt.Rows[0][1].ToString();
            dTPNgaySinh.Text = dt.Rows[0][2].ToString();
            if(dt.Rows[0][3].ToString() == "0") { rBNam.Checked = true;} else rBNu.Checked = true;
            txtTruongDH.Text = dt.Rows[0][4].ToString();
            dTPNgayTN.Text = dt.Rows[0][5].ToString();
            dTPNgayVaoCT.Text = dt.Rows[0][6].ToString();
            dTPNgayNghi.Text = dt.Rows[0][7].ToString();
            cBPhongBan.Text = dt.Rows[0][8].ToString();
            cBMucLuong.Text = dt.Rows[0][9].ToString();

        }

        private void BtnTaoMoi_Click(object sender, EventArgs e)
        {
            txtMaNV.Text = "";
            txtTenNv.Text = "";
            dTPNgaySinh.Text = "";
            rBNam.Checked = false;
            rBNu.Checked = false;
            txtTruongDH.Text = "";
            dTPNgayTN.Text = "";
            dTPNgayVaoCT.Text = "";
            dTPNgayNghi.Text = "";
            cBPhongBan.Text = "";
            cBMucLuong.Text = "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (QuanLyNV.getNv_Ma(txtMaNV.Text).Rows.Count == 0)
            {
                QuanLyNV.ThemNV(txtMaNV.Text, txtTenNv.Text, dTPNgaySinh.Value, rBNam.Checked == true ? 0 : 1, txtTruongDH.Text, dTPNgayTN.Value, dTPNgayVaoCT.Value, dTPNgayNghi.Value, cBPhongBan.SelectedValue.ToString(), cBMucLuong.SelectedValue.ToString());
                MessageBox.Show("Thêm Nhân Viên Thành Công");
                HienThiNhanVien();
            }
            else
            {
                try
            {
                QuanLyNV.SuaNV(txtMaNV.Text, txtTenNv.Text, dTPNgaySinh.Value, rBNam.Checked == true ? 0 : 1, txtTruongDH.Text, dTPNgayTN.Value, dTPNgayVaoCT.Value, dTPNgayNghi.Value, cBPhongBan.SelectedValue.ToString(), cBMucLuong.SelectedValue.ToString());
                MessageBox.Show("Update Nhân Viên Thành Công");
                HienThiNhanVien();
            }
                catch (Exception ex)
                { MessageBox.Show(ex.Message); }
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                txtTK_Ten.Enabled = false;
                txtTK_Ten.Text = "";
            }
            else  txtTK_Ten.Enabled = true;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox2.Checked)
            {
                txtTKTruong.Enabled = false;
                txtTKTruong.Text = "";
            }
            else txtTKTruong.Enabled = true;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox3.Checked)
            {
                txtTKPhongBan.Enabled = false;
                txtTKPhongBan.Text = "";
            }
            else txtTKPhongBan.Enabled = true;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            HienThiNhanVien_timKiem(QuanLyNV.TimKien_NV(txtTK_Ten.Text,txtTKTruong.Text,txtTKPhongBan.Text));
        }

        private void txtTK_Ten_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text != "")
            {
                QuanLyNV.Delete_NV(txtMaNV.Text);
                HienThiNhanVien();
            }
        }
    }
}
