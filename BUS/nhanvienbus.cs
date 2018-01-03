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
    public class nhanvienbus
    {
        public IRepository<NHANVIEN> nhanvienrepository;
        public Dictionary<string, string> validatedictionary = new Dictionary<string, string>();
        public nhanvienbus()
        {
            nhanvienrepository = new GenericRepository<NHANVIEN>();
        }
        public bool validate(NHANVIEN entity)
        {
            if (entity.MANV.Trim().Length == 0 || Regex.IsMatch(entity.MANV, @"^[a-zA-Z]+$")) validatedictionary.Add("MANV", "Mã nhân viên không hợp lệ");
            if (entity.TENNV.Trim().Length == 0 || Regex.IsMatch(entity.TENNV, @"^[a-zA-Z]+$")) validatedictionary.Add("TENNV", "Tên nhân viên không hợp lệ");
            if (entity.MATKHAU.Trim().Length == 0 || Regex.IsMatch(entity.MATKHAU, @"^[a-zA-Z]+$")) validatedictionary.Add("MATKHAU", "Mật khẩu không hợp lệ");
            if (entity.DIACHI.Trim().Length == 0)
                validatedictionary.Add("DIACHI", "Địa chỉ không hợp lệ");
            if (validatedictionary.Count() <= 0)
                return true;
            return false;
        }
        public bool ktidtontai(string id)
        {
            return nhanvienrepository.GetQuery().Any(c => c.MANV == id);
        }
        public bool? phanquyen(string id)
        {
            return nhanvienrepository.Find(c => c.MANV == id).Select(c => c.PHANQUYEN).FirstOrDefault();
        }
        public bool dangnhap(string id, string pass)
        {
            return nhanvienrepository.GetQuery().Any(x => x.MANV == id && x.MATKHAU == pass);
        }
        public string getname(string manv)
        {
            return nhanvienrepository.Find(x => x.MANV == manv).Select(x => x.TENNV).FirstOrDefault();
        }
        public IList<NHANVIEN> findall(string ten)
        {
            return nhanvienrepository.Find(c => c.TENNV.Contains(ten) || c.MANV.Contains(ten)).ToList();
        }
        public IList<NHANVIEN> list()
        {
            return nhanvienrepository.GetAll().ToList();
        }
        public bool add(NHANVIEN entity)
        {
            if (validate(entity))
            {
                if (ktidtontai(entity.MANV)) validatedictionary.Add("MANV", "Mã nhân viên đã tồn tại");
                else
                    return nhanvienrepository.Add(entity);
            }
            return false;
           
        }
        public bool update(NHANVIEN entity)
        {
            if (validate(entity))
            {
                return nhanvienrepository.Attach(entity);
            }
            return false;
        }
        public bool delete(NHANVIEN entity)
        {
           if(validate(entity))
                return nhanvienrepository.Delete(entity);
           return false;
        }
    }
}
