using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang.BLL
{
    class BLL_hanghoa
    {
        DAL.DAL_hanghoa dAL_hh = new DAL.DAL_hanghoa();
        GUI.frm_hanghoa frm_hh;
        GUI.frm_hoadon frm_hoadon;
        GUI.frm_nhacungcap frm_ncc;
        public BLL_hanghoa(GUI.frm_hanghoa f)
        {
            frm_hh = f;
        }
        public BLL_hanghoa(GUI.frm_hoadon f)
        {
            frm_hoadon = f;
        }
        public BLL_hanghoa(GUI.frm_nhacungcap f)
        {
            frm_ncc = f;
        }
        public void themhh()
        {
            int ketqua = dAL_hh.Themhang(frm_hh.txt_mahang.Text, frm_hh.cb_ncc.SelectedValue.ToString(), frm_hh.txt_tenhang.Text, frm_hh.txt_soluong.Text, frm_hh.txt_dongianhap.Text, frm_hh.txt_dongiaban.Text);
            if (ketqua >= 1)
                MessageBox.Show("Thêm thành công");
            else
                MessageBox.Show("Thêm thất bai");

        }
        public void suahh()
        {
            int ketqua = dAL_hh.Suahang(frm_hh.txt_mahang.Text, frm_hh.cb_ncc.SelectedValue.ToString(), frm_hh.txt_tenhang.Text, frm_hh.txt_soluong.Text, frm_hh.txt_dongianhap.Text, frm_hh.txt_dongiaban.Text);
            if (ketqua >= 1) MessageBox.Show("Sửa thành công");
            else MessageBox.Show("Sửa thất bai");
        }
        public void xoahh()
        {
            int ketqua = dAL_hh.Xoahang(frm_hh.txt_mahang.Text);
            if (ketqua >= 1)
                MessageBox.Show("Xóa thành công");
            else
                MessageBox.Show("Xóa thất bai");
        }
        public void loadhh()
        {
            frm_hh.dtv_hanghoa.DataSource = dAL_hh.Loadhh();
        }
        public void LayDSHH()
        {
            frm_hoadon.cb_mahang.DataSource = dAL_hh.Loadhh();
            frm_hoadon.cb_mahang.DisplayMember = "MaH";
            frm_hoadon.cb_mahang.ValueMember = "MaH";
        }

    }
}
