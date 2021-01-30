namespace EFCrudDEMO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Calls",
                c => new
                    {
                        CallID = c.Int(nullable: false, identity: true),
                        MobileNumber = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.CallID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Calls");
        }
    }
}
