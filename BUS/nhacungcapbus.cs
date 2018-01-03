using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
using DTO;
using System.Data;

namespace BUS
{
    public class nhacungcapbus
    {
        public IRepository<NHACUNGCAP> nhacungcaprepository;
        public Dictionary<string, string> validatedictionary = new Dictionary<string, string>();

        public nhacungcapbus()
        {
            nhacungcaprepository = new GenericRepository<NHACUNGCAP>();
        }
        public bool validate(NHACUNGCAP entity)
        {
            if (entity.MANHACUNGCAP.Trim().Length == 0) validatedictionary.Add("MANHACUNGCAP", "Không được để trống mã nhà cung cấp");
            if (entity.TENNHACUNGCAP.Trim().Length == 0) validatedictionary.Add("TENNHACUNGCAP", "Không được để trống tên nhà cung cấp");
            if (validatedictionary.Count() <= 0)
                return true;
            return false;
        }
        public bool any()
        {
            return nhacungcaprepository.GetQuery().Any();
        }
        public IList<string> getids()
        {
            return nhacungcaprepository.GetQuery().Select(x => x.MANHACUNGCAP).ToList();
        }
        public string getname(string manhacungcap)
        {
            return nhacungcaprepository.Find(x => x.MANHACUNGCAP == manhacungcap).Select(x => x.TENNHACUNGCAP).FirstOrDefault();
        }
        public IList<NHACUNGCAP> findall(string ten)
        {
            return nhacungcaprepository.Find(c => c.MANHACUNGCAP.Contains(ten) || c.TENNHACUNGCAP.Contains(ten)).ToList();
        }
        public IList<NHACUNGCAP> list()
        {
            return nhacungcaprepository.GetAll().ToList();
        }
        public bool add(NHACUNGCAP entity)
        {
            if (validate(entity))
            {
                return nhacungcaprepository.Add(entity);
            }
            return false;
        }
        public bool update(NHACUNGCAP entity)
        {
            if (validate(entity))
            {
                return nhacungcaprepository.Attach(entity);
            }
            return false;
        }
        public bool delete(NHACUNGCAP entity)
        {
            if (admin.phanquyen)
            {
                return nhacungcaprepository.Delete(entity);
            }
            return false;
        }
    }
}
