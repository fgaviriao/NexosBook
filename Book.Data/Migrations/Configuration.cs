namespace Book.Data.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<NexosBD>
    {
        public Configuration()        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(NexosBD context)
        {
            var librosAlber = new List<Book>()
            {
                new Book{ Name= "EL MITO DE SISIFO", Gender="LITERATURA", Pages= 149, Year=2018},
                new Book{ Name= "MAESTROS DE LA LITERATURA UNIVERSAL FR: FRANCIA 2", Gender="LITERATURA", Pages= 636, Year=1984},
                new Book{ Name= "LA PESTE", Gender="LITERATURA", Pages= 240, Year=2018},
            };

            var librosAlex = new List<Book>()
            {
                new Book{ Name= "LA PITNURA FRANCESA DEL SIGLO XIX", Gender="ARTES PLASTICAS", Pages= 221, Year=1957},
                new Book{ Name= "LA PINTURA INGLESA", Gender="ARTES PLASTICAS", Pages= 238, Year=1957},
                new Book{ Name= "EL RENACIMIENTO EN ITALIA", Gender="ARTES PLASTICAS", Pages= 222, Year=1957},
            };

            context.Authors.Add(new Author { Birthday = DateTime.Now, City = "Cartagena", Email = "acamus@gmail.com", Name = "ALBERT CAMUS", Books = librosAlber });
            context.Authors.Add(new Author { Birthday = DateTime.Now, City = "Cali", Email = "acirici@gmail.com", Name = "ALEXANDRE CIRICI PELLICER", Books = librosAlex });

            context.SaveChanges();
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
