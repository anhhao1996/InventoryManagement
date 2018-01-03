using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class tonkhodto
    {
        private int stt;
        private int manhaphang;
        private string masp;
        private string tensp;
        private DateTime? ngayhethan;
        private int? slnhap;
        private int? slton;
        private decimal? dongianhap;
        private decimal thanhtien;

        public tonkhodto(TONKHO entity)
        {
            stt = entity.STT;
            manhaphang = entity.MANHAPHANG;
            masp = entity.MASP;
            tensp = entity.SANPHAM.TENSP;
            ngayhethan = entity.NGAYHETHAN;
            slnhap = entity.SOLUONGNHAP;
            slton = entity.SOLUONGTON;
            dongianhap = entity.DONGIANHAP;
            thanhtien = Convert.ToDecimal(slnhap * dongianhap);
        }


        public int STT
        {
            get { return stt; }
            set { stt = value; }
        }

        [System.ComponentModel.DisplayName("Mã nhập hàng")]
        public int Manhaphang
        {
            get { return manhaphang; }
            set { manhaphang = value; }
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
        [System.ComponentModel.DisplayName("Ngày hết hạn")]
        public DateTime? Ngayhethan
        {
            get { return ngayhethan; }
            set { ngayhethan = value; }
        }
        [System.ComponentModel.DisplayName("Số lượng nhập")]
        public int? Soluongnhap
        {
            get { return slnhap; }
            set { slnhap = value; }
        }
        [System.ComponentModel.DisplayName("Số lượng tồn")]
        public int? Soluongton
        {
            get { return slton ; }
            set { slton = value; }
        }
        [System.ComponentModel.DisplayName("Đơn giá nhập")]
        public decimal? Dongianhap
        {
            get { return dongianhap; }
            set { dongianhap = value; }
        }
        [System.ComponentModel.DisplayName("Tổng giá trị")]
        public decimal Thanhtien
        {
            get { return thanhtien; }
            set { thanhtien = value; }
        }
     

       
    }
}
