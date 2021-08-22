namespace Book.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class book_rename_field : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Books", name: "AutorId", newName: "AuthorId");
            RenameIndex(table: "dbo.Books", name: "IX_AutorId", newName: "IX_AuthorId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Books", name: "IX_AuthorId", newName: "IX_AutorId");
            RenameColumn(table: "dbo.Books", name: "AuthorId", newName: "AutorId");
        }
    }
}
