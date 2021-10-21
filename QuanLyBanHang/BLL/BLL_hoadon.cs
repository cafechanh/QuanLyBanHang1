using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang.BLL
{
    class BLL_hoadon
    {
        DAL.DAL_hoadon dal_hoadon = new DAL.DAL_hoadon();
        GUI.frm_hoadon frm_hoadon;
        GUI.frm_thongke frm_thongke;
        public BLL_hoadon(GUI.frm_hoadon f)
        {
            frm_hoadon = f;
        }
        public BLL_hoadon(GUI.frm_thongke f)
        {
            frm_thongke = f;
        }
        public void themhd()
        {
            int ketqua = dal_hoadon.ThemHD(frm_hoadon.txt_mahd.Text, frm_hoadon.cb_manv.SelectedValue.ToString(), frm_hoadon.dt_ngayban.Value, frm_hoadon.cb_makh.SelectedValue.ToString(), frm_hoadon.cb_mahang.SelectedValue.ToString(), frm_hoadon.txt_soluong.Text, frm_hoadon.txt_dongia.Text, frm_hoadon.txt_thanhtien.Text);
            if (ketqua >= 1)
                MessageBox.Show("Thêm thành công");
            else
                MessageBox.Show("Thêm thất bai");

        }
        public void suahd()
        {
            int ketqua = dal_hoadon.SuaHD(frm_hoadon.txt_mahd.Text, frm_hoadon.cb_manv.SelectedValue.ToString(), frm_hoadon.dt_ngayban.Value, frm_hoadon.cb_makh.SelectedValue.ToString(), frm_hoadon.cb_mahang.SelectedValue.ToString(), frm_hoadon.txt_soluong.Text, frm_hoadon.txt_dongia.Text, frm_hoadon.txt_thanhtien.Text);
            if (ketqua >= 1)
                MessageBox.Show("Sửa thành công");
            else
                MessageBox.Show("Sửa thất bai");
        }
        public void xoahd()
        {
            int ketqua = dal_hoadon.XoaHD(frm_hoadon.txt_mahd.Text);
            if (ketqua >= 1)
                MessageBox.Show("Xóa thành công");
            else
                MessageBox.Show("Xóa thất bai");
        }
        public void loadhd()
        {
            frm_hoadon.dtv_hd.DataSource = dal_hoadon.LoadHD();
        }
        public void loadtk()
        {
            frm_thongke.dgv_thongke.DataSource = dal_hoadon.LoadHD();
        }


    }
}
