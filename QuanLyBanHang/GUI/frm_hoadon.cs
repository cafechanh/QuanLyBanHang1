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
    public partial class frm_hoadon : Form
    {      
        Lopdungchung lopchung = new Lopdungchung();
        DataTable dthd;
        SqlConnection con;
        SqlCommand comm;

        BLL.BLL_khachhang bllkh;
        BLL.BLL_nhanvien bllnv;
        BLL.BLL_hanghoa bllhh;
        BLL.BLL_hoadon bllhd;

        public frm_hoadon()
        {
            InitializeComponent();
            bllkh = new BLL.BLL_khachhang(this);
            bllnv = new BLL.BLL_nhanvien(this);
            bllhh = new BLL.BLL_hanghoa(this);
            bllhd = new BLL.BLL_hoadon(this);
        }

        private void frm_hoadon_Load(object sender, EventArgs e)
        {
            bllkh.LayDSNCC();
            bllnv.LayDSNV();
            bllhh.LayDSHH();
            bllhd.loadhd();
        }

        private void btn_hienthihd_Click(object sender, EventArgs e)
        {
            bllhd.loadhd();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            bllhd.themhd();
            bllhd.loadhd();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            bllhd.suahd();
            bllhd.loadhd();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show(" Bạn có muốn xóa hay không", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                bllhd.xoahd();
                bllhd.loadhd();
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cb_manv_SelectedIndexChanged(object sender, EventArgs e)
        {
            con =lopchung.connection();
            con.Open();
            comm = new SqlCommand("select * from NHANVIEN where MaNV = '" + cb_manv.SelectedValue.ToString() + "'", con);
            SqlDataReader reader = comm.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                txt_tennv.Text = reader.GetString(1).ToString();
            }
        }

        private void cb_makh_SelectedIndexChanged(object sender, EventArgs e)
        {
            con = lopchung.connection();
            con.Open();
            comm = new SqlCommand("select * from KHACHHANG where MaKH = '" + cb_makh.SelectedValue.ToString() + "'", con);
            SqlDataReader reader = comm.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                txt_tenkh.Text = reader.GetString(1).ToString();
                txt_diachi.Text = reader.GetString(4).ToString();
                txt_dienthoai.Text = reader.GetString(5).ToString();
            }
        }

        private void cb_mahang_SelectedIndexChanged(object sender, EventArgs e)
        {
            con = lopchung.connection();
            con.Open();
            comm = new SqlCommand("select * from HANGHOA where MaH = '" + cb_mahang.SelectedValue.ToString() + "'", con);
            SqlDataReader reader = comm.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                txt_tenhang.Text = reader.GetString(2).ToString();
                txt_dongia.Text = reader.GetInt32(5).ToString();
            }
        }

        private void txt_soluong_TextChanged(object sender, EventArgs e)
        {
            double sl, gn, tt;
            if (txt_dongia.Text == "")
                gn = 0;
            else
                gn = Convert.ToDouble(txt_dongia.Text);
            if (txt_soluong.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(txt_soluong.Text);
            tt = gn * sl;
            txt_thanhtien.Text = tt.ToString();
        }

        private void dtv_hd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_mahd.Text = dtv_hd.CurrentRow.Cells["MaHD"].Value.ToString();
            cb_manv.Text = dtv_hd.CurrentRow.Cells["MaNV"].Value.ToString();
            dt_ngayban.Value = Convert.ToDateTime(dtv_hd.CurrentRow.Cells["NgayBAN"].Value);
            cb_makh.Text = dtv_hd.CurrentRow.Cells["MaKH"].Value.ToString();
            cb_mahang.Text = dtv_hd.CurrentRow.Cells["MAH"].Value.ToString();
            txt_soluong.Text = dtv_hd.CurrentRow.Cells["SoLUONG"].Value.ToString();
            txt_dongia.Text = dtv_hd.CurrentRow.Cells["DonGIA"].Value.ToString();
            txt_thanhtien.Text = dtv_hd.CurrentRow.Cells["ThanhTIEN"].Value.ToString();
        }

        private void btn_timkiemnv_Click(object sender, EventArgs e)
        {
            string sql;
            if ((cb_manv.Text == ""))
            {
                MessageBox.Show("Bạn hãy nhập điều kiện tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "SELECT * from HOADON WHERE 1=1";

            if (cb_manv.Text != "")
                sql += " AND MaNV LIKE N'%" + cb_manv.SelectedValue + "%'";
            dthd = lopchung.LoadDuLieu(sql);
            if (dthd.Rows.Count == 0)
                MessageBox.Show("Không có nhân viên thoả mãn điều kiện tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Có " + dthd.Rows.Count + " nhân viên thoả mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dtv_hd.DataSource = dthd;
        }

        private void btn_timkiemkh_Click(object sender, EventArgs e)
        {
            string sql;
            if ((cb_makh.Text == ""))
            {
                MessageBox.Show("Bạn hãy nhập điều kiện tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "SELECT * from HOADON WHERE 1=1";

            if (cb_makh.Text != "")
                sql += " AND MaKH LIKE N'%" + cb_makh.SelectedValue + "%'";
            dthd = lopchung.LoadDuLieu(sql);
            if (dthd.Rows.Count == 0)
                MessageBox.Show("Không có khách hàng thoả mãn điều kiện tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Có " + dthd.Rows.Count + " khách thoả mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dtv_hd.DataSource = dthd;
        }
       
        private void btn_tinhtong_Click(object sender, EventArgs e)
        {
            int sc = dtv_hd.Rows.Count;
            float thanhtien = 0;
            for (int i = 0; i < sc -1; i++)
                thanhtien += float.Parse(dtv_hd.Rows[i].Cells["ThanhTIEN"].Value.ToString());
            txt_tongtien.Text = thanhtien.ToString();
        }      
    }
}
