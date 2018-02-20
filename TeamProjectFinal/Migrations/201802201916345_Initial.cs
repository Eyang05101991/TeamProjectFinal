namespace TeamProjectFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductId = c.Int(nullable: false, identity: true),
                        ProductName = c.String(nullable: false, maxLength: 100),
                        Price = c.Double(nullable: false),
                        Category = c.String(nullable: false),
                        Description = c.String(nullable: false),
                        Owner = c.String(maxLength: 90),
                        PhoneNumber = c.String(),
                        EmailAddress = c.String(),
                    })
                .PrimaryKey(t => t.ProductId);
            
            CreateTable(
                "dbo.Subscribers",
                c => new
                    {
                        SubscriberId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 40),
                        Lastname = c.String(nullable: false, maxLength: 40),
                        EmailAddress = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.SubscriberId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Subscribers");
            DropTable("dbo.Products");
        }
    }
}
