using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class xuatkhodto
    {
        private int stt;
        private int matonkho;
        private string masp;
        private string tensp;
        private int? slxuat;
        private DateTime? ngayxuat;
        private decimal? dongiaxuat;
        private decimal thanhtien;

        public xuatkhodto(XUATKHO entity)
        {
            stt = entity.STT;
            matonkho = entity.MATONKHO;
            masp = entity.TONKHO.MASP;
            tensp = entity.TONKHO.SANPHAM.TENSP;
            slxuat = entity.SOLUONGXUAT;
            ngayxuat = entity.NGAYXUAT;
            dongiaxuat = entity.DONGIAXUAT;
            thanhtien = Convert.ToDecimal(slxuat * dongiaxuat);
        }

        public int STT
        {
            get { return stt; }
            set { stt = value; }
        }
        [System.ComponentModel.DisplayName("Mã tồn kho")]
        public int Matonkho
        {
            get { return matonkho; }
            set { matonkho = value; }
        }
        [System.ComponentModel.DisplayName("Mã sản phẩm")]
        public string Masp
        {
            get { return masp; }
            set { masp = value; }
        }
        [System.ComponentModel.DisplayName("Tên sản phẩm")]
        public string Tensp
        {
            get { return tensp; }
            set { tensp = value; }
        }
        [System.ComponentModel.DisplayName("Số lượng xuất")]
        public int? SOLUONGXUAT
        {
            get { return slxuat; }
            set { slxuat = value; }
        }
        [System.ComponentModel.DisplayName("Ngày xuất")]
        public DateTime? Ngayxuat
        {
            get { return ngayxuat; }
            set { ngayxuat = value; }
        }
        [System.ComponentModel.DisplayName("Đơn giá xuất")]
        public decimal? DONGIAXUAT
        {
            get { return dongiaxuat; }
            set { dongiaxuat = value; }
        }
    }
}
