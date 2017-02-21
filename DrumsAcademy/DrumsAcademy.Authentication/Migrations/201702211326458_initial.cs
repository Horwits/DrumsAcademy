using System.Data.Entity.Migrations;

namespace DrumsAcademy.Authentication.Migrations
{
    public partial class initial : DbMigration
    {
        public override void Down()
        {
            this.AlterColumn("dbo.AspNetUsers", "Image", c => c.Binary(nullable: false));
        }

        public override void Up()
        {
            this.AlterColumn("dbo.AspNetUsers", "Image", c => c.Binary());
        }
    }
}