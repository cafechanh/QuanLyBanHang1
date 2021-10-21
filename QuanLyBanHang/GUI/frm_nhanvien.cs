using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang.GUI
{
    public partial class frm_nhanvien : Form
    {
        BLL.BLL_nhanvien bll_nv;
        Lopdungchung lopchung = new Lopdungchung();

        public frm_nhanvien()
        {
            InitializeComponent();
            bll_nv = new BLL.BLL_nhanvien(this);
        }
      
        private void frm_nhanvien_Load(object sender, EventArgs e)
        {
            bll_nv.loadnv();
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            bll_nv.loadnv();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            bll_nv.luunv();
            bll_nv.loadnv();
        } 
        
        private void btnSua_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show(" Thông tin sẽ bị thay đổi. Bạn có muốn tiếp tục", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                bll_nv.suanv();
                bll_nv.loadnv();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show(" Bạn có muốn xóa hay không", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                bll_nv.xoanv();
                bll_nv.loadnv();
            }          
        }

        private void dtv_nhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_mnv.Text = dtv_nhanvien.CurrentRow.Cells["MaNV"].Value.ToString();
            txt_tennv.Text = dtv_nhanvien.CurrentRow.Cells["TenNV"].Value.ToString();
            cb_gioitinh.Text = dtv_nhanvien.CurrentRow.Cells["GioiTINH"].Value.ToString();
            dt_ngaysinh.Value = Convert.ToDateTime(dtv_nhanvien.CurrentRow.Cells["NgaySINH"].Value);          
            txt_diachi.Text = dtv_nhanvien.CurrentRow.Cells["DiaCHI"].Value.ToString();
            txt_sdt.Text = dtv_nhanvien.CurrentRow.Cells["SDT"].Value.ToString();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            if ((txt_tennv.Text == ""))
            {
                MessageBox.Show("Bạn hãy nhập tên nhân viên cần tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
           string sql = "SELECT * from NHANVIEN WHERE 1=1";
            if (txt_tennv.Text != "")
                sql += " AND TenNV LIKE N'%" + txt_tennv.Text + "%'";
              DataTable dt = lopchung.LoadDuLieu(sql);
            if (dt.Rows.Count == 0)
                MessageBox.Show("Không có tên nhân viên cần tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Có " + dt.Rows.Count + " nhân viên thoả mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dtv_nhanvien.DataSource = dt;
        }      
    }
}
