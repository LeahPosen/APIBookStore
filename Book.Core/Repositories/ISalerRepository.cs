using Store.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Core.Repositories
{
    public interface ISalerRepository
    {
        List<Saler> Get();
        Saler Get(int id);
        void Post(Saler value);
        void Put(int id,  Saler value);
        void Delete(int id);
        void DeleteBySalary(int minSalary);
    }
}
