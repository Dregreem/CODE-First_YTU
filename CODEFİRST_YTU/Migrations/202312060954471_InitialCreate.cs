namespace CODEFİRST_YTU.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Students",
                c => new
                {
                    ID = c.Int(nullable: false, identity: true),
                    Name = c.String(nullable: false),
                    Surname = c.String(nullable: false),
                    TC = c.String(nullable: false),
                    Address = c.String(nullable: false),
                    Password = c.Int(nullable: false),
                    Email = c.String(nullable: false),
                    Dateofentry = c.DateTime(nullable: false),
                    Faculty = c.String(),
                    Department = c.String(),
                    
                })
                .PrimaryKey(t => t.ID);

            CreateTable(
                "dbo.Academics",
                c => new
                {
                    ID = c.Int(nullable: false, identity: true),
                    Name = c.String(nullable: false),
                    Surname = c.String(nullable: false),
                    TC = c.String(nullable: false),
                    Address = c.String(nullable: false),
                    Password = c.Int(nullable: false),
                    Email = c.String(nullable: false),
                    Dateofentry = c.DateTime(nullable: false),
                    Job_Title = c.String(),
                    Facultycode = c.String(),
                    number_of_classes = c.Int(nullable: true), // Nullable property
                    Total_hours_termly = c.Int(nullable: true), // Nullable property
                    // Add other nullable properties as needed
                })
                .PrimaryKey(t => t.ID);
        }

        public override void Down()
        {
            DropTable("dbo.Students");
            DropTable("dbo.Academics");
        }
    }
}
