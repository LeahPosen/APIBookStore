using Store.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Core.Services
{
    public interface ISalerSrevice
    {
        List<Saler> Get();
        Saler Get(int id);
        void Post(Saler value);
        void Put(int id, Saler value);
        void Delete(int id);
        void DeleteBySalary(int minSalary);
    }
}
