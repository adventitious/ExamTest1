namespace examTest1Sol.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddShirtSize : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Teams", "ShirtSize", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Teams", "ShirtSize");
        }
    }
}
