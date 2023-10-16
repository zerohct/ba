using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LopDAL
    {
        private SinhVienModel Context;

        public LopDAL()
        {
            Context = new SinhVienModel();
        }

        public List<LOP> GetAllLop()
        {
            return Context.LOPs.ToList();
        }
    }
}
