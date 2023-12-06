namespace CODEFİRST_YTU.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNullableColumns : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Students", "TotalCredit", c => c.Int());
            AlterColumn("dbo.Students", "TotalAKTS", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "TotalAKTS", c => c.Int(nullable: false));
            AlterColumn("dbo.Students", "TotalCredit", c => c.Int(nullable: false));
        }
    }
}
