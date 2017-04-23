namespace OnlineStoreSample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDataAnnotationsForItemsAndDesktops : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Items", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Items", "Model", c => c.String(nullable: false));
            AlterColumn("dbo.Items", "Company", c => c.String(nullable: false));
            AlterColumn("dbo.Items", "Warranty", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Items", "Warranty", c => c.String());
            AlterColumn("dbo.Items", "Company", c => c.String());
            AlterColumn("dbo.Items", "Model", c => c.String());
            AlterColumn("dbo.Items", "Name", c => c.String());
        }
    }
}
