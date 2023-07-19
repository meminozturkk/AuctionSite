namespace AuctionSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.AuctionItems", "UserId", c => c.Int(nullable: false));
            CreateIndex("dbo.AuctionItems", "CategoryId");
            CreateIndex("dbo.AuctionItems", "UserId");
            AddForeignKey("dbo.AuctionItems", "CategoryId", "dbo.Categories", "Id", cascadeDelete: true);
            AddForeignKey("dbo.AuctionItems", "UserId", "dbo.Users", "Id", cascadeDelete: true);
            DropColumn("dbo.AuctionItems", "SellerId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AuctionItems", "SellerId", c => c.Int(nullable: false));
            DropForeignKey("dbo.AuctionItems", "UserId", "dbo.Users");
            DropForeignKey("dbo.AuctionItems", "CategoryId", "dbo.Categories");
            DropIndex("dbo.AuctionItems", new[] { "UserId" });
            DropIndex("dbo.AuctionItems", new[] { "CategoryId" });
            DropColumn("dbo.AuctionItems", "UserId");
            DropTable("dbo.Users");
            DropTable("dbo.Categories");
        }
    }
}
