using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.DAL
{
    class DAL_hoadon
    {
        Lopdungchung lopchung = new Lopdungchung();

        public int ThemHD(string mahd, string manv, DateTime ngayban, string makh, string mah, string soluong, string dongia, string thanhtien)
        {

            string sql = "Insert into HOADON values(N'" + mahd + "',N'" + manv + "',N'" + ngayban.ToString() + "',N'" + makh + "',N'" + mah + "',N'" + soluong + "',N'" + dongia + "',N'" + thanhtien + "')";
            return lopchung.ThemSuaXoa(sql);
        }
        public int SuaHD(string mahd, string manv, DateTime ngayban, string makh, string mah, string soluong, string dongia, string thanhtien)
        {
            string sql = "Update HOADON set MaNV =N'" + manv + "',NgayBAN = N'" + ngayban.ToString() + "',MaKH = N'" + makh + "',MaH = N'" + mah + "',SoLUONG = N'" + soluong + "',DonGIA = N'" + dongia + "',ThanhTIEN = N'" + thanhtien + "' where MaHD = N'" + mahd + "'";
            return lopchung.ThemSuaXoa(sql);
        }
        public int XoaHD(string mahd)
        {
            string sql = "Delete HOADON where MaHD = N'" + mahd + "'";
            return lopchung.ThemSuaXoa(sql);

        }
        public DataTable LoadHD()
        {
            string sql = "Select * from HOADON";
            return lopchung.LoadDuLieu(sql);

        }

    }
}
