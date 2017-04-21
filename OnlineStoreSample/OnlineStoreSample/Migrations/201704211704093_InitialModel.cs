namespace OnlineStoreSample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cameras",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FPS = c.Int(nullable: false),
                        CameraType = c.String(),
                        Resolution = c.String(),
                        Specifications = c.String(),
                        Warranty = c.String(),
                        Name = c.String(),
                        Model = c.String(),
                        SKU = c.Int(nullable: false),
                        Price = c.Double(nullable: false),
                        Company = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CarryingBags",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Color = c.String(),
                        BagType = c.String(),
                        Size = c.String(),
                        Description = c.String(),
                        Warranty = c.String(),
                        Name = c.String(),
                        Model = c.String(),
                        SKU = c.Int(nullable: false),
                        Price = c.Double(nullable: false),
                        Company = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Desktops",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StorageType = c.String(),
                        StorageSize = c.Int(nullable: false),
                        RAM = c.Int(nullable: false),
                        Processor = c.String(),
                        OperatingSystem = c.String(),
                        Specifications = c.String(),
                        Warranty = c.String(),
                        Name = c.String(),
                        Model = c.String(),
                        SKU = c.Int(nullable: false),
                        Price = c.Double(nullable: false),
                        Company = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.GameConsoles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Color = c.String(),
                        Storage = c.Int(nullable: false),
                        Specifications = c.String(),
                        Warranty = c.String(),
                        Name = c.String(),
                        Model = c.String(),
                        SKU = c.Int(nullable: false),
                        Price = c.Double(nullable: false),
                        Company = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Laptops",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StorageType = c.String(),
                        StorageSize = c.Int(nullable: false),
                        RAM = c.Int(nullable: false),
                        Processor = c.String(),
                        OperatingSystem = c.String(),
                        ScreenSize = c.String(),
                        Specifications = c.String(),
                        Warranty = c.String(),
                        Name = c.String(),
                        Model = c.String(),
                        SKU = c.Int(nullable: false),
                        Price = c.Double(nullable: false),
                        Company = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MajorAppliances",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ApplianceType = c.String(),
                        Size = c.String(),
                        Specifications = c.String(),
                        Warranty = c.String(),
                        Name = c.String(),
                        Model = c.String(),
                        SKU = c.Int(nullable: false),
                        Price = c.Double(nullable: false),
                        Company = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MouseAndKeyBoards",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ConnectionType = c.String(),
                        OsCompatibility = c.String(),
                        Description = c.String(),
                        Warranty = c.String(),
                        Name = c.String(),
                        Model = c.String(),
                        SKU = c.Int(nullable: false),
                        Price = c.Double(nullable: false),
                        Company = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DiscType = c.String(),
                        Rating = c.String(),
                        DeviceSpecifications = c.String(),
                        DeviceType = c.String(),
                        Warranty = c.String(),
                        DiscOrDownLoad = c.String(),
                        Name = c.String(),
                        Model = c.String(),
                        SKU = c.Int(nullable: false),
                        Price = c.Double(nullable: false),
                        Company = c.String(),
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
                "dbo.Softwares",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Size = c.Int(nullable: false),
                        OperatingSystems = c.String(),
                        DeviceSpecifications = c.String(),
                        DeviceType = c.String(),
                        Warranty = c.String(),
                        DiscOrDownLoad = c.String(),
                        Name = c.String(),
                        Model = c.String(),
                        SKU = c.Int(nullable: false),
                        Price = c.Double(nullable: false),
                        Company = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
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
            
            CreateTable(
                "dbo.VideoGames",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        GameRating = c.String(),
                        ConsoleName = c.String(),
                        DeviceSpecifications = c.String(),
                        DeviceType = c.String(),
                        Warranty = c.String(),
                        DiscOrDownLoad = c.String(),
                        Name = c.String(),
                        Model = c.String(),
                        SKU = c.Int(nullable: false),
                        Price = c.Double(nullable: false),
                        Company = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropTable("dbo.VideoGames");
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.Softwares");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.Movies");
            DropTable("dbo.MouseAndKeyBoards");
            DropTable("dbo.MajorAppliances");
            DropTable("dbo.Laptops");
            DropTable("dbo.GameConsoles");
            DropTable("dbo.Desktops");
            DropTable("dbo.CarryingBags");
            DropTable("dbo.Cameras");
        }
    }
}
