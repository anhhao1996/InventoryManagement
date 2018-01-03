using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAO;
using DTO;
using System.Data.Objects;
using System.Text.RegularExpressions;
namespace BUS
{
    public class loaibus
    {
        public IRepository<LOAI> loairepository;
        public Dictionary<string, string> validatedictionary = new Dictionary<string, string>();
        public loaibus()
        {
            loairepository = new GenericRepository<LOAI>();
        }
        public bool validate(LOAI entity)
        {
            if (entity.MALOAI.Trim().Length == 0 || Regex.IsMatch(entity.MALOAI, @"[^a-zA-Z0-9]")) validatedictionary.Add("MALOAI", "Không được để trống mã loại");
            else
                if (ktidtontai(entity.MALOAI)) validatedictionary.Add("MALOAI", "Mã loại trùng");
            if (entity.TENLOAI.Trim().Length == 0) validatedictionary.Add("TENLOAI", "Không được để trống tên loại");
            if (validatedictionary.Count() <= 0)
                return true;
            return false;
        }
        public bool ktidtontai(string id)
        {
            return loairepository.GetQuery().Any(c => c.MALOAI == id);
        }
        public bool any()
        {
            return loairepository.GetQuery().Any();
        }
        public IList<string> getids()
        {
            return loairepository.GetQuery().Select(c => c.MALOAI).ToList();
        }
        public string getname(string maloai)
        {
            return loairepository.Find(c => c.MALOAI == maloai).Select(c => c.TENLOAI).FirstOrDefault();
        }
        public IList<loaidto> find(string maloai)
        {
            return loairepository.Find(x => x.MALOAI == maloai).Select(c => new loaidto(c)).ToList();
        }
        public IList<loaidto> list()
        {
            return loairepository.GetAll().Select(c => new loaidto(c)).ToList();
        }
        public bool add(LOAI entity)
        {
         
            if (validate(entity))
            {
                return loairepository.Add(entity);
            }
            return false;
        }
        public bool update(LOAI entity)
        {
     
            if (validate(entity))
            {
                return loairepository.Attach(entity);
            }
            return false;
        }
        public bool delete(LOAI entity)
        {
            if (admin.phanquyen)
            {
                return loairepository.Delete(entity);
            }
            return false;
           
        }
    }
}
