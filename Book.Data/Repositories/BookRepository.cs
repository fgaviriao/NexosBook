using Book.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Data.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly NexosBD _nexosDb;

        public BookRepository(NexosBD nexosDb)
        {
            _nexosDb = nexosDb;
        }

        public bool SaveChanges()
        {
            return _nexosDb.SaveChanges() >= 0;
        }

        public IEnumerable<Book> GetAll()
        {
            return _nexosDb.Books.ToList();
        }
        public IEnumerable<Book> GetAllByAuthorId(int id)
        {
            return _nexosDb.Books.Where(c=>c.AuthorId == id).ToList();
        }

        public Book GetById(int id)
        {
            return _nexosDb.Books.FirstOrDefault(c => c.Id == id);
        }

        public void Save(Book data)
        {
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }
            _nexosDb.Books.Add(data);
        }

        public void Delete(Book data)
        {
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }
            _nexosDb.Books.Remove(data);
        }

        public void DeleteByAuthorId(int id)
        {
            if (id == 0)
            {
                throw new ArgumentException("El id del author no puede ser cero.");
            }
            
            var rows = _nexosDb.Books.Where(c => c.AuthorId == id);
            if(rows != null && rows.Count() > 0)
            {
                _nexosDb.Books.RemoveRange(rows);
            }
        }

        public void Update(Book data)
        {
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }
            _nexosDb.Entry(data).State = EntityState.Modified;
        }
    }
}
