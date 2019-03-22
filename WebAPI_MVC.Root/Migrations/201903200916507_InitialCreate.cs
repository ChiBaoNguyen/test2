namespace WebAPI_MVC.Root.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Category",
                c => new
                    {
                        IDCategory = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(nullable: false, maxLength: 50),
                        CategoryCreatedDate = c.DateTime(nullable: false, storeType: "date"),
                        CategoryIsActive = c.String(maxLength: 1, fixedLength: true, unicode: false),
                    })
                .PrimaryKey(t => t.IDCategory);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Category");
        }
    }
}
