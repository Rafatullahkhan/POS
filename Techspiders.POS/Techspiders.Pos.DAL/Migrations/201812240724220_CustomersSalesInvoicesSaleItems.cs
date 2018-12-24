namespace Techspiders.Pos.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CustomersSalesInvoicesSaleItems : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Contact = c.Long(nullable: false),
                        Address = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SaleItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Quantity = c.Int(nullable: false),
                        PurchasePrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SalePrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        UnitDiscount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ProductsId = c.Int(nullable: false),
                        SalesInvoiceId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.ProductsId, cascadeDelete: true)
                .ForeignKey("dbo.SalesInvoices", t => t.SalesInvoiceId, cascadeDelete: true)
                .Index(t => t.ProductsId)
                .Index(t => t.SalesInvoiceId);
            
            CreateTable(
                "dbo.SalesInvoices",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Receipt = c.Int(nullable: false),
                        InvoiceDate = c.DateTime(nullable: false),
                        OrderType = c.String(nullable: false),
                        TotalBill = c.Long(nullable: false),
                        TotalDiscount = c.Long(nullable: false),
                        NetAmount = c.Long(nullable: false),
                        CustomerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .Index(t => t.CustomerId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SaleItems", "SalesInvoiceId", "dbo.SalesInvoices");
            DropForeignKey("dbo.SalesInvoices", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.SaleItems", "ProductsId", "dbo.Products");
            DropIndex("dbo.SalesInvoices", new[] { "CustomerId" });
            DropIndex("dbo.SaleItems", new[] { "SalesInvoiceId" });
            DropIndex("dbo.SaleItems", new[] { "ProductsId" });
            DropTable("dbo.SalesInvoices");
            DropTable("dbo.SaleItems");
            DropTable("dbo.Customers");
        }
    }
}
