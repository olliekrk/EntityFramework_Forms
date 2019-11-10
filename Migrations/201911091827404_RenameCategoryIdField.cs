namespace EntityFrameworkForms.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameCategoryIdField : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Products", new[] { "CategoryID" });
            CreateIndex("dbo.Products", "CategoryId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Products", new[] { "CategoryId" });
            CreateIndex("dbo.Products", "CategoryID");
        }
    }
}
