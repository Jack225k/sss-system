namespace SSS_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Areas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AreaName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                        Customer_email = c.String(nullable: false),
                        Industry = c.String(),
                        Client = c.String(),
                        Contact_Name = c.String(),
                        Contact_Number = c.String(nullable: false, maxLength: 10),
                        Contact_Email = c.String(nullable: false),
                        MaintenanceContract = c.String(nullable: false),
                        ContractDuration = c.Int(nullable: false),
                        ServicesPerMonth = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ExpertiseFields",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FieldExpertise = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Installations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClientName = c.String(nullable: false),
                        BranchName = c.String(nullable: false),
                        BranchNo = c.String(nullable: false),
                        Address = c.String(nullable: false),
                        Store_Manager = c.String(nullable: false),
                        Tel = c.Double(nullable: false),
                        Fax = c.Double(),
                        Email = c.String(nullable: false),
                        Type = c.String(),
                        Antennas = c.Double(),
                        Serial = c.Double(),
                        Mental_Detector = c.String(),
                        Remote = c.String(),
                        Enterance1 = c.Int(),
                        Distance1 = c.Double(),
                        Enterance2 = c.Int(),
                        Distance2 = c.Double(),
                        Enterance3 = c.Int(),
                        Distance3 = c.Double(),
                        Enterance4 = c.Int(),
                        Distance4 = c.Double(),
                        Q1 = c.Int(nullable: false),
                        Make = c.String(),
                        Lockable = c.String(),
                        Q2 = c.Int(nullable: false),
                        Strength = c.String(),
                        TQ1 = c.Int(),
                        TType1 = c.String(),
                        TQ2 = c.Int(),
                        TType2 = c.String(),
                        TQ3 = c.Int(),
                        TType3 = c.String(),
                        TQ4 = c.Int(),
                        TType4 = c.String(),
                        Cable = c.Boolean(nullable: false),
                        Grouting = c.Boolean(nullable: false),
                        PPU = c.Boolean(nullable: false),
                        PPA = c.Boolean(nullable: false),
                        Power_Points = c.Boolean(nullable: false),
                        DB_Labelled = c.Boolean(nullable: false),
                        Comments1 = c.String(),
                        Completion = c.String(),
                        SinedC = c.String(),
                        SignedD = c.String(),
                        Screen_Shots = c.String(),
                        Staff_Training_Conduct = c.String(),
                        Comment2 = c.String(),
                        Name = c.String(nullable: false),
                        Signature = c.String(nullable: false),
                        Place = c.String(nullable: false),
                        Date = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Jobs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClientReference = c.String(nullable: false),
                        Date = c.DateTime(),
                        Client = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        ContactPerson = c.String(),
                        Telephone = c.Double(nullable: false),
                        SiteLocation = c.String(nullable: false),
                        DoorType = c.String(nullable: false),
                        Service = c.Boolean(nullable: false),
                        Callout = c.Boolean(nullable: false),
                        Installation = c.Boolean(nullable: false),
                        Supply = c.Boolean(nullable: false),
                        WCO = c.String(),
                        Reason = c.String(),
                        Comment = c.String(),
                        DateA = c.DateTime(),
                        ArrivalA = c.DateTime(),
                        DepartureA = c.DateTime(),
                        TotalA = c.Double(),
                        Travelling = c.String(),
                        Km = c.Int(),
                        TotalD = c.Double(),
                        QuanityA = c.Int(nullable: false),
                        TotalQA = c.Double(nullable: false),
                        QuanityB = c.Int(nullable: false),
                        TotalQB = c.Double(nullable: false),
                        QuanityC = c.Int(nullable: false),
                        TotalQC = c.Double(nullable: false),
                        QuanityD = c.Int(nullable: false),
                        TotalQE = c.Double(nullable: false),
                        SubTotal = c.Double(),
                        Vat = c.Double(),
                        GrandTotal = c.Double(),
                        Technican = c.String(nullable: false),
                        DateCompleted = c.DateTime(),
                        Signature = c.String(),
                        Name = c.String(nullable: false),
                        Designation = c.String(nullable: false),
                        Dater = c.DateTime(),
                        Time = c.DateTime(),
                        SignatureB = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.Stocks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SupplierId = c.Int(nullable: false),
                        ProductName = c.String(),
                        Description = c.String(),
                        CostPrice = c.Double(nullable: false),
                        SellingPrice = c.Double(nullable: false),
                        Quantity = c.Int(nullable: false),
                        Dir = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Suppliers", t => t.SupplierId, cascadeDelete: true)
                .Index(t => t.SupplierId);
            
            CreateTable(
                "dbo.Suppliers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SupplierName = c.String(),
                        SupplierContact = c.Int(nullable: false),
                        SupplierEmail = c.String(nullable: false),
                        Products = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Technicians",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TechFullName = c.String(),
                        IdNumber = c.String(),
                        ContactNumber = c.String(),
                        EmailAddress = c.String(),
                        Area = c.String(),
                        Areas_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Areas", t => t.Areas_Id)
                .Index(t => t.Areas_Id);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Technicians", "Areas_Id", "dbo.Areas");
            DropForeignKey("dbo.Stocks", "SupplierId", "dbo.Suppliers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.Technicians", new[] { "Areas_Id" });
            DropIndex("dbo.Stocks", new[] { "SupplierId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.Technicians");
            DropTable("dbo.Suppliers");
            DropTable("dbo.Stocks");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.Jobs");
            DropTable("dbo.Installations");
            DropTable("dbo.ExpertiseFields");
            DropTable("dbo.Customers");
            DropTable("dbo.Areas");
        }
    }
}
