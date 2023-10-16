using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SachDAL
    {
        private Model1 context;
        public SachDAL()
        {
            context = new Model1();
        }

        public void AddSach(sach s)
        {
            context.saches.Add(s);
            context.SaveChanges();
        }

        public void UpdateSach(sach sv)
        {
            sach s = context.saches.Find(sv.masach);

            if (s != null)
            {
                s.tensach = sv.tensach;
                s.namxb = sv.namxb;
                s.maloai = sv.maloai;
                context.SaveChanges();
            }
        }

        public void DeleteSach(sach sv)
        {
            sach s = context.saches.Find(sv.masach);

            if (s != null)
            {
                context.saches.Remove(s);
                context.SaveChanges();
            }
        }

        public sach GetSachByMaSach(int ms)
        {
            return context.saches.FirstOrDefault(sv => sv.masach == ms);
        }

        public List<sach> GetAllSach()
        {
            return context.saches.ToList();
        }
    }
}
