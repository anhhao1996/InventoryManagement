using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class sanphamdto
    {
        private string mavatpham;
        private string tenvatpham;
        private string loaivatpham;
        private string hinhanh;
        private string hsd;

        public sanphamdto(SANPHAM entity)
        {
            mavatpham = entity.MASP;
            tenvatpham = entity.TENSP;
            loaivatpham = entity.LOAISP;
            hinhanh = entity.HINHANH;
            hsd = entity.HANSUDUNG;
        }
        [System.ComponentModel.DisplayName("Mã vật phẩm")]
        public string Mavatpham
        {
            get { return mavatpham; }
            set { mavatpham = value; }
        }

        [System.ComponentModel.DisplayName("Tên vật phẩm")]
        public string Tenvatpham
        {
            get { return tenvatpham; }
            set { tenvatpham = value; }
        }

        [System.ComponentModel.DisplayName("Loại vật phẩm")]
        public string Loaivatpham
        {
            get { return loaivatpham; }
            set { loaivatpham = value; }
        }

        [System.ComponentModel.DisplayName("Hạn sử dụng")]
        public string HSD
        {
            get { return hsd; }
            set { hsd = value; }
        }
        public string Hinhanh
        {
            get { return hinhanh; }
            set { hinhanh = value; }
        }

        
    }
}
