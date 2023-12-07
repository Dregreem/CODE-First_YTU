using System.Data.Entity.Migrations;

public partial class CreateStudentAndAcademicTables : DbMigration
{
    public override void Up()
    {
        CreateTable(
            "dbo.Students",
            c => new
            {
                ID = c.Int(nullable: false, identity: true),
                TC = c.String(nullable: false, maxLength: 11),
                Name = c.String(nullable: false),
                Surname = c.String(nullable: false),
                Address = c.String(nullable: false),
                Email = c.String(nullable: false),
                Password = c.Int(nullable: false),
                Faculty = c.String(nullable: false),
                Department = c.String(nullable: false),
                Dateofentry = c.DateTime(nullable: false),
                
                TotalCredit = c.Int(),
                TotalAKTS = c.Int(),
                Class = c.Int(nullable: false),
            })
            .PrimaryKey(t => t.ID);

        CreateTable(
            "dbo.Academics",
            c => new
            {
                ID = c.Int(nullable: false, identity: true),
                TC = c.String(nullable: false, maxLength: 11),
                Name = c.String(nullable: false),
                Surname = c.String(nullable: false),
                Address = c.String(nullable: false),
                Email = c.String(nullable: false),
                Password = c.Int(nullable: false),
                Job_Title = c.String(),
                Facultycode = c.String(),
                number_of_classes = c.Int(nullable: false),
                Total_hours_termly = c.Int(nullable: false),
                
            })
            .PrimaryKey(t => t.ID);

    }

    public override void Down()
    {
        DropTable("dbo.Students");
        DropTable("dbo.Academics");
    }
}
