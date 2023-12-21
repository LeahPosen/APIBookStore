using Store.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Type = Store.Core.Entities.Type;

namespace Store.Core.Services
{
    public interface IBookService
    {
        List<Book> Get();
        Book Get(int id);
        void Post(Book value);
        void Put(int id, Book value);
        void Delete(int id);
        List<Book> GetByType(Type type);
    }
}
