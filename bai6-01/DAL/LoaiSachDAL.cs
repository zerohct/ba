using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LoaiSachDAL
    {
        private Model1 Context;

        public LoaiSachDAL()
        {
            Context = new Model1();
        }

        public List<loaisach> GetAllLoaisach()
        {
            return Context.loaisaches.ToList();
        }
    }
}
