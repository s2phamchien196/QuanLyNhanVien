using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;

namespace PhanMemQuanLyNhanVien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void explorerBar1_Click(object sender, EventArgs e)
        {

        }
        //
        private bool checkTab(string tabName)
        {
            foreach (TabFormItem tab in tabFormControl1.Items)
            {
                if (tab.Text.Equals(tabName))
                {
                    tabFormControl1.SelectedTab = tab;
                    return true;
                }
            }
            return false;
        }
        //
        private void buttonItem1_Click(object sender, EventArgs e)
        {
            if (!checkTab("Quản Lý Thông Tin Nhân Viên"))
            {
                QuanLyThongTinNhanVien usercontrol = new QuanLyThongTinNhanVien();
                usercontrol.Dock = DockStyle.Fill;
                TabFormItem tab = tabFormControl1.CreateTab("Quản Lý Thông Tin Nhân Viên", "qlnv");
                tab.Panel.Controls.Add(usercontrol);
                tabFormControl1.SelectedTab = tab;
               
            }
        }

        private void QUanLyBangLuong_Click(object sender, EventArgs e)
        {
            if (!checkTab("Quản Lý Thông Tin Bảng Lương"))
            {
                QuanLyThongTinBangLuong usercontrol = new QuanLyThongTinBangLuong();
                usercontrol.Dock = DockStyle.Fill;
                TabFormItem tab = tabFormControl1.CreateTab("Quản Lý Thông Tin Bảng Lương", "qlbl");
                tab.Panel.Controls.Add(usercontrol);
                tabFormControl1.SelectedTab = tab;
            }
        }

        private void QuanLyPhongBan_Click(object sender, EventArgs e)
        {
            if (!checkTab("Quản Lý Thông Tin Phòng Ban"))
            {
                QuanLyThongTinPhongBan usercontrol = new QuanLyThongTinPhongBan();
                usercontrol.Dock = DockStyle.Fill;
                TabFormItem tab = tabFormControl1.CreateTab("Quản Lý Thông Tin Phòng Ban", "qlpb");
                tab.Panel.Controls.Add(usercontrol);
                tabFormControl1.SelectedTab = tab;
            }
        }

        private void QuanLyChamCong_Click(object sender, EventArgs e)
        {
            if (!checkTab("Quản Lý Thông Tin Chấm Công"))
            {
                QuanLyThongTinPhongBan usercontrol = new QuanLyThongTinPhongBan();
                usercontrol.Dock = DockStyle.Fill;
                TabFormItem tab = tabFormControl1.CreateTab("Quản Lý Thông Tin Chấm Công", "qlcc");
                tab.Panel.Controls.Add(usercontrol);
                tabFormControl1.SelectedTab = tab;
            }
        }

        private void BaoCaoLuong_Click(object sender, EventArgs e)
        {
            if (!checkTab("Báo cáo bảng lương"))
            {
                BaoCaoBangLuong usercontrol = new BaoCaoBangLuong();
                usercontrol.Dock = DockStyle.Fill;
                TabFormItem tab = tabFormControl1.CreateTab("Báo cáo bảng lương", "bcbl");
                tab.Panel.Controls.Add(usercontrol);
                tabFormControl1.SelectedTab = tab;
            }
        }

    }
}
