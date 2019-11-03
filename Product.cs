using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameworkForms
{
    class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }

        [Column("UnitsInStock", TypeName="money")]
        public int UnitsInStock { get; set; }

        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }

        public decimal Unitprice { get; set; }
    }
}
