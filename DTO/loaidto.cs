using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class loaidto
    {
        private string maloai;
        private string tenloai;
     

        public loaidto(LOAI entity)
        {
            maloai = entity.MALOAI;
            tenloai = entity.TENLOAI;
        }


        public string Maloai
        {
            get { return maloai; }
            set { maloai = value; }
        }

        public string Tenloai
        {
            get { return tenloai; }
            set { tenloai = value; }
        }

       
    }
}
