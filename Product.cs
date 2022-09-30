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
    }
}