namespace OrdersDemo.DataMapping.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dataMigrations : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserProfiles",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(maxLength: 50),
                        LastName = c.String(maxLength: 50),
                        UserName = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            AlterColumn("dbo.Orders", "CustomerId", c => c.Int());
            AlterColumn("dbo.OrderItems", "OrderId", c => c.Int());
            AlterColumn("dbo.OrderItems", "UnitId", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.OrderItems", "UnitId", c => c.Int());
            AlterColumn("dbo.OrderItems", "OrderId", c => c.Int());
            AlterColumn("dbo.Orders", "CustomerId", c => c.Int());
            DropTable("dbo.UserProfiles");
        }
    }
}
