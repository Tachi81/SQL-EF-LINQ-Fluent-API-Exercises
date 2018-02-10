namespace MovieDbWorkshop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedMowieRoleClass : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MovieRoles",
                c => new
                    {
                        RoleId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.RoleId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.MovieRoles");
        }
    }
}
