using Store.Core.Entities;
using Store.Core.Repositories;
using Store.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Service
{
    public class SalerService : ISalerSrevice
    {
        private readonly ISalerRepository _salerRepository;
        public SalerService(ISalerRepository salerRepository)
        {
            _salerRepository = salerRepository; 
        }

        public void Delete(int id)
        {
            _salerRepository.Delete(id);        }

        public void DeleteBySalary(int minSalary)
        {
            _salerRepository.DeleteBySalary(minSalary);        }

        public List<Saler> Get()
        {
            return _salerRepository.Get();
        }

        public Saler Get(int id)
        {
            return _salerRepository.Get(id);    
        }

        public void Post(Saler value)
        {
            _salerRepository.Post(value);   
        }

        public void Put(int id, Saler value)
        {
            _salerRepository.Put(id, value);
        }
    }
}
