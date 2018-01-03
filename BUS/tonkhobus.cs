using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using DAO;
using DTO;
using System.Text.RegularExpressions;
namespace BUS
{
    public class tonkhobus 
    {
        public IRepository<TONKHO> tonkhorepository;
        public Dictionary<string, string> validatedictionary = new Dictionary<string, string>();

        public tonkhobus()
        {
            tonkhorepository = new GenericRepository<TONKHO>();
        }
        public bool validate(TONKHO entity)
        {
            if (entity.DONGIANHAP <= 0)
                validatedictionary.Add("DONGIANHAP", "Nhập sai đơn giá nhập");
            if (validatedictionary.Count() <= 0)

                return true;

            return false;
        }
        public bool any()
        {
            return tonkhorepository.GetQuery().Any();
        }

        public decimal? tonggianhaptheongay(DateTime? dt)
        {
            return tonkhorepository.Find(c => c.PHIEUNHAPHANG.NGAYNHAPHANG == dt).Sum(c => (c.SOLUONGNHAP * c.DONGIANHAP));
        }
        public decimal? tonggianhaptheothang(int thang, int nam)
        {
            return tonkhorepository.Find(c => c.PHIEUNHAPHANG.NGAYNHAPHANG.Value.Month == thang ).Sum(c => (c.SOLUONGNHAP * c.DONGIANHAP));
        }
        public decimal? tonggianhaptheonam(int nam)
        {
            return tonkhorepository.Find(c => c.PHIEUNHAPHANG.NGAYNHAPHANG.Value.Year == nam).Sum(c => (c.SOLUONGNHAP * c.DONGIANHAP));
        }
        //sua
        public IList<tonkhodto> findhangtonkho(string sp)
        {
            return tonkhorepository.Find(c => c.SANPHAM.TENSP.Contains(sp) || c.SANPHAM.MASP.Contains(sp) && c.SOLUONGTON > 0).Select(c => new tonkhodto(c)).ToList();
        }
        public IList<TONKHO> findmothangtonkho(string sp)
        {
            return tonkhorepository.Find(c => c.SANPHAM.MASP == sp && c.SOLUONGTON > 0).ToList();
        }
        public IList<TONKHO> findhangtonkho(string sp, DateTime? ngaynhap)
        {
            return tonkhorepository.Find(c => (c.SANPHAM.TENSP.Contains(sp) || c.SANPHAM.MASP.Contains(sp)) && c.SOLUONGTON > 0 && c.PHIEUNHAPHANG.NGAYNHAPHANG == ngaynhap).ToList();
        }
        public IList<TONKHO> findall(string sp)
        {
            return tonkhorepository.Find(c => c.SANPHAM.TENSP.Contains(sp) || c.SANPHAM.MASP.Contains(sp)).ToList();
        }
        public IList<TONKHO> findall(int manhaphang)
        {
            return tonkhorepository.Find(c => c.MANHAPHANG == manhaphang).ToList();
        }
        public int? find1(int matonkho)
        {
            return tonkhorepository.Find(c => c.STT == matonkho).Select(c => c.SOLUONGTON).FirstOrDefault();
        }
        public IList<TONKHO> find(int matonkho)
        {
            return tonkhorepository.Find(c => c.STT == matonkho).ToList();
        }
        public IList<tonkhodto> list()
        {
            return tonkhorepository.GetAll().Select(c => new tonkhodto(c)).ToList();
        }
        public bool add(TONKHO entity)
        {
            if(validate(entity))
            {
                return tonkhorepository.Add(entity);
            }
            return false;
        }
        public bool update(TONKHO entity)
        {
            if (entity.STT != 0)
            {
                if (validate(entity))
                {
                    return tonkhorepository.Attach(entity);
                }
            }
            return false;
        }
        public bool delete(TONKHO entity)
        {
            if (admin.phanquyen)
            {
                return tonkhorepository.Delete(entity);
            }
            return false;
        }
    }
}
