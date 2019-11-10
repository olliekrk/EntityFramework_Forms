namespace EntityFrameworkForms.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCustomerPassword : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Password", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "Password");
        }
    }
}
