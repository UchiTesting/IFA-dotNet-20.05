namespace _200525_Exo08_Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Authors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Summary = c.String(),
                        ReleaseDate = c.DateTime(nullable: false),
                        OwnAuthor_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Authors", t => t.OwnAuthor_Id)
                .Index(t => t.OwnAuthor_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Books", "OwnAuthor_Id", "dbo.Authors");
            DropIndex("dbo.Books", new[] { "OwnAuthor_Id" });
            DropTable("dbo.Books");
            DropTable("dbo.Authors");
        }
    }
}
