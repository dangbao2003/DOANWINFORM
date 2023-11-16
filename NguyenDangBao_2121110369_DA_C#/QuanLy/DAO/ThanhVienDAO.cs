using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLy.DAO
{
    class ThanhVienDAO
    {
        QLPhongGymDBContext db = null;
        public ThanhVienDAO() 
        {
            db = new QLPhongGymDBContext();
        }
        public ThanhVien getRow(string tendn, string matkhau)
        {
            return db.ThanhViens.Where(m=>m.TenDN==tendn&& m.MatKhau ==matkhau).FirstOrDefault();
        }

    }
}
