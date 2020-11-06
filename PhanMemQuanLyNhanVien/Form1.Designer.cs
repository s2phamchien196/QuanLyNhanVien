namespace PhanMemQuanLyNhanVien
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.QuanLyNV = new DevComponents.DotNetBar.ExplorerBar();
            this.explorerBarGroupItem1 = new DevComponents.DotNetBar.ExplorerBarGroupItem();
            this.QuanLyNhanVien = new DevComponents.DotNetBar.ButtonItem();
            this.QUanLyBangLuong = new DevComponents.DotNetBar.ButtonItem();
            this.QuanLyPhongBan = new DevComponents.DotNetBar.ButtonItem();
            this.QuanLyChamCong = new DevComponents.DotNetBar.ButtonItem();
            this.explorerBarGroupItem2 = new DevComponents.DotNetBar.ExplorerBarGroupItem();
            this.BaoCaoLuong = new DevComponents.DotNetBar.ButtonItem();
            this.tabFormControl1 = new DevComponents.DotNetBar.Controls.TabFormControl();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLyNV)).BeginInit();
            this.SuspendLayout();
            // 
            // QuanLyNV
            // 
            this.QuanLyNV.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar;
            this.QuanLyNV.BackColor = System.Drawing.SystemColors.Control;
            // 
            // 
            // 
            this.QuanLyNV.BackStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(200)))), ((int)(((byte)(212)))));
            this.QuanLyNV.BackStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(179)))), ((int)(((byte)(200)))));
            this.QuanLyNV.BackStyle.BackColorGradientAngle = 90;
            this.QuanLyNV.BackStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.QuanLyNV.Dock = System.Windows.Forms.DockStyle.Left;
            this.QuanLyNV.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuanLyNV.GroupImages = null;
            this.QuanLyNV.Groups.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.explorerBarGroupItem1,
            this.explorerBarGroupItem2});
            this.QuanLyNV.Images = null;
            this.QuanLyNV.Location = new System.Drawing.Point(0, 0);
            this.QuanLyNV.Name = "QuanLyNV";
            this.QuanLyNV.Size = new System.Drawing.Size(218, 464);
            this.QuanLyNV.StockStyle = DevComponents.DotNetBar.eExplorerBarStockStyle.SilverSpecial;
            this.QuanLyNV.TabIndex = 0;
            this.QuanLyNV.Text = "explorerBar1";
            this.QuanLyNV.Click += new System.EventHandler(this.explorerBar1_Click);
            // 
            // explorerBarGroupItem1
            // 
            // 
            // 
            // 
            this.explorerBarGroupItem1.BackStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(223)))), ((int)(((byte)(247)))));
            this.explorerBarGroupItem1.BackStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.explorerBarGroupItem1.BackStyle.BorderBottomWidth = 1;
            this.explorerBarGroupItem1.BackStyle.BorderColor = System.Drawing.Color.White;
            this.explorerBarGroupItem1.BackStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.explorerBarGroupItem1.BackStyle.BorderLeftWidth = 1;
            this.explorerBarGroupItem1.BackStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.explorerBarGroupItem1.BackStyle.BorderRightWidth = 1;
            this.explorerBarGroupItem1.BackStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.explorerBarGroupItem1.Cursor = System.Windows.Forms.Cursors.Default;
            this.explorerBarGroupItem1.ExpandBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(182)))), ((int)(((byte)(216)))));
            this.explorerBarGroupItem1.Expanded = true;
            this.explorerBarGroupItem1.ExpandForeColor = System.Drawing.Color.Green;
            this.explorerBarGroupItem1.ExpandHotBorderColor = System.Drawing.Color.Green;
            this.explorerBarGroupItem1.ExpandHotForeColor = System.Drawing.Color.Green;
            this.explorerBarGroupItem1.Name = "explorerBarGroupItem1";
            this.explorerBarGroupItem1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.QuanLyNhanVien,
            this.QUanLyBangLuong,
            this.QuanLyPhongBan,
            this.QuanLyChamCong});
            this.explorerBarGroupItem1.Text = "Quản Lý Thông Tin";
            // 
            // 
            // 
            this.explorerBarGroupItem1.TitleHotStyle.BackColor = System.Drawing.Color.White;
            this.explorerBarGroupItem1.TitleHotStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(211)))), ((int)(((byte)(247)))));
            this.explorerBarGroupItem1.TitleHotStyle.CornerDiameter = 3;
            this.explorerBarGroupItem1.TitleHotStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.explorerBarGroupItem1.TitleHotStyle.CornerTypeTopLeft = DevComponents.DotNetBar.eCornerType.Rounded;
            this.explorerBarGroupItem1.TitleHotStyle.CornerTypeTopRight = DevComponents.DotNetBar.eCornerType.Rounded;
            this.explorerBarGroupItem1.TitleHotStyle.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.explorerBarGroupItem1.TitleStyle.BackColor = System.Drawing.Color.White;
            this.explorerBarGroupItem1.TitleStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(211)))), ((int)(((byte)(247)))));
            this.explorerBarGroupItem1.TitleStyle.CornerDiameter = 3;
            this.explorerBarGroupItem1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.explorerBarGroupItem1.TitleStyle.CornerTypeTopLeft = DevComponents.DotNetBar.eCornerType.Rounded;
            this.explorerBarGroupItem1.TitleStyle.CornerTypeTopRight = DevComponents.DotNetBar.eCornerType.Rounded;
            this.explorerBarGroupItem1.TitleStyle.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(93)))), ((int)(((byte)(198)))));
            // 
            // QuanLyNhanVien
            // 
            this.QuanLyNhanVien.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.QuanLyNhanVien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.QuanLyNhanVien.ForeColor = System.Drawing.Color.Brown;
            this.QuanLyNhanVien.HotFontUnderline = true;
            this.QuanLyNhanVien.HotForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            this.QuanLyNhanVien.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None;
            this.QuanLyNhanVien.Name = "QuanLyNhanVien";
            this.QuanLyNhanVien.Text = "Quản Lý Thông Tin Nhân Viên";
            this.QuanLyNhanVien.Click += new System.EventHandler(this.buttonItem1_Click);
            // 
            // QUanLyBangLuong
            // 
            this.QUanLyBangLuong.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.QUanLyBangLuong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.QUanLyBangLuong.ForeColor = System.Drawing.Color.Brown;
            this.QUanLyBangLuong.HotFontUnderline = true;
            this.QUanLyBangLuong.HotForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            this.QUanLyBangLuong.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None;
            this.QUanLyBangLuong.Name = "QUanLyBangLuong";
            this.QUanLyBangLuong.Text = "Quản Lý Thông Tin Bảng Lương";
            this.QUanLyBangLuong.Click += new System.EventHandler(this.QUanLyBangLuong_Click);
            // 
            // QuanLyPhongBan
            // 
            this.QuanLyPhongBan.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.QuanLyPhongBan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.QuanLyPhongBan.ForeColor = System.Drawing.Color.Brown;
            this.QuanLyPhongBan.HotFontUnderline = true;
            this.QuanLyPhongBan.HotForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            this.QuanLyPhongBan.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None;
            this.QuanLyPhongBan.Name = "QuanLyPhongBan";
            this.QuanLyPhongBan.Text = "Quản Lý Thông Tin Phòng Ban";
            this.QuanLyPhongBan.Click += new System.EventHandler(this.QuanLyPhongBan_Click);
            // 
            // QuanLyChamCong
            // 
            this.QuanLyChamCong.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.QuanLyChamCong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.QuanLyChamCong.ForeColor = System.Drawing.Color.Brown;
            this.QuanLyChamCong.HotFontUnderline = true;
            this.QuanLyChamCong.HotForeColor = System.Drawing.SystemColors.ControlDark;
            this.QuanLyChamCong.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None;
            this.QuanLyChamCong.Name = "QuanLyChamCong";
            this.QuanLyChamCong.Text = "Quản Lý Thông Tin Chấm Công";
            this.QuanLyChamCong.Click += new System.EventHandler(this.QuanLyChamCong_Click);
            // 
            // explorerBarGroupItem2
            // 
            // 
            // 
            // 
            this.explorerBarGroupItem2.BackStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(223)))), ((int)(((byte)(247)))));
            this.explorerBarGroupItem2.BackStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.explorerBarGroupItem2.BackStyle.BorderBottomWidth = 1;
            this.explorerBarGroupItem2.BackStyle.BorderColor = System.Drawing.Color.White;
            this.explorerBarGroupItem2.BackStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.explorerBarGroupItem2.BackStyle.BorderLeftWidth = 1;
            this.explorerBarGroupItem2.BackStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.explorerBarGroupItem2.BackStyle.BorderRightWidth = 1;
            this.explorerBarGroupItem2.BackStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.explorerBarGroupItem2.Cursor = System.Windows.Forms.Cursors.Default;
            this.explorerBarGroupItem2.ExpandBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(182)))), ((int)(((byte)(216)))));
            this.explorerBarGroupItem2.Expanded = true;
            this.explorerBarGroupItem2.ExpandForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(165)))));
            this.explorerBarGroupItem2.ExpandHotBackColor = System.Drawing.Color.PeachPuff;
            this.explorerBarGroupItem2.ExpandHotBorderColor = System.Drawing.Color.AntiqueWhite;
            this.explorerBarGroupItem2.ExpandHotForeColor = System.Drawing.Color.Beige;
            this.explorerBarGroupItem2.Name = "explorerBarGroupItem2";
            this.explorerBarGroupItem2.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.BaoCaoLuong});
            this.explorerBarGroupItem2.Text = "Báo Cáo-Thống kê";
            // 
            // 
            // 
            this.explorerBarGroupItem2.TitleHotStyle.BackColor = System.Drawing.Color.White;
            this.explorerBarGroupItem2.TitleHotStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(211)))), ((int)(((byte)(247)))));
            this.explorerBarGroupItem2.TitleHotStyle.CornerDiameter = 3;
            this.explorerBarGroupItem2.TitleHotStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.explorerBarGroupItem2.TitleHotStyle.CornerTypeTopLeft = DevComponents.DotNetBar.eCornerType.Rounded;
            this.explorerBarGroupItem2.TitleHotStyle.CornerTypeTopRight = DevComponents.DotNetBar.eCornerType.Rounded;
            this.explorerBarGroupItem2.TitleHotStyle.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.explorerBarGroupItem2.TitleStyle.BackColor = System.Drawing.Color.White;
            this.explorerBarGroupItem2.TitleStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(211)))), ((int)(((byte)(247)))));
            this.explorerBarGroupItem2.TitleStyle.CornerDiameter = 3;
            this.explorerBarGroupItem2.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.explorerBarGroupItem2.TitleStyle.CornerTypeTopLeft = DevComponents.DotNetBar.eCornerType.Rounded;
            this.explorerBarGroupItem2.TitleStyle.CornerTypeTopRight = DevComponents.DotNetBar.eCornerType.Rounded;
            this.explorerBarGroupItem2.TitleStyle.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(93)))), ((int)(((byte)(198)))));
            // 
            // BaoCaoLuong
            // 
            this.BaoCaoLuong.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.BaoCaoLuong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BaoCaoLuong.ForeColor = System.Drawing.Color.Brown;
            this.BaoCaoLuong.HotFontUnderline = true;
            this.BaoCaoLuong.HotForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            this.BaoCaoLuong.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None;
            this.BaoCaoLuong.Name = "BaoCaoLuong";
            this.BaoCaoLuong.Text = "Báo Cáo Bảng Lương";
            this.BaoCaoLuong.Click += new System.EventHandler(this.BaoCaoLuong_Click);
            // 
            // tabFormControl1
            // 
            this.tabFormControl1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabFormControl1.BackgroundImage")));
            this.tabFormControl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            // 
            // 
            // 
            this.tabFormControl1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tabFormControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabFormControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabFormControl1.Location = new System.Drawing.Point(218, 0);
            this.tabFormControl1.Name = "tabFormControl1";
            this.tabFormControl1.Size = new System.Drawing.Size(698, 464);
            this.tabFormControl1.TabIndex = 1;
            this.tabFormControl1.TabStripFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabFormControl1.Text = "tabFormControl1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(916, 464);
            this.Controls.Add(this.tabFormControl1);
            this.Controls.Add(this.QuanLyNV);
            this.Name = "Form1";
            this.Text = "Quản Lý Nhân Viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.QuanLyNV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ExplorerBar QuanLyNV;
        private DevComponents.DotNetBar.ExplorerBarGroupItem explorerBarGroupItem1;
        private DevComponents.DotNetBar.ButtonItem QuanLyNhanVien;
        private DevComponents.DotNetBar.ButtonItem QUanLyBangLuong;
        private DevComponents.DotNetBar.ButtonItem QuanLyPhongBan;
        private DevComponents.DotNetBar.ExplorerBarGroupItem explorerBarGroupItem2;
        private DevComponents.DotNetBar.ButtonItem BaoCaoLuong;
        private DevComponents.DotNetBar.ButtonItem QuanLyChamCong;
        public DevComponents.DotNetBar.Controls.TabFormControl tabFormControl1;

    }
}

