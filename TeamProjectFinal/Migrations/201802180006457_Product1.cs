namespace TeamProjectFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Product1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Products", "DateTimeProductPosted");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "DateTimeProductPosted", c => c.DateTime(nullable: false));
        }
    }
}
