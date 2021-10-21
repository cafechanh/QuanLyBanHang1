using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.DAL
{
    class DAL_khachhang
    {
        Lopdungchung lopchung = new Lopdungchung();

        public int ThemKH(string makh, string tenkh, DateTime ngaysinh, string gioitinh, string diachi, string sdt)
        {

            string sql = "Insert into KHACHHANG values(N'" + makh + "',N'" + tenkh + "',N'" + ngaysinh.ToString() + "',N'" + gioitinh + "',N'" + diachi + "',N'" + sdt + "')";
            return lopchung.ThemSuaXoa(sql);
        }
        public int Suakh(string makh, string hoten, DateTime ngaysinh, string gioitinh, string diachi, string sdt)
        {
            string sql = "Update KHACHHANG set TenKH =N'" + hoten + "',NgaySINH =N'" + ngaysinh.ToString() + "',GioiTINH =N'" + gioitinh + "',DiaCHI =N'" + diachi + "',SDT =N'" + sdt + "'where MaKH = '" + makh + "'";
            return lopchung.ThemSuaXoa(sql);
        }
        public int Xoakh(string makh)
        {
            string sql = "Delete KHACHHANG where MaKH = N'" + makh + "'";
            return lopchung.ThemSuaXoa(sql);

        }
        public DataTable Loadkh()
        {
            string sql = "Select * from KHACHHANG";
            return lopchung.LoadDuLieu(sql);

        }

    }
}
