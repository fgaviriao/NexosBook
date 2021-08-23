using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Data.Repositories
{
    public class BookConfigurationRepository : IBookConfigurationRepository
    {
        private readonly NexosBD _nexosDb;

        public BookConfigurationRepository(NexosBD nexosDb)
        {
            _nexosDb = nexosDb;
        }

        public BookConfiguration GetConfiguration()
        {
            var row = _nexosDb.BookConfiguration.FirstOrDefault() ?? null;

            if (row != null)
            {
                return row;
            }

            BookConfiguration newconfiguration = new BookConfiguration() { MaxBookByAuthor = 3 };
            _nexosDb.BookConfiguration.Add(newconfiguration);
            _nexosDb.SaveChanges();
            return newconfiguration;
        }
        public bool SaveChanges()
        {
            return _nexosDb.SaveChanges() >= 0;
        }
        public void Update(BookConfiguration data)
        {
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }
            _nexosDb.Entry(data).State = EntityState.Modified;

        }
    }
}
