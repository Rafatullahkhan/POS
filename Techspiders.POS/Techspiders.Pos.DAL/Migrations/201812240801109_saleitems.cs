namespace Techspiders.Pos.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class saleitems : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.SaleItems", name: "ProductsId", newName: "ProductId");
            RenameColumn(table: "dbo.SaleItems", name: "SalesInvoiceId", newName: "SaleInvoiceId");
            RenameIndex(table: "dbo.SaleItems", name: "IX_ProductsId", newName: "IX_ProductId");
            RenameIndex(table: "dbo.SaleItems", name: "IX_SalesInvoiceId", newName: "IX_SaleInvoiceId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.SaleItems", name: "IX_SaleInvoiceId", newName: "IX_SalesInvoiceId");
            RenameIndex(table: "dbo.SaleItems", name: "IX_ProductId", newName: "IX_ProductsId");
            RenameColumn(table: "dbo.SaleItems", name: "SaleInvoiceId", newName: "SalesInvoiceId");
            RenameColumn(table: "dbo.SaleItems", name: "ProductId", newName: "ProductsId");
        }
    }
}
