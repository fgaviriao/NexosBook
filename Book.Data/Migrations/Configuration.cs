namespace Book.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<NexosBD>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(NexosBD context)
        {
            context.Authors.Add(new Author { Birthday = DateTime.Now, City = "Cartagena", Email = "fulano@gmail.com", Name = "fulano" });
            context.Authors.Add(new Author { Birthday = DateTime.Now, City = "Cali", Email = "mengano@gmail.com", Name = "mengano" });
            context.Authors.Add(new Author { Birthday = DateTime.Now, City = "Medellin", Email = "ana@gmail.com", Name = "ana" });
            context.Authors.Add(new Author { Birthday = DateTime.Now, City = "Bogota", Email = "maria@gmail.com", Name = "maria" });

            context.SaveChanges();
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
