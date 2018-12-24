using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Techspiders.Pos.DAL.Entities
{
    public class Products
    {
        public int Id{ get; set; }
        [Required][MaxLength(100)]
        public string Name{ get; set; }
        [Required]
        public long BarCode{ get; set; }
        [Required]
        public  byte[] Image{ get; set; }
        [Required]
        public int Quantity{ get; set; }
        [Required]
        public decimal PurchasePrice{ get; set; }
        [Required]
        public decimal SalePrice { get; set; }
        [Required]
        public decimal PurchaseDiscount { get; set; }
        [Required]
        public decimal SaleDiscount { get; set; }
        [ForeignKey("Category")]
        public int CategoryId { get; set; }

        public Category Category { get; set; }

    }
}
