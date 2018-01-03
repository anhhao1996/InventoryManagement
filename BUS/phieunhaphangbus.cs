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
    public class phieunhaphangbus 
    {
        public IRepository<PHIEUNHAPHANG> phieunhaphangrepository;
        Dictionary<string, string> validatedictionary = new Dictionary<string, string>();

        public phieunhaphangbus()
        {
            phieunhaphangrepository = new GenericRepository<PHIEUNHAPHANG>();
        }
        public bool validate(PHIEUNHAPHANG entity)
        {
            if (entity.MANV.Trim().Length == 0 || Regex.IsMatch(entity.MANV, @"^[a-zA-Z]+$")) validatedictionary.Add("MANV", "Không được để trống nhân viên");         
            if (validatedictionary.Count() <= 0)
                return true;
            return false;
        }
        public bool any()
        {
            return phieunhaphangrepository.GetQuery().Any();
        }
        public int getcurrentid()
        {
            return phieunhaphangrepository.GetQuery().Max(c => c.MANHAPHANG);
        }
        public IList<PHIEUNHAPHANG> findall(string keyword)
        {
            return phieunhaphangrepository.Find(x=> x.MANHACUNGCAP.Contains(keyword) || x.MANV.Contains(keyword) || x.NHACUNGCAP.TENNHACUNGCAP.Contains(keyword) || x.NHANVIEN.TENNV.Contains(keyword)).ToList();
        }
        public IList<PHIEUNHAPHANG> list()
        {
            return phieunhaphangrepository.GetAll().ToList();
        }
        public bool add(PHIEUNHAPHANG entity)
        {
            if(validate(entity))
                return phieunhaphangrepository.Add(entity);
            return false;
        }
        public bool update(PHIEUNHAPHANG entity)
        {
            if(validate(entity))
            return phieunhaphangrepository.Attach(entity);
            return false;
        }
        public bool delete(PHIEUNHAPHANG entity)
        {
            if(admin.phanquyen)
              return phieunhaphangrepository.Delete(entity);
            return false;
        }
    }
}
