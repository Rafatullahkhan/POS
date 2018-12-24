using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Techspiders.Pos.DAL.Entities
{
    public class SalesInvoice
    {
        public int  Id{ get; set; }
        [Required]
        public int Receipt { get; set; }
        [Required]
        public DateTime InvoiceDate { get; set; }
        [Required]
        public string OrderType { get; set; }
        [Required]
        public long TotalBill { get; set; }
        [Required]
        public long TotalDiscount { get; set; }
        [Required]
        public long NetAmount { get; set; }
        [ForeignKey("Customers")]
        public int CustomerId { get; set; }
        public Customers Customers { get; set; }
    }
}
