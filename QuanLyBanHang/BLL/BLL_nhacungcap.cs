using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang.BLL
{
    class BLL_nhacungcap
    {
        DAL.DAL_nhacungcap dal_nhacungcap = new DAL.DAL_nhacungcap();
        GUI.frm_nhacungcap frm_nhacungcap;
        GUI.frm_hanghoa frm_hanghoa;
        public BLL_nhacungcap(GUI.frm_hanghoa f)
        {
            frm_hanghoa = f;

        }
        public BLL_nhacungcap(GUI.frm_nhacungcap f)
        {
            frm_nhacungcap = f;

        }

        public void Themncc()
        {
            int ketqua = dal_nhacungcap.Themncc(frm_nhacungcap.txt_mancc.Text, frm_nhacungcap.txt_tenncc.Text);
            if (ketqua >= 1)
                MessageBox.Show("Thêm thành công");
            else
                MessageBox.Show("Thêm thất bai");

        }
        public void Suancc()
        {
            int ketqua = dal_nhacungcap.Suancc(frm_nhacungcap.txt_mancc.Text, frm_nhacungcap.txt_tenncc.Text);
            if (ketqua >= 1) MessageBox.Show("Sửa thành công");
            else MessageBox.Show("Sửa thất bai");
        }
        public void Xoancc()
        {
            int ketqua = dal_nhacungcap.Xoancc(frm_nhacungcap.txt_mancc.Text);
            if (ketqua >= 1) MessageBox.Show("Xóa thành công");
            else MessageBox.Show("Xóa thất bai");
        }
        public void Loadncc()
        {
            frm_nhacungcap.dtv_nhacungcap.DataSource = dal_nhacungcap.Loadncc();
        }
        public void LayDSNCC()
        {
            frm_hanghoa.cb_ncc.DataSource = dal_nhacungcap.Loadncc();
            frm_hanghoa.cb_ncc.DisplayMember = "TenNCC";
            frm_hanghoa.cb_ncc.ValueMember = "MaNCC";
        }
    }
}
