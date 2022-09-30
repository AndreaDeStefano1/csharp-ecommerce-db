namespace csharp_ecommerce_db
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }

        List<Order> Orders { get; set; }


        public static Customer CreateCustomer(string name, string surname, string email)
        {
            Customer nC = new Customer();

            using (OrderContext db = new OrderContext())
            {
                nC.Name = name;
                nC.Surname = surname;
                nC.Email = email;

                db.Add(nC);
                db.SaveChanges();
            }
            return nC;
        }

        public static void UpdateCustomer(string email)
        {

            using (OrderContext db = new OrderContext())
            {
                Customer c = (from s in db.Customers
                               where s.Email == email
                               select s).First<Customer>();


                c.Name = Utility.ValueChange(c.Name); 
                c.Surname = Utility.ValueChange(c.Surname);
                c.Email = Utility.ValueChange(c.Email);

                db.SaveChanges();
            }
        }

        public string ToString(Customer c)
        {
            
            return $"----\n----\nNome: {c.Name}\nCognome: {c.Surname}\nEmail: {c.Email}\n----";
        }
        public static Customer ReadCustomer(string email)
        {
            using (OrderContext db = new OrderContext())
            {

                Customer c = db.Customers.Where(Customer => Customer.Email == email).First();

                return c;
            }

        }

    }
}