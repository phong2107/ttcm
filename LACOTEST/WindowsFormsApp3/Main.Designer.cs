﻿namespace WindowsFormsApp3
{
    partial class Main
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.timerTime = new System.Windows.Forms.Timer(this.components);
			this.panelLeft = new System.Windows.Forms.Panel();
			this.btnNhapHang = new System.Windows.Forms.Button();
			this.btnDangXuat = new System.Windows.Forms.Button();
			this.label17 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.panelSide = new System.Windows.Forms.Panel();
			this.pannelLeft1 = new System.Windows.Forms.Panel();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.btnKhoHang = new System.Windows.Forms.Button();
			this.btnNCC = new System.Windows.Forms.Button();
			this.btnThongKe = new System.Windows.Forms.Button();
			this.btnNhanVien = new System.Windows.Forms.Button();
			this.btnKhachHang = new System.Windows.Forms.Button();
			this.btnBanHang = new System.Windows.Forms.Button();
			this.btnTrangChu = new System.Windows.Forms.Button();
			this.panelControls = new System.Windows.Forms.Panel();
			this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lbUser = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panelLeft.SuspendLayout();
			this.pannelLeft1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// panelLeft
			// 
			this.panelLeft.BackColor = System.Drawing.Color.Indigo;
			this.panelLeft.Controls.Add(this.btnNhapHang);
			this.panelLeft.Controls.Add(this.btnDangXuat);
			this.panelLeft.Controls.Add(this.label17);
			this.panelLeft.Controls.Add(this.label16);
			this.panelLeft.Controls.Add(this.panelSide);
			this.panelLeft.Controls.Add(this.pannelLeft1);
			this.panelLeft.Controls.Add(this.btnKhoHang);
			this.panelLeft.Controls.Add(this.btnNCC);
			this.panelLeft.Controls.Add(this.btnThongKe);
			this.panelLeft.Controls.Add(this.btnNhanVien);
			this.panelLeft.Controls.Add(this.btnKhachHang);
			this.panelLeft.Controls.Add(this.btnBanHang);
			this.panelLeft.Controls.Add(this.btnTrangChu);
			this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
			this.panelLeft.Location = new System.Drawing.Point(0, 0);
			this.panelLeft.Name = "panelLeft";
			this.panelLeft.Size = new System.Drawing.Size(206, 760);
			this.panelLeft.TabIndex = 3;
			// 
			// btnNhapHang
			// 
			this.btnNhapHang.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnNhapHang.FlatAppearance.BorderSize = 0;
			this.btnNhapHang.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
			this.btnNhapHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNhapHang.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNhapHang.Image = ((System.Drawing.Image)(resources.GetObject("btnNhapHang.Image")));
			this.btnNhapHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnNhapHang.Location = new System.Drawing.Point(13, 464);
			this.btnNhapHang.Name = "btnNhapHang";
			this.btnNhapHang.Size = new System.Drawing.Size(194, 50);
			this.btnNhapHang.TabIndex = 6;
			this.btnNhapHang.Text = "   Nhập Hàng";
			this.btnNhapHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnNhapHang.UseVisualStyleBackColor = true;
			this.btnNhapHang.Click += new System.EventHandler(this.btnNhapHang_Click);
			// 
			// btnDangXuat
			// 
			this.btnDangXuat.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnDangXuat.FlatAppearance.BorderSize = 0;
			this.btnDangXuat.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
			this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDangXuat.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDangXuat.Image = ((System.Drawing.Image)(resources.GetObject("btnDangXuat.Image")));
			this.btnDangXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnDangXuat.Location = new System.Drawing.Point(9, 653);
			this.btnDangXuat.Name = "btnDangXuat";
			this.btnDangXuat.Size = new System.Drawing.Size(194, 50);
			this.btnDangXuat.TabIndex = 5;
			this.btnDangXuat.Text = "   Đăng Xuất";
			this.btnDangXuat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnDangXuat.UseVisualStyleBackColor = true;
			this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label17.Location = new System.Drawing.Point(42, 742);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(146, 18);
			this.label17.TabIndex = 4;
			this.label17.Text = "Hotline : 0123456789";
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label16.Location = new System.Drawing.Point(13, 714);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(229, 18);
			this.label16.TabIndex = 4;
			this.label16.Text = "Địa Chỉ : 45/3 đường 160, quận 9  ";
			// 
			// panelSide
			// 
			this.panelSide.BackColor = System.Drawing.Color.White;
			this.panelSide.Location = new System.Drawing.Point(-1, 68);
			this.panelSide.Name = "panelSide";
			this.panelSide.Size = new System.Drawing.Size(10, 54);
			this.panelSide.TabIndex = 2;
			// 
			// pannelLeft1
			// 
			this.pannelLeft1.BackColor = System.Drawing.Color.Indigo;
			this.pannelLeft1.Controls.Add(this.pictureBox4);
			this.pannelLeft1.Dock = System.Windows.Forms.DockStyle.Top;
			this.pannelLeft1.Location = new System.Drawing.Point(0, 0);
			this.pannelLeft1.Name = "pannelLeft1";
			this.pannelLeft1.Size = new System.Drawing.Size(206, 66);
			this.pannelLeft1.TabIndex = 0;
			// 
			// pictureBox4
			// 
			this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
			this.pictureBox4.Location = new System.Drawing.Point(30, 8);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(100, 50);
			this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox4.TabIndex = 2;
			this.pictureBox4.TabStop = false;
			// 
			// btnKhoHang
			// 
			this.btnKhoHang.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnKhoHang.FlatAppearance.BorderSize = 0;
			this.btnKhoHang.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
			this.btnKhoHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnKhoHang.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnKhoHang.Image = ((System.Drawing.Image)(resources.GetObject("btnKhoHang.Image")));
			this.btnKhoHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnKhoHang.Location = new System.Drawing.Point(14, 408);
			this.btnKhoHang.Name = "btnKhoHang";
			this.btnKhoHang.Size = new System.Drawing.Size(194, 50);
			this.btnKhoHang.TabIndex = 1;
			this.btnKhoHang.Text = "   Kho Hàng";
			this.btnKhoHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnKhoHang.UseVisualStyleBackColor = true;
			this.btnKhoHang.Click += new System.EventHandler(this.btnKhoHang_Click);
			// 
			// btnNCC
			// 
			this.btnNCC.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnNCC.FlatAppearance.BorderSize = 0;
			this.btnNCC.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
			this.btnNCC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNCC.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNCC.Image = ((System.Drawing.Image)(resources.GetObject("btnNCC.Image")));
			this.btnNCC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnNCC.Location = new System.Drawing.Point(12, 352);
			this.btnNCC.Name = "btnNCC";
			this.btnNCC.Size = new System.Drawing.Size(194, 50);
			this.btnNCC.TabIndex = 1;
			this.btnNCC.Text = "   Nhà C.Cấp";
			this.btnNCC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnNCC.UseVisualStyleBackColor = true;
			this.btnNCC.Click += new System.EventHandler(this.btnNCC_Click);
			// 
			// btnThongKe
			// 
			this.btnThongKe.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnThongKe.FlatAppearance.BorderSize = 0;
			this.btnThongKe.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
			this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnThongKe.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThongKe.Image = ((System.Drawing.Image)(resources.GetObject("btnThongKe.Image")));
			this.btnThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnThongKe.Location = new System.Drawing.Point(12, 296);
			this.btnThongKe.Name = "btnThongKe";
			this.btnThongKe.Size = new System.Drawing.Size(194, 50);
			this.btnThongKe.TabIndex = 1;
			this.btnThongKe.Text = "   Thống Kê";
			this.btnThongKe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnThongKe.UseVisualStyleBackColor = true;
			this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
			// 
			// btnNhanVien
			// 
			this.btnNhanVien.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnNhanVien.FlatAppearance.BorderSize = 0;
			this.btnNhanVien.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
			this.btnNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNhanVien.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNhanVien.Image = ((System.Drawing.Image)(resources.GetObject("btnNhanVien.Image")));
			this.btnNhanVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnNhanVien.Location = new System.Drawing.Point(12, 240);
			this.btnNhanVien.Name = "btnNhanVien";
			this.btnNhanVien.Size = new System.Drawing.Size(194, 50);
			this.btnNhanVien.TabIndex = 1;
			this.btnNhanVien.Text = "   Nhân Viên";
			this.btnNhanVien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnNhanVien.UseVisualStyleBackColor = true;
			this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click_1);
			// 
			// btnKhachHang
			// 
			this.btnKhachHang.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnKhachHang.FlatAppearance.BorderSize = 0;
			this.btnKhachHang.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
			this.btnKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnKhachHang.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnKhachHang.Image = ((System.Drawing.Image)(resources.GetObject("btnKhachHang.Image")));
			this.btnKhachHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnKhachHang.Location = new System.Drawing.Point(12, 184);
			this.btnKhachHang.Name = "btnKhachHang";
			this.btnKhachHang.Size = new System.Drawing.Size(194, 50);
			this.btnKhachHang.TabIndex = 1;
			this.btnKhachHang.Text = "   Khách Hàng";
			this.btnKhachHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnKhachHang.UseVisualStyleBackColor = true;
			this.btnKhachHang.Click += new System.EventHandler(this.btnKhachHang_Click);
			// 
			// btnBanHang
			// 
			this.btnBanHang.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnBanHang.FlatAppearance.BorderSize = 0;
			this.btnBanHang.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
			this.btnBanHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBanHang.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBanHang.Image = ((System.Drawing.Image)(resources.GetObject("btnBanHang.Image")));
			this.btnBanHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnBanHang.Location = new System.Drawing.Point(10, 128);
			this.btnBanHang.Name = "btnBanHang";
			this.btnBanHang.Size = new System.Drawing.Size(194, 50);
			this.btnBanHang.TabIndex = 1;
			this.btnBanHang.Text = "   Bán Hàng";
			this.btnBanHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnBanHang.UseVisualStyleBackColor = true;
			this.btnBanHang.Click += new System.EventHandler(this.btnBanHang_Click);
			// 
			// btnTrangChu
			// 
			this.btnTrangChu.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnTrangChu.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
			this.btnTrangChu.FlatAppearance.BorderSize = 0;
			this.btnTrangChu.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
			this.btnTrangChu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnTrangChu.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTrangChu.Image = ((System.Drawing.Image)(resources.GetObject("btnTrangChu.Image")));
			this.btnTrangChu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnTrangChu.Location = new System.Drawing.Point(10, 72);
			this.btnTrangChu.Name = "btnTrangChu";
			this.btnTrangChu.Size = new System.Drawing.Size(194, 50);
			this.btnTrangChu.TabIndex = 1;
			this.btnTrangChu.Text = "   Trang Chủ";
			this.btnTrangChu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnTrangChu.UseVisualStyleBackColor = true;
			this.btnTrangChu.Click += new System.EventHandler(this.btnTrangChu_Click);
			// 
			// panelControls
			// 
			this.panelControls.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelControls.Location = new System.Drawing.Point(206, 66);
			this.panelControls.Name = "panelControls";
			this.panelControls.Size = new System.Drawing.Size(994, 694);
			this.panelControls.TabIndex = 5;
			// 
			// guna2ControlBox1
			// 
			this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.guna2ControlBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
			this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
			this.guna2ControlBox1.HoverState.FillColor = System.Drawing.Color.Teal;
			this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
			this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
			this.guna2ControlBox1.Location = new System.Drawing.Point(949, 0);
			this.guna2ControlBox1.Name = "guna2ControlBox1";
			this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
			this.guna2ControlBox1.Size = new System.Drawing.Size(45, 66);
			this.guna2ControlBox1.TabIndex = 4;
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
			this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.panel1.Location = new System.Drawing.Point(898, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(45, 37);
			this.panel1.TabIndex = 5;
			this.panel1.Click += new System.EventHandler(this.panel1_Click);
			// 
			// lbUser
			// 
			this.lbUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lbUser.AutoSize = true;
			this.lbUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lbUser.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbUser.ForeColor = System.Drawing.Color.White;
			this.lbUser.Location = new System.Drawing.Point(793, 17);
			this.lbUser.Name = "lbUser";
			this.lbUser.Size = new System.Drawing.Size(102, 30);
			this.lbUser.TabIndex = 6;
			this.lbUser.Text = "ADMIN";
			this.lbUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.Indigo;
			this.panel3.Controls.Add(this.lbUser);
			this.panel3.Controls.Add(this.panel1);
			this.panel3.Controls.Add(this.guna2ControlBox1);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(206, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(994, 66);
			this.panel3.TabIndex = 4;
			// 
			// Main
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1200, 760);
			this.Controls.Add(this.panelControls);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panelLeft);
			this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.Color.White;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Main";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Main";
			this.panelLeft.ResumeLayout(false);
			this.panelLeft.PerformLayout();
			this.pannelLeft1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timerTime;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.Panel pannelLeft1;
        private System.Windows.Forms.Button btnNCC;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnNhanVien;
        private System.Windows.Forms.Button btnKhachHang;
        private System.Windows.Forms.Button btnBanHang;
        private System.Windows.Forms.Button btnTrangChu;
        private System.Windows.Forms.Button btnKhoHang;
        private System.Windows.Forms.Panel panelControls;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Button btnNhapHang;
        private System.Windows.Forms.PictureBox pictureBox4;
		private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lbUser;
		private System.Windows.Forms.Panel panel3;
	}
}