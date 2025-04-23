namespace DevExpressProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Country", c => c.String());
            AddColumn("dbo.Customers", "Province", c => c.String());
            AddColumn("dbo.Customers", "District", c => c.String());
            AddColumn("dbo.Customers", "Address", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "Address");
            DropColumn("dbo.Customers", "District");
            DropColumn("dbo.Customers", "Province");
            DropColumn("dbo.Customers", "Country");
        }
    }
}
