using Store.Core.Entities;
using Store.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Repsitories
{
    public class BranchRepository : IBranchRepository
    {
        private readonly DataContext _context;

        public BranchRepository(DataContext context)
        {
            _context = context;
        }
        public void Delete(int id)
        {
            Branch b = _context.BranchList.Find(b => b.id == id);
            _context.BranchList.Remove(b);
        }

        public List<Branch> Get()
        {
            return _context.BranchList;
        }

        public Branch Get(int id)
        {
            return _context.BranchList.Find(b => b.id == id);
        }

        public void Post(Branch value)
        {
            _context.BranchList.Add(value);
        }

        public void Put(int id, Branch value)
        {
            Branch b = _context.BranchList.Find(b => b.id == id);
            if (b == null)
            {
                _context.BranchList.Add(b);
            }
            else
            {
                b.Street = value.Street;
                b.City = value.City;
                b.CountOfSalers = value.CountOfSalers;
            }
        }

        public void putByCity(string city, int toAdd)
        {
            foreach (Branch b in _context.BranchList)
            {
                if (b.City == city)
                {
                    b.CountOfSalers += toAdd;
                }
            }
        }
    }
}
