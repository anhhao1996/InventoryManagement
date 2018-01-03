using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class nhaphangdto
    {
        private int manhaphang;
        private DateTime? ngaynhaphang;
        private string nhacungcap;
        private string tennhanvien;

        public nhaphangdto(PHIEUNHAPHANG entity)
        {
            manhaphang = entity.MANHAPHANG;
            ngaynhaphang = entity.NGAYNHAPHANG;
            nhacungcap = entity.NHACUNGCAP.TENNHACUNGCAP;
            tennhanvien = entity.NHANVIEN.TENNV;
        }

        public int Manhaphang
        {
            get { return manhaphang; }
            set { manhaphang = value; }
        }

        public DateTime? Ngaynhaphang
        {
            get { return ngaynhaphang; }
            set { ngaynhaphang = value; }
        }

        public string Nhacungcap
        {
            get { return nhacungcap; }
            set { nhacungcap = value; }
        }

        public string Tennhanvien
        {
            get { return tennhanvien; }
            set { tennhanvien = value; }
        }

    }
    
}
