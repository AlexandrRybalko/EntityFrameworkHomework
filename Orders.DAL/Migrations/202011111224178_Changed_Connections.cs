namespace Orders.DAL.Migrations
{
    using System;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Migrations;
    
    public partial class Changed_Connections : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Orders", "ProductId", "dbo.Products");
            DropIndex("dbo.Orders", new[] { "ProductId" });
            CreateTable(
                "dbo.OrderProducts",
                c => new
                    {
                        Order_Id = c.Int(nullable: false),
                        Product_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Order_Id, t.Product_Id })
                .ForeignKey("dbo.Orders", t => t.Order_Id, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.Product_Id, cascadeDelete: true)
                .Index(t => t.Order_Id)
                .Index(t => t.Product_Id);

            string query = "DECLARE @count INT, @c INT" + "\n" + "SET @count=(SELECT MAX(Id) FROM Orders);" + "\n" + "SET @c=1;" + "\n" + "WHILE(@c<=@count)" + "\n" 
                + "BEGIN" + "\n" + "IF EXISTS(SELECT Id FROM Orders WHERE Id=@c)" + "\n"  + "BEGIN"  + "\n" 
                + "INSERT INTO OrderProducts(Order_Id, Product_Id) VALUES((SELECT Id FROM Orders WHERE Id = @c), (SELECT ProductId FROM Orders WHERE Id = @c))"  + "\n" 
                + "END" + "\n" + "SET @c = @c + 1" + "\n" + "END";

            Sql(query); 

             DropColumn("dbo.Orders", "ProductId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Orders", "ProductId", c => c.Int(nullable: true));
            DropForeignKey("dbo.OrderProducts", "Product_Id", "dbo.Products");
            DropForeignKey("dbo.OrderProducts", "Order_Id", "dbo.Orders");
            DropIndex("dbo.OrderProducts", new[] { "Product_Id" });
            DropIndex("dbo.OrderProducts", new[] { "Order_Id" });
            DropTable("dbo.OrderProducts");
            CreateIndex("dbo.Orders", "ProductId");
            AddForeignKey("dbo.Orders", "ProductId", "dbo.Products", "Id", cascadeDelete: true);

            string query = "";
        }
    }
}
