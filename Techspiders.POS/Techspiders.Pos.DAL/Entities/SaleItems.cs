using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Techspiders.Pos.DAL.Entities
{
    public class SaleItems
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
        public int ProductId { get; set; }
        [ForeignKey("SalesInvoice")]
        public int SaleInvoiceId { get; set; }


        public Products Products { get; set; }
        public SalesInvoice SalesInvoice { get; set; }
    }
}
