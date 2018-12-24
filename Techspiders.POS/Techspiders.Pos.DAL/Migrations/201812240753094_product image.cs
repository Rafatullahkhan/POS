namespace Techspiders.Pos.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class productimage : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Products", "Image", c => c.Binary(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "Image", c => c.Byte(nullable: false));
        }
    }
}
