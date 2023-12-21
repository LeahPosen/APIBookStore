using Store.Core.Entities;
using Store.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace Store.Data.Repsitories
{
    public class BookRepository : IBookRepository
    {
        private readonly DataContext _context;

        public BookRepository(DataContext context)
        {
            _context = context;
        }

        public List<Book> Get()
        {
            return _context.BookList;
        }

        public Book Get(int id)
        {
            return _context.BookList.Find(b => b.Code == id);
        }

        public List<Book> GetByType(Core.Entities.Type type)
        {
            return _context.BookList.Where(b => b.Type == type).ToList();
        }

        public void Delete(int id)
        {
            Book b = _context.BookList.Find(b => b.Code == id);
            _context.BookList.Remove(b);
        }

        public void Post(Book value)
        {
            _context.BookList.Add(value);
        }

        public void Put(int id, Book value)
        {
            Book b = _context.BookList.Find(b => b.Code == id);
            if (b != null)
            {
                b.Writer = value.Writer;
                b.Price = value.Price;
                b.Title = value.Title;
                b.Type = value.Type;
            }
            else
                _context.BookList.Add(value);
        }
    }
}
