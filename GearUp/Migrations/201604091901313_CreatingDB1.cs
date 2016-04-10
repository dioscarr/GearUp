namespace GearUp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatingDB1 : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Vehicles", "makeid");
            AddForeignKey("dbo.Vehicles", "makeid", "dbo.Makes", "id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Vehicles", "makeid", "dbo.Makes");
            DropIndex("dbo.Vehicles", new[] { "makeid" });
        }
    }
}
