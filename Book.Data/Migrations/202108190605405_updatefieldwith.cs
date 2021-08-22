namespace Book.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatefieldwith : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Authors", "Name", c => c.String(nullable: false, maxLength: 300));
            AlterColumn("dbo.Authors", "Email", c => c.String(nullable: false, maxLength: 300));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Authors", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.Authors", "Name", c => c.String(nullable: false));
        }
    }
}
