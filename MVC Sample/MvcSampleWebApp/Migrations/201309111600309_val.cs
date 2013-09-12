namespace MvcSampleWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class val : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.PrintJobs", "CustomerName", c => c.String(nullable: false));
            AlterColumn("dbo.PrintJobs", "CustomerAddress", c => c.String(nullable: false));
            AlterColumn("dbo.PrintJobs", "CustomerCity", c => c.String(nullable: false));
            AlterColumn("dbo.PrintJobs", "CustomerState", c => c.String(nullable: false));
            AlterColumn("dbo.PrintJobs", "CustomerZip", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.PrintJobs", "CustomerZip", c => c.String());
            AlterColumn("dbo.PrintJobs", "CustomerState", c => c.String());
            AlterColumn("dbo.PrintJobs", "CustomerCity", c => c.String());
            AlterColumn("dbo.PrintJobs", "CustomerAddress", c => c.String());
            AlterColumn("dbo.PrintJobs", "CustomerName", c => c.String());
        }
    }
}
