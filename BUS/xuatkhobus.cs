using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
using DTO;
using System.Data;
using System.Text.RegularExpressions;
namespace BUS
{
    public class xuatkhobus
    {
        public IRepository<TONKHO> tonkhorepository;
        public IRepository<XUATKHO> xuatkhorepository;
        public Dictionary<string, string> validatedictionary = new Dictionary<string, string>();
        public xuatkhobus()
        {
            xuatkhorepository = new GenericRepository<XUATKHO>();
            tonkhorepository = new GenericRepository<TONKHO>();
        }

        public bool validate(XUATKHO entity)
        {
            decimal? dongianhap = tonkhorepository.Find(c => c.STT == entity.MATONKHO).Select(c => c.DONGIANHAP).FirstOrDefault();
            if (entity.DONGIAXUAT <= 0)
                validatedictionary.Add("DONGIAXUAT", "Không được để trống đơn giá xuất");

            if(entity.DONGIAXUAT < dongianhap)
                validatedictionary.Add("DONGIAXUAT", "Đơn giá xuất nhỏ hơn đơn giá nhập");
            else 
                if(entity.DONGIAXUAT < 200)
                    validatedictionary.Add("DONGIAXUAT", "Không có giá nhỏ hơn 200 VND");
            //nếu soluongxuat = 0 báo lỗi nếu không thì check tiếp số lượng xuất lớn hơn số lượng tồn trong kho không
            if (entity.SOLUONGXUAT == 0)
                validatedictionary.Add("SOLUONGXUAT", "Số lượng xuất không thể bằng 0");
            else
                if (kiemtratonkho(entity.SOLUONGXUAT, entity.MATONKHO))
                    validatedictionary.Add("SOLUONGXUAT", "Số lượng xuất lớn hơn số lượng tồn");
            
            if (validatedictionary.Count() <= 0)
           
                return true;
          
            return false;
        }
        public bool kiemtratonkho(int? slxuatkho, int matonkho)
        {
            int? test = tonkhorepository.Find(c => c.STT == matonkho).Select(c => c.SOLUONGTON).FirstOrDefault();
            if (slxuatkho > test)
                return true;
            else
                return false;
        }
        public decimal? tonggiaxuattheongay(DateTime? dt)
        {
            return xuatkhorepository.Find(c => c.NGAYXUAT == dt).Sum(c => (c.SOLUONGXUAT * c.DONGIAXUAT));
        }
        public decimal? tonggiaxuattheothang(int thang, int nam)
        {
            return xuatkhorepository.Find(c => c.NGAYXUAT.Value.Month == thang ).Sum(c => (c.SOLUONGXUAT * c.DONGIAXUAT));
        }
        public decimal? tonggiaxuattheonam(int nam)
        {
            return xuatkhorepository.Find(c => c.NGAYXUAT.Value.Year == nam).Sum(c => (c.SOLUONGXUAT * c.DONGIAXUAT));
        }
        public IList<xuatkhodto> timdethongke(int input)
        {
            return xuatkhorepository.Find(c => c.MATONKHO == input).Select(c => new xuatkhodto(c)).ToList();
        }
        public IList<xuatkhodto> timkiem(string input)
        {
            int ma;
            if (int.TryParse(input, out ma) == false)
            {
                return xuatkhorepository.Find(c => c.TONKHO.MASP == input || c.TONKHO.SANPHAM.TENSP == input).Select(c => new xuatkhodto(c)).ToList();
            }
            return xuatkhorepository.Find(c => c.STT == ma || c.MATONKHO == ma || c.TONKHO.MASP == input || c.TONKHO.SANPHAM.TENSP == input).Select(c => new xuatkhodto(c)).ToList();
        }
        public IList<xuatkhodto> timkiem1(string tensp,DateTime? tungay,DateTime? denngay)
        {
                return xuatkhorepository.Find(c => (c.TONKHO.MASP == tensp || c.TONKHO.SANPHAM.TENSP == tensp)&& (c.NGAYXUAT >= tungay && c.NGAYXUAT <= denngay)).Select(c => new xuatkhodto(c)).ToList();
        }
        public IList<xuatkhodto> timkiemtheongay(DateTime? ngayxuat)
        {
            return xuatkhorepository.Find(c => c.NGAYXUAT == ngayxuat).Select(c => new xuatkhodto(c)).ToList();
        }
        public IList<xuatkhodto> timkiemtheodieukien(int ngayxuat,string ngaythangnam) 
        {
            if (ngaythangnam.Equals("Ngày"))
            {
                return xuatkhorepository.Find(c => c.NGAYXUAT.Value.Day == ngayxuat).Select(c => new xuatkhodto(c)).ToList(); 
            }
            else
            {
                if (ngaythangnam.Equals("Tháng"))
                    return xuatkhorepository.Find(c => c.NGAYXUAT.Value.Month == ngayxuat).Select(c => new xuatkhodto(c)).ToList();
                else
                    return xuatkhorepository.Find(c => c.NGAYXUAT.Value.Year == ngayxuat).Select(c => new xuatkhodto(c)).ToList();
            }
        }
        public bool any()
        {
            return xuatkhorepository.GetQuery().Any();
        }
        public IList<XUATKHO> timxuatkho(string input)
        {
            int ma;
            if (int.TryParse(input, out ma) == false)
            {
                return xuatkhorepository.Find(c => c.TONKHO.MASP == input || c.TONKHO.SANPHAM.TENSP == input).ToList();
            }
            return xuatkhorepository.Find(c => c.STT == ma || c.MATONKHO == ma || c.TONKHO.MASP == input || c.TONKHO.SANPHAM.TENSP == input).ToList();
        }
        public IList<string> findsanpham()
        {
            IList<string> a = xuatkhorepository.GetAll().Select(c => c.TONKHO.SANPHAM.TENSP).ToList();
            IList<string> b = xuatkhorepository.GetAll().Select(c => c.TONKHO.MASP).ToList();
            return a.Concat(b).ToList();
        }
        public IList<XUATKHO> list()
        {
            return xuatkhorepository.GetAll().ToList();
        }
        
