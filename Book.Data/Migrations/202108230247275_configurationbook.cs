namespace Book.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class configurationbook : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BookConfigurations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MaxBookByAuthor = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.BookConfigurations");
        }
    }
}
