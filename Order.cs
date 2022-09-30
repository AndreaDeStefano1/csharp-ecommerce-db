using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace csharp_ecommerce_db
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public string Status { get; set; }

        // relazioni con customer

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        // relazioni con payment

        List<Payment> Payments { get; set; }

        // relazioni con empoloyee

        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }

        // relazioni con products

        public List<Product> ProductsInOrder { get; set; }

    }
}
