using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class LopBLL
    {
        SinhVienModel Context;
        private LopDAL lopDAL;

        public LopBLL()
        {
            lopDAL = new LopDAL();
        }

        public List<LOP> GetAllKhoa()
        {
            return lopDAL.GetAllLop();



        }
    }
}
