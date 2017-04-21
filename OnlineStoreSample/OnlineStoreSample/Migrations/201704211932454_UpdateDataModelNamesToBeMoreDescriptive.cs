namespace OnlineStoreSample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDataModelNamesToBeMoreDescriptive : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Items", "AccessoryDescription", c => c.String());
            AddColumn("dbo.Items", "MouseAndKeyBoardConnectionType", c => c.String());
            AddColumn("dbo.Items", "MouseAndKeyBoardOsCompatibility", c => c.String());
            AddColumn("dbo.Items", "ElectronicSpecifications", c => c.String());
            AddColumn("dbo.Items", "CameraFPS", c => c.Int());
            AddColumn("dbo.Items", "CameraResolution", c => c.String());
            AddColumn("dbo.Items", "DesktopStorageType", c => c.String());
            AddColumn("dbo.Items", "DesktopStorageSize", c => c.Int());
            AddColumn("dbo.Items", "DesktopRAM", c => c.Int());
            AddColumn("dbo.Items", "DesktopProcessor", c => c.String());
            AddColumn("dbo.Items", "DesktopOperatingSystem", c => c.String());
            AddColumn("dbo.Items", "GameConsoleColor", c => c.String());
            AddColumn("dbo.Items", "GameConsoleStorage", c => c.Int());
            AddColumn("dbo.Items", "LaptopStorageType", c => c.String());
            AddColumn("dbo.Items", "LaptopStorageSize", c => c.Int());
            AddColumn("dbo.Items", "LaptopRAM", c => c.Int());
            AddColumn("dbo.Items", "LaptopProcessor", c => c.String());
            AddColumn("dbo.Items", "LaptopOperatingSystem", c => c.String());
            AddColumn("dbo.Items", "LaptopScreenSize", c => c.String());
            AddColumn("dbo.Items", "MajorApplianceType", c => c.String());
            AddColumn("dbo.Items", "MajorApplianceSize", c => c.String());
            AddColumn("dbo.Items", "MediaDeviceSpecifications", c => c.String());
            AddColumn("dbo.Items", "MeidaDeviceType", c => c.String());
            AddColumn("dbo.Items", "MediaDiscOrDownLoad", c => c.String());
            AddColumn("dbo.Items", "MovieDiscType", c => c.String());
            DropColumn("dbo.Items", "Description");
            DropColumn("dbo.Items", "ConnectionType");
            DropColumn("dbo.Items", "OsCompatibility");
            DropColumn("dbo.Items", "Specifications");
            DropColumn("dbo.Items", "FPS");
            DropColumn("dbo.Items", "Resolution");
            DropColumn("dbo.Items", "DStorageType");
            DropColumn("dbo.Items", "DStorageSize");
            DropColumn("dbo.Items", "DRAM");
            DropColumn("dbo.Items", "DProcessor");
            DropColumn("dbo.Items", "DOperatingSystem");
            DropColumn("dbo.Items", "ConsoleColor");
            DropColumn("dbo.Items", "ConsoleStorage");
            DropColumn("dbo.Items", "LStorageType");
            DropColumn("dbo.Items", "LStorageSize");
            DropColumn("dbo.Items", "LRAM");
            DropColumn("dbo.Items", "LProcessor");
            DropColumn("dbo.Items", "LOperatingSystem");
            DropColumn("dbo.Items", "LScreenSize");
            DropColumn("dbo.Items", "ApplianceType");
            DropColumn("dbo.Items", "ApplianceSize");
            DropColumn("dbo.Items", "DeviceSpecifications");
            DropColumn("dbo.Items", "DeviceType");
            DropColumn("dbo.Items", "DiscOrDownLoad");
            DropColumn("dbo.Items", "DiscType");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Items", "DiscType", c => c.String());
            AddColumn("dbo.Items", "DiscOrDownLoad", c => c.String());
            AddColumn("dbo.Items", "DeviceType", c => c.String());
            AddColumn("dbo.Items", "DeviceSpecifications", c => c.String());
            AddColumn("dbo.Items", "ApplianceSize", c => c.String());
            AddColumn("dbo.Items", "ApplianceType", c => c.String());
            AddColumn("dbo.Items", "LScreenSize", c => c.String());
            AddColumn("dbo.Items", "LOperatingSystem", c => c.String());
            AddColumn("dbo.Items", "LProcessor", c => c.String());
            AddColumn("dbo.Items", "LRAM", c => c.Int());
            AddColumn("dbo.Items", "LStorageSize", c => c.Int());
            AddColumn("dbo.Items", "LStorageType", c => c.String());
            AddColumn("dbo.Items", "ConsoleStorage", c => c.Int());
            AddColumn("dbo.Items", "ConsoleColor", c => c.String());
            AddColumn("dbo.Items", "DOperatingSystem", c => c.String());
            AddColumn("dbo.Items", "DProcessor", c => c.String());
            AddColumn("dbo.Items", "DRAM", c => c.Int());
            AddColumn("dbo.Items", "DStorageSize", c => c.Int());
            AddColumn("dbo.Items", "DStorageType", c => c.String());
            AddColumn("dbo.Items", "Resolution", c => c.String());
            AddColumn("dbo.Items", "FPS", c => c.Int());
            AddColumn("dbo.Items", "Specifications", c => c.String());
            AddColumn("dbo.Items", "OsCompatibility", c => c.String());
            AddColumn("dbo.Items", "ConnectionType", c => c.String());
            AddColumn("dbo.Items", "Description", c => c.String());
            DropColumn("dbo.Items", "MovieDiscType");
            DropColumn("dbo.Items", "MediaDiscOrDownLoad");
            DropColumn("dbo.Items", "MeidaDeviceType");
            DropColumn("dbo.Items", "MediaDeviceSpecifications");
            DropColumn("dbo.Items", "MajorApplianceSize");
            DropColumn("dbo.Items", "MajorApplianceType");
            DropColumn("dbo.Items", "LaptopScreenSize");
            DropColumn("dbo.Items", "LaptopOperatingSystem");
            DropColumn("dbo.Items", "LaptopProcessor");
            DropColumn("dbo.Items", "LaptopRAM");
            DropColumn("dbo.Items", "LaptopStorageSize");
            DropColumn("dbo.Items", "LaptopStorageType");
            DropColumn("dbo.Items", "GameConsoleStorage");
            DropColumn("dbo.Items", "GameConsoleColor");
            DropColumn("dbo.Items", "DesktopOperatingSystem");
            DropColumn("dbo.Items", "DesktopProcessor");
            DropColumn("dbo.Items", "DesktopRAM");
            DropColumn("dbo.Items", "DesktopStorageSize");
            DropColumn("dbo.Items", "DesktopStorageType");
            DropColumn("dbo.Items", "CameraResolution");
            DropColumn("dbo.Items", "CameraFPS");
            DropColumn("dbo.Items", "ElectronicSpecifications");
            DropColumn("dbo.Items", "MouseAndKeyBoardOsCompatibility");
            DropColumn("dbo.Items", "MouseAndKeyBoardConnectionType");
            DropColumn("dbo.Items", "AccessoryDescription");
        }
    }
}
