using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3.data;
using WindowsFormsApp3.database;


namespace WindowsFormsApp3
{
    public partial class Form_Report : Form
    {
        private string maHD;
        private string Tien;
        private string MaKh;
        public Form_Report(string maHD, string Tien, string MaKh)
        {
            this.maHD = maHD;
            this.Tien = Tien;
            this.MaKh = MaKh;
            InitializeComponent();
        }

		private void Form_Report_Load(object sender, EventArgs e)
        {

            DataTable data =   DataProvider.Instance.ExecuteQuery("USP_GetHoaDon @MaHD ='"+maHD+"'");
         
            using (var QLKS = new QLKS())
            {
                String query = "USP_GetHoaDon @MaHD ='" + maHD + "'";
                List<ThongKe> danhsach = QLKS.Database.SqlQuery<ThongKe>(query).ToList();
                this.reportViewer3.LocalReport.ReportPath = "Report2.rdlc";
                var reportDataSource = new ReportDataSource("QuanLiHoaDon", danhsach);


                String query_1 = "select TenKH from KhachHang where MaKH = '"+ MaKh + "'";
                List<Thong_ke_1> danhsach1 = QLKS.Database.SqlQuery<Thong_ke_1>(query_1).ToList();
                this.reportViewer3.LocalReport.ReportPath = "Report2.rdlc";
                var reportDataSource1 = new ReportDataSource("QuanLiHoaDon1", danhsach1);

                this.reportViewer3.LocalReport.DataSources.Clear();

                this.reportViewer3.LocalReport.DataSources.Add(reportDataSource);
                this.reportViewer3.LocalReport.DataSources.Add(reportDataSource1);

                this.reportViewer3.RefreshReport();
            } 
		}

	}
}
