#define NOdb_pruebas
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Data
{
    public class NexosBD: DbContext
    {
        public NexosBD(string conectionstring) : base(conectionstring)
        {
#if db_pruebas
            Database.SetInitializer<NexosBD>(new DropCreateDatabaseIfModelChanges<NexosBD>());
#endif
        }
        public NexosBD():base("NexosString")
        {

        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<BookConfiguration> BookConfiguration { get; set; }

    }
}
