namespace OnlineStoreSample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RecreateDBModelUsingInheritance : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Cameras", newName: "Items");
            AddColumn("dbo.Items", "Description", c => c.String());
            AddColumn("dbo.Items", "BagColor", c => c.String());
            AddColumn("dbo.Items", "BagType", c => c.String());
            AddColumn("dbo.Items", "BagSize", c => c.String());
            AddColumn("dbo.Items", "ConnectionType", c => c.String());
            AddColumn("dbo.Items", "OsCompatibility", c => c.String());
            AddColumn("dbo.Items", "DStorageType", c => c.String());
            AddColumn("dbo.Items", "DStorageSize", c => c.Int());
            AddColumn("dbo.Items", "DRAM", c => c.Int());
            AddColumn("dbo.Items", "DProcessor", c => c.String());
            AddColumn("dbo.Items", "DOperatingSystem", c => c.String());
            AddColumn("dbo.Items", "ConsoleColor", c => c.String());
            AddColumn("dbo.Items", "ConsoleStorage", c => c.Int());
            AddColumn("dbo.Items", "LStorageType", c => c.String());
            AddColumn("dbo.Items", "LStorageSize", c => c.Int());
            AddColumn("dbo.Items", "LRAM", c => c.Int());
            AddColumn("dbo.Items", "LProcessor", c => c.String());
            AddColumn("dbo.Items", "LOperatingSystem", c => c.String());
            AddColumn("dbo.Items", "LScreenSize", c => c.String());
            AddColumn("dbo.Items", "ApplianceType", c => c.String());
            AddColumn("dbo.Items", "ApplianceSize", c => c.String());
            AddColumn("dbo.Items", "DeviceSpecifications", c => c.String());
            AddColumn("dbo.Items", "DeviceType", c => c.String());
            AddColumn("dbo.Items", "DiscOrDownLoad", c => c.String());
            AddColumn("dbo.Items", "DiscType", c => c.String());
            AddColumn("dbo.Items", "MovieRating", c => c.String());
            AddColumn("dbo.Items", "SoftwareSize", c => c.Int());
            AddColumn("dbo.Items", "SoftwareOperatingSystems", c => c.String());
            AddColumn("dbo.Items", "VideoGameRating", c => c.String());
            AddColumn("dbo.Items", "VideoGameConsoleName", c => c.String());
            AddColumn("dbo.Items", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Items", "FPS", c => c.Int());
            DropTable("dbo.CarryingBags");
            DropTable("dbo.Desktops");
            DropTable("dbo.GameConsoles");
            DropTable("dbo.Laptops");
            DropTable("dbo.MajorAppliances");
            DropTable("dbo.MouseAndKeyBoards");
            DropTable("dbo.Movies");
            DropTable("dbo.Softwares");
            DropTable("dbo.VideoGames");
        }
        
        public override void Down()
        {
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
            
            AlterColumn("dbo.Items", "FPS", c => c.Int(nullable: false));
            DropColumn("dbo.Items", "Discriminator");
            DropColumn("dbo.Items", "VideoGameConsoleName");
            DropColumn("dbo.Items", "VideoGameRating");
            DropColumn("dbo.Items", "SoftwareOperatingSystems");
            DropColumn("dbo.Items", "SoftwareSize");
            DropColumn("dbo.Items", "MovieRating");
            DropColumn("dbo.Items", "DiscType");
            DropColumn("dbo.Items", "DiscOrDownLoad");
            DropColumn("dbo.Items", "DeviceType");
            DropColumn("dbo.Items", "DeviceSpecifications");
            DropColumn("dbo.Items", "ApplianceSize");
            DropColumn("dbo.Items", "ApplianceType");
            DropColumn("dbo.Items", "LScreenSize");
            DropColumn("dbo.Items", "LOperatingSystem");
            DropColumn("dbo.Items", "LProcessor");
            DropColumn("dbo.Items", "LRAM");
            DropColumn("dbo.Items", "LStorageSize");
            DropColumn("dbo.Items", "LStorageType");
            DropColumn("dbo.Items", "ConsoleStorage");
            DropColumn("dbo.Items", "ConsoleColor");
            DropColumn("dbo.Items", "DOperatingSystem");
            DropColumn("dbo.Items", "DProcessor");
            DropColumn("dbo.Items", "DRAM");
            DropColumn("dbo.Items", "DStorageSize");
            DropColumn("dbo.Items", "DStorageType");
            DropColumn("dbo.Items", "OsCompatibility");
            DropColumn("dbo.Items", "ConnectionType");
            DropColumn("dbo.Items", "BagSize");
            DropColumn("dbo.Items", "BagType");
            DropColumn("dbo.Items", "BagColor");
            DropColumn("dbo.Items", "Description");
            RenameTable(name: "dbo.Items", newName: "Cameras");
        }
    }
}
