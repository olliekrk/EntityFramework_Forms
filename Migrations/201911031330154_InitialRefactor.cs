namespace EntityFrameworkForms.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialRefactor : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Products", "Unitprice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "Unitprice", c => c.Decimal(nullable: false, storeType: "money"));
        }
    }
}
