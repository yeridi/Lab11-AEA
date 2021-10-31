namespace CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class V3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "Active", c => c.Boolean());
        }
        
        public override void Down()
        {
            DropColumn("dbo.People", "Active");
        }
    }
}
