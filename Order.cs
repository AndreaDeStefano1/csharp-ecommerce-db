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

        public List<Payment> Payments { get; set; }

        // relazioni con empoloyee

        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }

        // relazioni con products

        public List<Product> ProductsInOrder { get; set; } = new List<Product>();

        public static void AddProductToOrder(Customer c, List<Product> cart)
        {
            double total = 0;
            foreach (Product product in cart)
            {
                total += product.Price;
            }
            using (OrderContext db = new OrderContext())
            {
 
                //prendo un employee a caso
                Employee e = (from s in db.Employees
                              where s.EmployeeId == 1
                              select s).First<Employee>();

                //SOLUZIONE

                //Customer c = (from s in db.Customers
                //              where s.Email == "m"
                //              select s).First<Customer>();
                //List<Product> products = new List<Product>();
                //Product p = (from s in db.Products
                //             where s.Name == "tonno"
                //             select s).First<Product>();
                //products.Add(p);

                Console.WriteLine(e.ToString());
                Order newOrder = new Order
                {
                    Date = DateTime.Now,
                    Amount = total,
                    Status = "Recived",
                    Customer = c,
                    Employee = e,
                    ProductsInOrder = cart
                };


                db.Orders.Add(newOrder);

                Payment payment = new Payment { Date = DateTime.Now, Amount = total, Status = "Working" };
                payment.Order = newOrder;

             

                db.Payments.Add(payment);


                db.SaveChanges();


            }

        }
    }
}
