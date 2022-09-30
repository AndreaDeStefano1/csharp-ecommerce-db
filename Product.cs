namespace csharp_ecommerce_db
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

        // relazioni con order

        public List<Order> OrdersPlaced { get; set; }

        public static Product CreateProduct(string name, string description, double price)
        {
            Product nP = new Product();

            using (OrderContext db = new OrderContext())
            {
                nP.Name = name;
                nP.Description = description;
                nP.Price = price;

                db.Add(nP);
                db.SaveChanges();
            }
            return nP;
        }

        public static Product ReadProduct(string name)
        {
            using (OrderContext db = new OrderContext())
            {

                Product product = db.Products.Where(product => product.Name == name).First();

                return product;
            }

        }

        public string? ToString(Product p)
        {
            return $"----\n----\nNome: {Name}\nDescrizione: {Description}\nPrezzo: {Price}\n----";
        }
    }
}