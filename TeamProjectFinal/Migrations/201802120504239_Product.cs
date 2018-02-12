namespace TeamProjectFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Product : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductId = c.Int(nullable: false, identity: true),
                        DateTimeProductPosted = c.DateTime(nullable: false),
                        ProductName = c.String(nullable: false, maxLength: 100),
                        Price = c.Double(nullable: false),
                        Category = c.String(nullable: false),
                        Description = c.String(nullable: false),
                        Owner = c.String(maxLength: 90),
                        PhoneNumber = c.String(),
                        EmailAddress = c.String(),
                    })
                .PrimaryKey(t => t.ProductId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Products");
        }
    }
}
