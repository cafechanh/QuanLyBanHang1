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
    public partial class frm_hanghoa : Form
    {
        DataTable tblH;
        Lopdungchung lopchung = new Lopdungchung();
        BLL.BLL_hanghoa bllhh;
        BLL.BLL_nhacungcap bllncc;

        public frm_hanghoa()
        {
            InitializeComponent();
            bllncc = new BLL.BLL_nhacungcap(this);
            bllhh = new BLL.BLL_hanghoa(this);
        }

        private void frm_hanghoa_Load(object sender, EventArgs e)
        {
            bllhh.loadhh();
            bllncc.LayDSNCC();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            bllhh.themhh();
            bllhh.loadhh();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show(" Thông tin sẽ bị thay đổi. Bạn có muốn tiếp tục", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                bllhh.suahh();
                bllhh.loadhh();
            }          
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show(" Bạn có muốn xóa hay không", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                bllhh.xoahh();
                bllhh.loadhh();
            }
        }

        private void txt_dongianhap_TextChanged(object sender, EventArgs e)
        {
            double gn, gb;
            if (txt_dongianhap.Text == "")
                gn = 0;
            else
                gn = Convert.ToDouble(txt_dongianhap.Text);
            gb = gn + (gn * 20 / 100);
                txt_dongiaban.Text = gb.ToString();
        }

        private void dtv_hanghoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                txt_mahang.Text = dtv_hanghoa.CurrentRow.Cells["MaH"].Value.ToString();
                cb_ncc.SelectedValue = dtv_hanghoa.CurrentRow.Cells["MaNCC"].Value.ToString();
                txt_tenhang.Text = dtv_hanghoa.CurrentRow.Cells["TenHANG"].Value.ToString();          
                txt_soluong.Text = dtv_hanghoa.CurrentRow.Cells["SoLUONG"].Value.ToString();
                txt_dongianhap.Text = dtv_hanghoa.CurrentRow.Cells["DonGIANHAP"].Value.ToString();
                txt_dongiaban.Text = dtv_hanghoa.CurrentRow.Cells["DonGIABAN"].Value.ToString();
        }

        private void btn_Find_Click(object sender, EventArgs e)
        {           
            if ((txt_mahang.Text == "") && (txt_tenhang.Text == "") && (cb_ncc.Text == ""))
            {
                MessageBox.Show("Bạn hãy nhập thông tin tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            String sql = "SELECT * from HANGHOA WHERE 1=1";
            if (txt_mahang.Text != "")
                sql += " AND MAH LIKE N'%" + txt_mahang.Text + "%'";
            if (txt_tenhang.Text != "")
                sql += " AND TenHANG LIKE N'%" + txt_tenhang.Text + "%'";
            if (cb_ncc.Text != "")
                sql += " AND MaNCC LIKE N'%" + cb_ncc.SelectedValue + "%'";
            tblH = lopchung.LoadDuLieu(sql);
            if (tblH.Rows.Count == 0)
                MessageBox.Show("Không có hàng hóa thoả mãn điều kiện tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Có " + tblH.Rows.Count + "  hàng hóa thoả mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dtv_hanghoa.DataSource = tblH;
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            bllhh.loadhh();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
