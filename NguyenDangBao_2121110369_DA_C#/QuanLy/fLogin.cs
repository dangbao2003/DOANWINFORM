using QuanLy.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLy
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string tendn = txtTenDN.Text.Trim();
            string matkhau = MaHoa.ToShA1(txtMatKhau.Text.Trim());
            ThanhVienDAO tvDAO = new ThanhVienDAO();
            ThanhVien thanhVien = tvDAO.getRow(tendn, matkhau);
            if(thanhVien == null )
            {
                lblThongBao.Text = "Tài Khoản Hoặc Mật Khẩu Không Chính Xác!";
            }
            else
            {
                Form1.thanhvien = thanhVien;
                this.Close();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
               "Bạn có muốn thoát không",
               "Thông báo",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question
               );
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void buttonXemVideo_Click(object sender, EventArgs e)
        {
            MVNhac l = new MVNhac();
            this.Hide();
            l.ShowDialog();
            this.Show();
        }

        
    }
}
