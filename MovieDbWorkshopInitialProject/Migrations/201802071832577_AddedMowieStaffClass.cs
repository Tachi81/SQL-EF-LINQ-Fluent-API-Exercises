namespace MovieDbWorkshop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedMowieStaffClass : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MovieStaffs",
                c => new
                    {
                        MovieId = c.Int(nullable: false),
                        PersonId = c.Int(nullable: false),
                        RoleId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.MovieId, t.PersonId, t.RoleId })
                .ForeignKey("dbo.Movies", t => t.MovieId, cascadeDelete: true)
                .ForeignKey("dbo.People", t => t.PersonId, cascadeDelete: true)
                .ForeignKey("dbo.MovieRoles", t => t.RoleId, cascadeDelete: true)
                .Index(t => t.MovieId)
                .Index(t => t.PersonId)
                .Index(t => t.RoleId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MovieStaffs", "RoleId", "dbo.MovieRoles");
            DropForeignKey("dbo.MovieStaffs", "PersonId", "dbo.People");
            DropForeignKey("dbo.MovieStaffs", "MovieId", "dbo.Movies");
            DropIndex("dbo.MovieStaffs", new[] { "RoleId" });
            DropIndex("dbo.MovieStaffs", new[] { "PersonId" });
            DropIndex("dbo.MovieStaffs", new[] { "MovieId" });
            DropTable("dbo.MovieStaffs");
        }
    }
}