        public bool add(XUATKHO entity)
        {
            if (validate(entity))
            {
                TONKHO tk1 = new TONKHO();
                tk1 = tonkhorepository.Find(c => c.STT == entity.MATONKHO).FirstOrDefault();
                int? slton = tk1.SOLUONGTON;
                slton = slton - Convert.ToInt32(entity.SOLUONGXUAT);
                tk1.SOLUONGTON = slton;
                if (!tonkhorepository.Update(tk1))
                    return false;

                return xuatkhorepository.Add(entity);
            }
            return false;
        }
        public bool update(XUATKHO entity, int soluongxuathientai)
        {
            if (validate(entity))
            {
                TONKHO tk1 = new TONKHO();
                tk1 = tonkhorepository.Find(c => c.STT == entity.MATONKHO).FirstOrDefault();
                int? slton = tk1.SOLUONGTON;
                slton = slton - Convert.ToInt32(entity.SOLUONGXUAT);
                tk1.SOLUONGTON = slton;
                if (!tonkhorepository.Update(tk1))
                    return false;
                entity.SOLUONGXUAT += soluongxuathientai;
                return xuatkhorepository.Attach(entity);
            }
           return false;
        }
        public bool delete(XUATKHO entity)
        {
            if (admin.phanquyen)
            {
                TONKHO tk1 = new TONKHO();
                tk1 = tonkhorepository.Find(c => c.STT == entity.MATONKHO).FirstOrDefault();
                int? slton = tk1.SOLUONGTON;
                slton = slton + Convert.ToInt32(entity.SOLUONGXUAT);
                tk1.SOLUONGTON = slton;
                if (!tonkhorepository.Update(tk1))
                    return false;
                return xuatkhorepository.Delete(entity);
            }
            else return false;
        }
        public IList<xuatkhodto> thongketheongay(DateTime? tungay,DateTime? denngay)
        {
            return xuatkhorepository.Find(c => (c.NGAYXUAT >= tungay && c.NGAYXUAT <= denngay)).Select(c => new xuatkhodto(c)).ToList();
        }
        public IEnumerable<XUATKHO> find(int stt)
        {
            return xuatkhorepository.Find(x => x.STT == stt);
        }
    }
}
