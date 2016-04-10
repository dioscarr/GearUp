namespace GearUp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatingDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Makes",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Logo = c.String(nullable: false),
                        BrandName = c.String(nullable: false),
                        Created = c.DateTime(nullable: false),
                        Modified = c.DateTime(nullable: false),
                        isDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Makes");
        }
    }
}
