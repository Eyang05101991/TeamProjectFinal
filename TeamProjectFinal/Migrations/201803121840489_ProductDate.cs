namespace TeamProjectFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProductDate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "DatePosted", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "DatePosted");
        }
    }
}
