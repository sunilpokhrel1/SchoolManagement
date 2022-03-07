namespace SchoolManagement.Core.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DBInnitailMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Contact = c.String(),
                        Email = c.String(),
                        Address = c.String(),
                        Department = c.String(),
                        Batch = c.String(),
                        AddmissionDate = c.String(),
                        RollNo = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Students");
        }
    }
}
