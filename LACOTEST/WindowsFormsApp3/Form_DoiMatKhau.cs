using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form_DoiMatKhau : Form
    {
        string matKhau,ma;
        bool check;
        public Form_DoiMatKhau(string matKhau, bool check, string ma)
        {
            InitializeComponent();
            this.matKhau = matKhau;
            this.check = check;
            this.ma = ma;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
                MD5 mh = MD5.Create();
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(txtCu.Text);
                byte[] hash = mh.ComputeHash(inputBytes);
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hash.Length; i++)
                {
                    sb.Append(hash[i].ToString("X2"));
                }
                if (!(String.Compare(sb.ToString(), matKhau, true) == 0))
                {
                    MessageBox.Show("Mật khẩu cũ không đúng!", "Thông báo");
                }
                else if (!txtMoi.Text.Equals(txtMoi2.Text))
                {
                    MessageBox.Show("Mật khẩu xác nhận không trùng khớp", "Thông báo");
                }
                else
                {
                    if (check)
                    {
                    BUS_KhachHang.Intance.doiMatKhau(ma, txtMoi.Text);
                    } 
                    else
                    {
                    BUS_NhanVien.Intance.doiMatKhau(ma, txtMoi.Text);
                    }
                    MessageBox.Show("Thay đổi mật khẩu thành công", "Thông báo");
                    this.Close();
                }
           
            
        }
    }
}
