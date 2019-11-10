using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameworkForms
{
    class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }

        public int UnitsInStock { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        [Column("Unitprice", TypeName = "money")]
        public decimal Unitprice { get; set; }
    }
}
