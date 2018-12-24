using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Techspiders.Pos.DAL.Entities
{
    class SaleItems
    {
        public int Id { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public decimal PurchasePrice { get; set; }
        [Required]
        public decimal SalePrice { get; set; }
        public decimal UnitDiscount { get; set; }
        [ForeignKey("Products")]
        public int ProductsId { get; set; }
        [ForeignKey("SalesInvoice")]
        public int SalesInvoiceId { get; set; }


        public Products Products { get; set; }
        public SalesInvoice SalesInvoice { get; set; }
    }
}
