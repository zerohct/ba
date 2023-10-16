using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    
    public class SinhVienDAL
    {
        private SinhVienModel context;
        public SinhVienDAL()
        {
            context = new SinhVienModel();
        }

        public void AddSinhVien(SINHVIEN sv)
        {
            context.SINHVIENs.Add(sv);
            context.SaveChanges();
        }

        public void UpdateSinhVien(SINHVIEN sv)
        {
            SINHVIEN sinhVien = context.SINHVIENs.Find(sv.MASV);

            if (sinhVien != null)
            {
                sinhVien.HOTENSV = sv.HOTENSV;
                sinhVien.NGAYSINH = sv.NGAYSINH;
                sinhVien.MALOP = sv.MALOP;
                context.SaveChanges();
            }
        }

        public void DeleteSinhVien(SINHVIEN sv)
        {
            SINHVIEN sinhVien = context.SINHVIENs.Find(sv.MASV);

            if (sinhVien != null)
            {
                context.SINHVIENs.Remove(sinhVien);
                context.SaveChanges();
            }
        }

        public SINHVIEN GetSinhVienByMSSV(string mssv)
        {
            return context.SINHVIENs.FirstOrDefault(sv => sv.MASV == mssv);
        }

        public List<SINHVIEN> GetAllSinhVien()
        {
            return context.SINHVIENs.ToList();
        }
    }
}
