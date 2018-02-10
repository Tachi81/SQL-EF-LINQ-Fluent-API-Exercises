namespace MovieDbWorkshop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedReview : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Reviews",
                c => new
                    {
                        ReviewId = c.Int(nullable: false, identity: true),
                        ReviewSite = c.String(),
                        ContentText = c.String(nullable: false),
                        Score = c.Int(nullable: false),
                        Author = c.String(nullable: false, maxLength: 50),
                        MovieId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ReviewId)
                .ForeignKey("dbo.Movies", t => t.MovieId, cascadeDelete: true)
                .Index(t => t.MovieId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reviews", "MovieId", "dbo.Movies");
            DropIndex("dbo.Reviews", new[] { "MovieId" });
            DropTable("dbo.Reviews");
        }
    }
}
