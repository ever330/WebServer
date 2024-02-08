namespace WebServer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "SignUpDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Users", "LastLoginDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.Users", "LastLoginTime");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "LastLoginTime", c => c.DateTime(nullable: false));
            DropColumn("dbo.Users", "LastLoginDate");
            DropColumn("dbo.Users", "SignUpDate");
        }
    }
}
