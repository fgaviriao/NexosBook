using System.Collections.Generic;

namespace Book.Data.Repositories
{
    public interface IBookRepository
    {
        void Delete(Book data);
        IEnumerable<Book> GetAll();
        IEnumerable<Book> GetAllByAuthorId(int id);
        Book GetById(int id);
        void Save(Book data);
        bool SaveChanges();
        void Update(Book data);
    }
}