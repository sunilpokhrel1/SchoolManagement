namespace SchoolManagement.Core.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModelDateTimechanges : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Student", "ContactNumber", c => c.String(nullable: false));
            AddColumn("dbo.Student", "EmailAddress", c => c.String(nullable: false));
            AlterColumn("dbo.Student", "AddmissionDate", c => c.DateTime(nullable: false, storeType: "date"));
            DropColumn("dbo.Student", "Contact");
            DropColumn("dbo.Student", "Email");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Student", "Email", c => c.String());
            AddColumn("dbo.Student", "Contact", c => c.String());
            AlterColumn("dbo.Student", "AddmissionDate", c => c.String());
            DropColumn("dbo.Student", "EmailAddress");
            DropColumn("dbo.Student", "ContactNumber");
        }
    }
}
