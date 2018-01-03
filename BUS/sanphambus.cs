using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAO;
using System.Data;
using System.Text.RegularExpressions;
namespace BUS
{
    public class sanphambus 
    {
        public IRepository<SANPHAM> sanphamrepository;
        public IRepository<LOAI> loairepository;
        public Dictionary<string, string> validatedictionary = new Dictionary<string, string>();
        public sanphambus()
        {
            sanphamrepository = new GenericRepository<SANPHAM>();
            loairepository = new GenericRepository<LOAI>();
        }
        public bool validate(SANPHAM entity)
        {
            if (entity.MASP.Trim().Length == 0) validatedictionary.Add("MASP", "Không được để trống mã sản phẩm");
            if (entity.TENSP.Trim().Length == 0) validatedictionary.Add("TENSP", "Không được để trống tên sản phẩm");
            if (entity.HANSUDUNG == null) validatedictionary.Add("HSD", "Không nhập hạn sử dụng");
            if (validatedictionary.Count() <= 0)
                return true;
            return false;
        }
      
        public bool ktidtontai(string id)
        {
            return sanphamrepository.GetQuery().Any(c => c.MASP == id);
        }
        public IList<SANPHAM> find(string masp)
        {
            return sanphamrepository.Find(c => c.MASP == masp).ToList();
        }
        public IList<SANPHAM> findall(string sp)
        {
            return sanphamrepository.Find(c => c.MASP.Contains(sp) || c.TENSP.Contains(sp)).Take(10).ToList();
        }
        public IList<SANPHAM> list()
        {
            return sanphamrepository.GetAll().ToList();
        }
        public bool add(SANPHAM entity)
        {
            if (validate(entity))
            {
                if (ktidtontai(entity.MASP))
                {
                    validatedictionary.Add("MASP", "Mã sản phẩm trùng");
                }
                else
                    return sanphamrepository.Add(entity);
            }
           return false;
        }
       
        public bool update(SANPHAM entity)
        {
            if (validate(entity))
                return sanphamrepository.Attach(entity);
           return false;
        }
        public bool delete(SANPHAM entity)
        {
            if (admin.phanquyen)
            {
                if (sanphamrepository.GetQuery().Any(c => c.TONKHOes.Any(e => e.MASP == entity.MASP)))
                    return false;
                return sanphamrepository.Delete(entity);
            }
            else return false;
          
        }
    }
}
