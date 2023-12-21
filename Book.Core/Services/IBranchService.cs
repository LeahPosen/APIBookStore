using Store.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Core.Services
{
    public interface IBranchService
    {
        List<Branch> Get();
        Branch Get(int id);
        void Post(Branch value);
        void Put(int id, Branch value);
        void Delete(int id);
        void putByCity(string city, int toAdd);
    }
}
