using Store.Core.Entities;
using Store.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Repsitories
{
    public class SalerRepository : ISalerRepository
    {
        private readonly DataContext _context;

        public SalerRepository(DataContext context)
        {
            _context = context;
        }
        public void Delete(int id)
        {
            Saler s = _context.SalerList.Find(s => s.Id == id);
            _context.SalerList.Remove(s);;
        }

        public void DeleteBySalary(int minSalary)
        {
            Saler s = _context.SalerList.Find(s => s.Salary == minSalary);
            _context.SalerList.Remove(s);
        }

        public List<Saler> Get()
        {
            return _context.SalerList;
        }

        public Saler Get(int id)
        {
            return _context.SalerList.Find(s => s.Id == id);
        }

        public void Post(Saler value)
        {
            _context.SalerList.Add(value);
        }

        public void Put(int id, Saler value)
        {
            Saler s = _context.SalerList.Find(s => s.Id == id);
            if (s == null)
            {
                _context.SalerList.Add(s);
            }
            else
            {
                s.Name = value.Name;
                s.Salary = value.Salary;
            };
        }
    }
}
