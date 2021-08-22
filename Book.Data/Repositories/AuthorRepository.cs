using Book.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Data.Repositories
{ 
    public class AuthorRepository : IAuthorRepository
    {
        private readonly NexosBD _nexosDb;

        public AuthorRepository(NexosBD nexosDb)
        {
            _nexosDb = nexosDb;
        }

        public bool SaveChanges()
        {
            return _nexosDb.SaveChanges() >= 0;
        }

        public IEnumerable<Author> GetAll()
        {
            return _nexosDb.Authors.ToList();
        }

        public Author GetById(int id)
        {
            return _nexosDb.Authors.FirstOrDefault(c => c.Id == id);
        }

        public void Save(Author data)
        {
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }
            _nexosDb.Authors.Add(data);
        }

        public void Delete(Author data)
        {
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }
            _nexosDb.Authors.Remove(data);
        }

        public void Update(Author data)
        {
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }
            _nexosDb.Entry(data).State = EntityState.Modified;
        }
    }
}
