using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EntityFrameworkForms
{
    class Order
    {
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        [ForeignKey("Customer")]
        [Required]
        public String CustomerName { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
