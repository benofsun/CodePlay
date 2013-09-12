namespace MvcSampleWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PrintJobs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        AffiliateID = c.Int(nullable: false),
                        CustomerName = c.String(nullable: false),
                        CustomerAddress = c.String(nullable: false),
                        CustomerCity = c.String(nullable: false),
                        CustomerState = c.String(nullable: false),
                        CustomerZip = c.String(nullable: false),
                        JobSubmitDate = c.DateTime(nullable: false),
                        JobEstCompleteDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PrintJobs");
        }
    }
}
