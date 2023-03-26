namespace Entity_Framework_Core_Part_4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Type : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Countris", "Type", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Countris", "Type");
        }
    }
}
