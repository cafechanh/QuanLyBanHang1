using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang.GUI
{
    public partial class frm_dangnhap : Form
    {
        Lopdungchung lopchung = new Lopdungchung();
        public frm_dangnhap()
        {
            InitializeComponent();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show(" Bạn có muốn thoát khỏi chương trình hay không", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        int dem = 0;
        private void btn_login_Click(object sender, EventArgs e)
        {
            string sql = "select count(*) from TAIKHOAN where TK = '" + txt_taikhoan.Text.ToUpper() + "'and MK = '" + txt_matkhau.Text.ToUpper() + "'";
            int kq = (int)lopchung.ExcuteScalar(sql);
            if (kq >= 1)
            {               
                Frm_Main main = new Frm_Main();
                main.Show();
                this.Hide();
            }
            else
            {
                dem++;
                MessageBox.Show("Đăng nhập thất bại,mời bạn nhập lại");
                if (dem == 3)
                {
                    MessageBox.Show("Bạn đã nhập sai 3 lần");
                    Application.Exit();
                }
            }         

        }   

    }
    
    
}
