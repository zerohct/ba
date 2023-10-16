using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class LoaiSachBLL
    {
        Model1 Context;
        private LoaiSachDAL loaiSachDAL;

        public LoaiSachBLL()
        {
            loaiSachDAL = new LoaiSachDAL();
        }

        public List<loaisach> GetAllLoaiSach()
        {
            return loaiSachDAL.GetAllLoaisach();



        }
    }
}
