namespace WindowsFormsApp3
{
    partial class UC_ThongKe
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
			this.panelControls1 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.chartThongKeHD = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.panel2 = new System.Windows.Forms.Panel();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.btnTKPhieuNhap = new System.Windows.Forms.Button();
			this.btnTKHangHoa = new System.Windows.Forms.Button();
			this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
			this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panelControls1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chartThongKeHD)).BeginInit();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelControls1
			// 
			this.panelControls1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.panelControls1.Controls.Add(this.label2);
			this.panelControls1.Controls.Add(this.label1);
			this.panelControls1.Controls.Add(this.comboBox1);
			this.panelControls1.Controls.Add(this.chartThongKeHD);
			this.panelControls1.Location = new System.Drawing.Point(10, 88);
			this.panelControls1.Name = "panelControls1";
			this.panelControls1.Size = new System.Drawing.Size(974, 596);
			this.panelControls1.TabIndex = 18;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
			this.label2.Location = new System.Drawing.Point(290, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(474, 46);
			this.label2.TabIndex = 6;
			this.label2.Text = "THỐNG KÊ LỢI NHUẬN";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(87, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(63, 23);
			this.label1.TabIndex = 5;
			this.label1.Text = "Năm:";
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "2021",
            "2020"});
			this.comboBox1.Location = new System.Drawing.Point(162, 38);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(98, 31);
			this.comboBox1.TabIndex = 4;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// chartThongKeHD
			// 
			chartArea1.Name = "ChartArea1";
			this.chartThongKeHD.ChartAreas.Add(chartArea1);
			legend1.Name = "Legend1";
			this.chartThongKeHD.Legends.Add(legend1);
			this.chartThongKeHD.Location = new System.Drawing.Point(3, 76);
			this.chartThongKeHD.Name = "chartThongKeHD";
			series1.ChartArea = "ChartArea1";
			series1.Legend = "Legend1";
			series1.Name = "Doanh Thu";
			this.chartThongKeHD.Series.Add(series1);
			this.chartThongKeHD.Size = new System.Drawing.Size(968, 440);
			this.chartThongKeHD.TabIndex = 0;
			this.chartThongKeHD.Text = "chart1";
			title1.Name = "Thống Kê Theo Tuần";
			this.chartThongKeHD.Titles.Add(title1);
			// 
			// panel2
			// 
			this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.panel2.BackColor = System.Drawing.Color.Indigo;
			this.panel2.Controls.Add(this.button2);
			this.panel2.Controls.Add(this.button1);
			this.panel2.Controls.Add(this.btnTKPhieuNhap);
			this.panel2.Controls.Add(this.btnTKHangHoa);
			this.panel2.Location = new System.Drawing.Point(10, 10);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(974, 78);
			this.panel2.TabIndex = 17;
			// 
			// button2
			// 
			this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.ForeColor = System.Drawing.Color.White;
			this.button2.Location = new System.Drawing.Point(494, 0);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(171, 78);
			this.button2.TabIndex = 7;
			this.button2.Text = "Phiếu Nhập";
			this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Location = new System.Drawing.Point(336, -1);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(152, 78);
			this.button1.TabIndex = 6;
			this.button1.Text = "Hóa Đơn";
			this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// btnTKPhieuNhap
			// 
			this.btnTKPhieuNhap.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnTKPhieuNhap.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnTKPhieuNhap.FlatAppearance.BorderSize = 0;
			this.btnTKPhieuNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnTKPhieuNhap.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTKPhieuNhap.ForeColor = System.Drawing.Color.White;
			this.btnTKPhieuNhap.Location = new System.Drawing.Point(149, 0);
			this.btnTKPhieuNhap.Name = "btnTKPhieuNhap";
			this.btnTKPhieuNhap.Size = new System.Drawing.Size(181, 78);
			this.btnTKPhieuNhap.TabIndex = 1;
			this.btnTKPhieuNhap.Text = "Khách Hàng";
			this.btnTKPhieuNhap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnTKPhieuNhap.UseVisualStyleBackColor = true;
			this.btnTKPhieuNhap.Click += new System.EventHandler(this.btnTKPhieuNhap_Click);
			// 
			// btnTKHangHoa
			// 
			this.btnTKHangHoa.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnTKHangHoa.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnTKHangHoa.FlatAppearance.BorderSize = 0;
			this.btnTKHangHoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnTKHangHoa.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTKHangHoa.ForeColor = System.Drawing.Color.White;
			this.btnTKHangHoa.Location = new System.Drawing.Point(0, 0);
			this.btnTKHangHoa.Name = "btnTKHangHoa";
			this.btnTKHangHoa.Size = new System.Drawing.Size(149, 78);
			this.btnTKHangHoa.TabIndex = 0;
			this.btnTKHangHoa.Text = "Hàng Hóa";
			this.btnTKHangHoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnTKHangHoa.UseVisualStyleBackColor = true;
			this.btnTKHangHoa.Click += new System.EventHandler(this.btnTKHangHoa_Click);
			// 
			// flowLayoutPanel3
			// 
			this.flowLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.flowLayoutPanel3.BackColor = System.Drawing.Color.White;
			this.flowLayoutPanel3.Location = new System.Drawing.Point(984, 10);
			this.flowLayoutPanel3.Name = "flowLayoutPanel3";
			this.flowLayoutPanel3.Size = new System.Drawing.Size(10, 674);
			this.flowLayoutPanel3.TabIndex = 13;
			// 
			// flowLayoutPanel2
			// 
			this.flowLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.flowLayoutPanel2.BackColor = System.Drawing.Color.White;
			this.flowLayoutPanel2.Location = new System.Drawing.Point(10, 684);
			this.flowLayoutPanel2.Name = "flowLayoutPanel2";
			this.flowLayoutPanel2.Size = new System.Drawing.Size(984, 10);
			this.flowLayoutPanel2.TabIndex = 14;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
			this.flowLayoutPanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
			this.flowLayoutPanel1.Location = new System.Drawing.Point(10, 0);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(984, 10);
			this.flowLayoutPanel1.TabIndex = 15;
			// 
			// panel1
			// 
			this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(10, 694);
			this.panel1.TabIndex = 16;
			// 
			// UC_ThongKe
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.panelControls1);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.flowLayoutPanel3);
			this.Controls.Add(this.flowLayoutPanel2);
			this.Controls.Add(this.flowLayoutPanel1);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.Name = "UC_ThongKe";
			this.Size = new System.Drawing.Size(994, 694);
			this.Load += new System.EventHandler(this.UC_ThongKe_Load);
			this.panelControls1.ResumeLayout(false);
			this.panelControls1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.chartThongKeHD)).EndInit();
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelControls1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnTKPhieuNhap;
        private System.Windows.Forms.Button btnTKHangHoa;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartThongKeHD;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
