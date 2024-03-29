namespace EntityFrameworkForms.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UnitpriceToMoney : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Products", "UnitsInStock", c => c.Int(nullable: false));
            AlterColumn("dbo.Products", "Unitprice", c => c.Decimal(nullable: false, storeType: "money"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "Unitprice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Products", "UnitsInStock", c => c.Decimal(nullable: false, storeType: "money"));
        }
    }
}
