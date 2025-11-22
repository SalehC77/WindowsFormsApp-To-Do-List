namespace To_Do_List.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Activities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        StartDate = c.DateTime(nullable: false),
                        ExpirationDate = c.DateTime(nullable: false),
                        ActivitySite = c.String(),
                        NumberOfPeopleAllowed = c.Int(nullable: false),
                        DisabilityTypeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DisabilityTypes", t => t.DisabilityTypeId, cascadeDelete: false)
                .Index(t => t.DisabilityTypeId);
            
            CreateTable(
                "dbo.ActivityStudents",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StudentId = c.Int(nullable: false),
                        ActivityId = c.Int(nullable: false),
                        RegistrationDate = c.DateTime(nullable: false),
                        IsAccept = c.Boolean(nullable: false),
                        Notes = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Activities", t => t.ActivityId, cascadeDelete: false)
                .ForeignKey("dbo.Students", t => t.StudentId, cascadeDelete: false)
                .Index(t => t.StudentId)
                .Index(t => t.ActivityId);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PersonId = c.Int(nullable: false),
                        EducationalStage = c.String(),
                        IsAccept = c.Boolean(nullable: false),
                        DisabilityTypeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DisabilityTypes", t => t.DisabilityTypeId, cascadeDelete: false)
                .ForeignKey("dbo.People", t => t.PersonId, cascadeDelete: false)
                .Index(t => t.PersonId)
                .Index(t => t.DisabilityTypeId);
            
            CreateTable(
                "dbo.DisabilityTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FullName = c.String(),
                        Age = c.Int(nullable: false),
                        Gender = c.Boolean(nullable: false),
                        DateOfBirth = c.DateTime(nullable: false),
                        PhoneNumber = c.String(),
                        Address = c.String(),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: false)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Email = c.String(),
                        Password = c.String(),
                        IsActive = c.Boolean(nullable: false),
                        RoleId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Roles", t => t.RoleId, cascadeDelete: false)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Sessions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StaffId = c.Int(nullable: false),
                        StudentId = c.Int(nullable: false),
                        SessionDate = c.DateTime(nullable: false),
                        DurationMinutes = c.Int(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Notes = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Staffs", t => t.StaffId, cascadeDelete: false)
                .ForeignKey("dbo.Students", t => t.StudentId, cascadeDelete: false)
                .Index(t => t.StaffId)
                .Index(t => t.StudentId);
            
            CreateTable(
                "dbo.Staffs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PersonId = c.Int(nullable: false),
                        StaffTypeId = c.Int(nullable: false),
                        Salary = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Education = c.String(),
                        HireDate = c.DateTime(nullable: false),
                        Experience = c.String(),
                        NationalId = c.String(),
                        PassportNumber = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.People", t => t.PersonId, cascadeDelete: false)
                .ForeignKey("dbo.StaffTypes", t => t.StaffTypeId, cascadeDelete: false)
                .Index(t => t.PersonId)
                .Index(t => t.StaffTypeId);
            
            CreateTable(
                "dbo.StaffTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        JobTitle = c.String(),
                        JobDescription = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Donations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DonorId = c.Int(nullable: false),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Currency = c.String(),
                        DonationDate = c.DateTime(nullable: false),
                        PaymentMethod = c.String(),
                        Purpose = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Donors", t => t.DonorId, cascadeDelete: false)
                .Index(t => t.DonorId);
            
            CreateTable(
                "dbo.Donors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PersonId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.People", t => t.PersonId, cascadeDelete: false)
                .Index(t => t.PersonId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Donors", "PersonId", "dbo.People");
            DropForeignKey("dbo.Donations", "DonorId", "dbo.Donors");
            DropForeignKey("dbo.Sessions", "StudentId", "dbo.Students");
            DropForeignKey("dbo.Staffs", "StaffTypeId", "dbo.StaffTypes");
            DropForeignKey("dbo.Sessions", "StaffId", "dbo.Staffs");
            DropForeignKey("dbo.Staffs", "PersonId", "dbo.People");
            DropForeignKey("dbo.Students", "PersonId", "dbo.People");
            DropForeignKey("dbo.People", "UserId", "dbo.Users");
            DropForeignKey("dbo.Users", "RoleId", "dbo.Roles");
            DropForeignKey("dbo.Students", "DisabilityTypeId", "dbo.DisabilityTypes");
            DropForeignKey("dbo.Activities", "DisabilityTypeId", "dbo.DisabilityTypes");
            DropForeignKey("dbo.ActivityStudents", "StudentId", "dbo.Students");
            DropForeignKey("dbo.ActivityStudents", "ActivityId", "dbo.Activities");
            DropIndex("dbo.Donors", new[] { "PersonId" });
            DropIndex("dbo.Donations", new[] { "DonorId" });
            DropIndex("dbo.Staffs", new[] { "StaffTypeId" });
            DropIndex("dbo.Staffs", new[] { "PersonId" });
            DropIndex("dbo.Sessions", new[] { "StudentId" });
            DropIndex("dbo.Sessions", new[] { "StaffId" });
            DropIndex("dbo.Users", new[] { "RoleId" });
            DropIndex("dbo.People", new[] { "UserId" });
            DropIndex("dbo.Students", new[] { "DisabilityTypeId" });
            DropIndex("dbo.Students", new[] { "PersonId" });
            DropIndex("dbo.ActivityStudents", new[] { "ActivityId" });
            DropIndex("dbo.ActivityStudents", new[] { "StudentId" });
            DropIndex("dbo.Activities", new[] { "DisabilityTypeId" });
            DropTable("dbo.Donors");
            DropTable("dbo.Donations");
            DropTable("dbo.StaffTypes");
            DropTable("dbo.Staffs");
            DropTable("dbo.Sessions");
            DropTable("dbo.Roles");
            DropTable("dbo.Users");
            DropTable("dbo.People");
            DropTable("dbo.DisabilityTypes");
            DropTable("dbo.Students");
            DropTable("dbo.ActivityStudents");
            DropTable("dbo.Activities");
        }
    }
}
