using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class SachBLL
    {
        private SachDAL sachDAL;
        private Model1 context = new Model1();
        public SachBLL()
        {
            sachDAL = new SachDAL();
        }

        public void AddSach(sach s)
        {
            sachDAL.AddSach(s);
        }
        public List<sach> SearchSachTheoTen(string name)
        {
            var query = context.saches
                                 .Where(e => e.tensach.Contains(name))
                                 .ToList();
            return query;
        }
        public void UpdateSach(sach sv)
        {
            sachDAL.UpdateSach(sv);
        }

        public void DeleteSach(sach sv)
        {
            sachDAL.DeleteSach(sv);
        }

        public sach GetSACHByMaSach(int ms)
        {
            return sachDAL.GetSachByMaSach(ms);
        }

        public List<sach> GetAllSach()
        {
            return sachDAL.GetAllSach();
        }
    }
}
