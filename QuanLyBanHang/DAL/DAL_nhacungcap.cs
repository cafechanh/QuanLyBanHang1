using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.DAL
{
    class DAL_nhacungcap
    {
        Lopdungchung lopchung = new Lopdungchung();

        public int Themncc(string mancc, string tenncc)
        {

            string sql = "Insert into NHACUNGCAP values(N'" + mancc + "',N'" + tenncc + "')";
            return lopchung.ThemSuaXoa(sql);
        }
        public int Suancc(string mancc, string tenncc)
        {
            string sql = "Update NHACUNGCAP set TenNCC =N'" + tenncc + "'where MaNCC = '" + mancc + "'";
            return lopchung.ThemSuaXoa(sql);
        }
        public int Xoancc(string mancc)
        {
            string sql = "Delete NHACUNGCAP where MaNCC = N'" + mancc + "'";
            return lopchung.ThemSuaXoa(sql);

        }
        public DataTable Loadncc()
        {
            string sql = "Select * from NHACUNGCAP";
            return lopchung.LoadDuLieu(sql);

        }
    }
}
