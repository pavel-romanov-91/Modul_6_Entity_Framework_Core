namespace Entity_Framework_Core_Part_4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Countris",
                c => new
                    {
                        CountrisId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Population = c.String(),
                    })
                .PrimaryKey(t => t.CountrisId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Countris");
        }
    }
}
