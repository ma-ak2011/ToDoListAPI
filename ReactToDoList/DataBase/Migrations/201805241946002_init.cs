namespace DataBase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ToDoes",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 50),
                        Content = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Title);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.ToDoes", new[] { "Title" });
            DropTable("dbo.ToDoes");
        }
    }
}
