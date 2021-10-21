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
    public partial class frm_khachhang : Form
    {
        BLL.BLL_khachhang bllkh;
        public frm_khachhang()
        {
            InitializeComponent();
            bllkh = new BLL.BLL_khachhang(this);
        }

        private void frm_khachhang_Load(object sender, EventArgs e)
        {
            bllkh.loadkh();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            bllkh.Luukh();
            bllkh.loadkh();
        }
      
        private void btnSua_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show(" Thông tin sẽ bị thay đổi. Bạn có muốn tiếp tục", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                bllkh.suakh();
                bllkh.loadkh();
            }       
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show(" Bạn có muốn xóa hay không", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                bllkh.xoakh();
                bllkh.loadkh();
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtv_khachhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            txt_makh.Text = dtv_khachhang.Rows[numrow].Cells[0].Value.ToString();
            txt_tenkh.Text = dtv_khachhang.Rows[numrow].Cells[1].Value.ToString();
            dt_namsinh.Value = Convert.ToDateTime(dtv_khachhang.Rows[numrow].Cells[2].Value);
            cb_gioitinh.Text = dtv_khachhang.Rows[numrow].Cells[3].Value.ToString();
            txt_diachi.Text = dtv_khachhang.Rows[numrow].Cells[4].Value.ToString();
            txt_sdt.Text = dtv_khachhang.Rows[numrow].Cells[5].Value.ToString();
           
        }
    }
}
