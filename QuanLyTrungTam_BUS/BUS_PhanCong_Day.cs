using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyNhaHang_Entity;
using QuanLyTrungTam_Data;
using System.Data;

namespace QuanLyTrungTam_BUS
{
    public class BUS_PhanCong_Day
    {
        DAL_PhanCong_Day sql = new DAL_PhanCong_Day();
        public void ThemDuLieu(EC_PhanCong_Day ec)
        {
            sql.ThemDuLieu(ec);
        }
        public void XoaDuLieu(EC_PhanCong_Day ec)
        {
            sql.XoaDuLieu(ec);
        }

        public List<EC_PhanCong_Day> SelectAll()
        {
            return sql.SelectAll();
        }

        public List<EC_PhanCong_Day> SelectByFields(string fieldname, object value)
        {
            return sql.SelectByFields(fieldname, value);
        }
    }
}
