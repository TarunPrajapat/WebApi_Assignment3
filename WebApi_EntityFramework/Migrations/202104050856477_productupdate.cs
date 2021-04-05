namespace WebApi_EntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class productupdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "ProductName", c => c.String(nullable: false, maxLength: 20));
            AddColumn("dbo.Products", "QntyInStock", c => c.Int(nullable: false));
            AddColumn("dbo.Products", "Suppiler", c => c.Int(nullable: false));
            DropColumn("dbo.Products", "Name");
            DropColumn("dbo.Products", "QtyInStock");
            DropColumn("dbo.Products", "Supplier");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "Supplier", c => c.Int(nullable: false));
            AddColumn("dbo.Products", "QtyInStock", c => c.Int(nullable: false));
            AddColumn("dbo.Products", "Name", c => c.String(nullable: false, maxLength: 20));
            DropColumn("dbo.Products", "Suppiler");
            DropColumn("dbo.Products", "QntyInStock");
            DropColumn("dbo.Products", "ProductName");
        }
    }
}
