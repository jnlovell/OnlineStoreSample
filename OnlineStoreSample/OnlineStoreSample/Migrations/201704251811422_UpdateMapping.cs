namespace OnlineStoreSample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMapping : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Items", name: "BagColor", newName: "BagColor1");
            RenameColumn(table: "dbo.Items", name: "BagType", newName: "BagType1");
            RenameColumn(table: "dbo.Items", name: "BagSize", newName: "BagSize1");
            RenameColumn(table: "dbo.Items", name: "MouseAndKeyBoardConnectionType", newName: "MouseAndKeyBoardConnectionType1");
            RenameColumn(table: "dbo.Items", name: "MouseAndKeyBoardOsCompatibility", newName: "MouseAndKeyBoardOsCompatibility1");
            RenameColumn(table: "dbo.Items", name: "CameraFPS", newName: "CameraFPS1");
            RenameColumn(table: "dbo.Items", name: "CameraType", newName: "CameraType1");
            RenameColumn(table: "dbo.Items", name: "CameraResolution", newName: "CameraResolution1");
            RenameColumn(table: "dbo.Items", name: "DesktopStorageType", newName: "DesktopStorageType1");
            RenameColumn(table: "dbo.Items", name: "DesktopStorageSize", newName: "DesktopStorageSize1");
            RenameColumn(table: "dbo.Items", name: "DesktopRAM", newName: "DesktopRAM1");
            RenameColumn(table: "dbo.Items", name: "DesktopProcessor", newName: "DesktopProcessor1");
            RenameColumn(table: "dbo.Items", name: "DesktopOperatingSystem", newName: "DesktopOperatingSystem1");
            RenameColumn(table: "dbo.Items", name: "GameConsoleColor", newName: "GameConsoleColor1");
            RenameColumn(table: "dbo.Items", name: "GameConsoleStorage", newName: "GameConsoleStorage1");
            RenameColumn(table: "dbo.Items", name: "LaptopStorageType", newName: "LaptopStorageType1");
            RenameColumn(table: "dbo.Items", name: "LaptopStorageSize", newName: "LaptopStorageSize1");
            RenameColumn(table: "dbo.Items", name: "LaptopRAM", newName: "LaptopRAM1");
            RenameColumn(table: "dbo.Items", name: "LaptopProcessor", newName: "LaptopProcessor1");
            RenameColumn(table: "dbo.Items", name: "LaptopOperatingSystem", newName: "LaptopOperatingSystem1");
            RenameColumn(table: "dbo.Items", name: "LaptopScreenSize", newName: "LaptopScreenSize1");
            RenameColumn(table: "dbo.Items", name: "MajorApplianceType", newName: "MajorApplianceType1");
            RenameColumn(table: "dbo.Items", name: "MajorApplianceSize", newName: "MajorApplianceSize1");
            RenameColumn(table: "dbo.Items", name: "MovieDiscType", newName: "MovieDiscType1");
            RenameColumn(table: "dbo.Items", name: "MovieRating", newName: "MovieRating1");
            RenameColumn(table: "dbo.Items", name: "SoftwareSize", newName: "SoftwareSize1");
            RenameColumn(table: "dbo.Items", name: "SoftwareOperatingSystems", newName: "SoftwareOperatingSystems1");
            RenameColumn(table: "dbo.Items", name: "VideoGameRating", newName: "VideoGameRating1");
            RenameColumn(table: "dbo.Items", name: "VideoGameConsoleName", newName: "VideoGameConsoleName1");
        }
        
        public override void Down()
        {
            RenameColumn(table: "dbo.Items", name: "VideoGameConsoleName1", newName: "VideoGameConsoleName");
            RenameColumn(table: "dbo.Items", name: "VideoGameRating1", newName: "VideoGameRating");
            RenameColumn(table: "dbo.Items", name: "SoftwareOperatingSystems1", newName: "SoftwareOperatingSystems");
            RenameColumn(table: "dbo.Items", name: "SoftwareSize1", newName: "SoftwareSize");
            RenameColumn(table: "dbo.Items", name: "MovieRating1", newName: "MovieRating");
            RenameColumn(table: "dbo.Items", name: "MovieDiscType1", newName: "MovieDiscType");
            RenameColumn(table: "dbo.Items", name: "MajorApplianceSize1", newName: "MajorApplianceSize");
            RenameColumn(table: "dbo.Items", name: "MajorApplianceType1", newName: "MajorApplianceType");
            RenameColumn(table: "dbo.Items", name: "LaptopScreenSize1", newName: "LaptopScreenSize");
            RenameColumn(table: "dbo.Items", name: "LaptopOperatingSystem1", newName: "LaptopOperatingSystem");
            RenameColumn(table: "dbo.Items", name: "LaptopProcessor1", newName: "LaptopProcessor");
            RenameColumn(table: "dbo.Items", name: "LaptopRAM1", newName: "LaptopRAM");
            RenameColumn(table: "dbo.Items", name: "LaptopStorageSize1", newName: "LaptopStorageSize");
            RenameColumn(table: "dbo.Items", name: "LaptopStorageType1", newName: "LaptopStorageType");
            RenameColumn(table: "dbo.Items", name: "GameConsoleStorage1", newName: "GameConsoleStorage");
            RenameColumn(table: "dbo.Items", name: "GameConsoleColor1", newName: "GameConsoleColor");
            RenameColumn(table: "dbo.Items", name: "DesktopOperatingSystem1", newName: "DesktopOperatingSystem");
            RenameColumn(table: "dbo.Items", name: "DesktopProcessor1", newName: "DesktopProcessor");
            RenameColumn(table: "dbo.Items", name: "DesktopRAM1", newName: "DesktopRAM");
            RenameColumn(table: "dbo.Items", name: "DesktopStorageSize1", newName: "DesktopStorageSize");
            RenameColumn(table: "dbo.Items", name: "DesktopStorageType1", newName: "DesktopStorageType");
            RenameColumn(table: "dbo.Items", name: "CameraResolution1", newName: "CameraResolution");
            RenameColumn(table: "dbo.Items", name: "CameraType1", newName: "CameraType");
            RenameColumn(table: "dbo.Items", name: "CameraFPS1", newName: "CameraFPS");
            RenameColumn(table: "dbo.Items", name: "MouseAndKeyBoardOsCompatibility1", newName: "MouseAndKeyBoardOsCompatibility");
            RenameColumn(table: "dbo.Items", name: "MouseAndKeyBoardConnectionType1", newName: "MouseAndKeyBoardConnectionType");
            RenameColumn(table: "dbo.Items", name: "BagSize1", newName: "BagSize");
            RenameColumn(table: "dbo.Items", name: "BagType1", newName: "BagType");
            RenameColumn(table: "dbo.Items", name: "BagColor1", newName: "BagColor");
        }
    }
}
