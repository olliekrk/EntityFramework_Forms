using System;
using System.ComponentModel.DataAnnotations;

namespace EntityFrameworkForms
{
    class Customer
    {
        [Key]
        public String CompanyName { get; set; }
        public String Description { get; set; }
        public String Password { get; set; }
    }
}
