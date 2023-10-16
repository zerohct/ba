using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class SinhVienBLL
    {
        private SinhVienDAL sinhVienDAL;
        private SinhVienModel context = new SinhVienModel();
        public SinhVienBLL()
        {
            sinhVienDAL = new SinhVienDAL();
        }

        public void AddSinhVien(SINHVIEN sv)
        {
            sinhVienDAL.AddSinhVien(sv);
        }
        public List<SINHVIEN> SearchSinhVienTheoTen(string name)
        {
            var query = context.SINHVIENs
                                 .Where(e => e.HOTENSV.Contains(name))
                                 .ToList();
            return query;
        }
        public void UpdateSinhVien(SINHVIEN sv)
        {
            sinhVienDAL.UpdateSinhVien(sv);
        }

        public void DeleteSinhVien(SINHVIEN sv)
        {
            sinhVienDAL.DeleteSinhVien(sv);
        }

        public SINHVIEN GetSinhVienByMSSV(string mssv)
        {
            return sinhVienDAL.GetSinhVienByMSSV(mssv);
        }

        public List<SINHVIEN> GetAllSinhVien()
        {
            return sinhVienDAL.GetAllSinhVien();
        }
    }
}
