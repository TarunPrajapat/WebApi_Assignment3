namespace WebApi_EntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class supplier : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Name", c => c.String(nullable: false, maxLength: 20));
            AddColumn("dbo.Products", "Supplier", c => c.Int(nullable: false));
            DropColumn("dbo.Products", "ProductName");
            DropColumn("dbo.Products", "Suppiler");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "Suppiler", c => c.Int(nullable: false));
            AddColumn("dbo.Products", "ProductName", c => c.String(nullable: false, maxLength: 20));
            DropColumn("dbo.Products", "Supplier");
            DropColumn("dbo.Products", "Name");
        }
    }
}
