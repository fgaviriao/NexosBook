using System.Collections.Generic;

namespace Book.Data.Repositories
{
    public interface IAuthorRepository
    {
        void Delete(Author data);
        IEnumerable<Author> GetAll();
        Author GetById(int id);
        void Save(Author data);
        bool SaveChanges();
        void Update(Author data);
    }
}