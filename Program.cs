using csharp_ecommerce_db;
using System.Xml.Linq;
//DefaultProduct();
//void DefaultProduct()
//{
//    using(OrderContext db = new OrderContext()) {
//        Product newProduct1 = new Product { Name = "Scatola", Description = "La scatola di pandora", Price = 15 };
//        Product newProduct2 = new Product { Name = "Tonno", Description = "Tonno in scatola", Price = 10 };
//        Product newProduct3 = new Product { Name = "Cicca", Description = "Sigaretta", Price = 20 };

//        db.Add(newProduct1);
//        db.Add(newProduct2);
//        db.Add(newProduct3);

//        db.SaveChanges();
//    }
        
//}

bool exit = false;

while (!exit)
{
    Console.Clear();
    Utility.MenuOptions();

    int choice = Convert.ToInt32(Utility.StringInput("Cosa vuoi fare:"));
    switch (choice)
    {

        case 1:
            Console.Clear();

            Console.WriteLine("1-Aggiungi nuovo\n2-Modifica\n3-Visualizza\n4-Elimina");
            bool CusExit = false;
            while (!CusExit)
            {
                int CusChoice = Convert.ToInt32(Utility.StringInput("Cosa vuoi fare:"));
                switch (CusChoice)
                {
                    case 1:
                        Customer nC = Customer.CreateCustomer(Utility.StringInput("Nome:"), Utility.StringInput("Cognome"), Utility.StringInput("Email:"));
                        Console.WriteLine(nC.ToString(nC));
                        break;

                    case 2:
                        Customer.UpdateCustomer(Utility.StringInput("Inserisci la mail del cliente da modificare"));
                        Console.WriteLine("modificato");
                        break;

                    case 3:
                        Customer CustomerToOrder = (Customer.ReadCustomer(Utility.StringInput("Inserisci la mail del cliente da cercare")));
                        Console.WriteLine(CustomerToOrder.ToString(CustomerToOrder)); 
                        break;
                    case 4:
                        //delete
                        break;
                    default:
                        CusExit = true;
                        break;
                }
            }

            break;
        case 2:
            Console.Clear();

            Console.WriteLine("1-Aggiungi nuovo\n2-Modifica\n3-Visualizza\n4-Elimina");
            bool ProdExit = false;
            while (!ProdExit)
            {
                int ProdChoice = Convert.ToInt32(Utility.StringInput("Cosa vuoi fare:"));
                switch (ProdChoice)
                {
                    case 1:
                        Product nP = Product.CreateProduct(Utility.StringInput("Nome:"), Utility.StringInput("Descrizione"), Convert.ToDouble(Utility.StringInput("Prezo:")));
                        Console.WriteLine(nP.ToString(nP));
                        break;

                    case 2:
                        //update
                        break;

                    case 3:
                        Product p = Product.ReadProduct(Utility.StringInput("Che prodotto vuoi Visualizare?"));

                        break;
                    case 4:
                        //delete
                        break;
                    default:
                        CusExit = true;
                        break;
                }
            }
            break;

        case 4:
            Console.Clear();

            List<Product> cart = new List<Product>();
            Customer c = (Customer.ReadCustomer(Utility.StringInput("Inserisci la mail a cui assegnare l'ordine")));
            bool keepAdding = true;
            while (keepAdding)
            {
                int orderChoice = Convert.ToInt32(Utility.StringInput("1-Aggiungi Prodotto 2-Salva Ordine"));
                switch (orderChoice)
                {
                    case 1:
                        Product p = Product.ReadProduct(Utility.StringInput("Che prodotto vuoi aggiungere?"));
                        cart.Add(p);
                        break;
                    case 2:

                            Order.AddProductToOrder(c, cart);
                            keepAdding = false;
                      
                        
                        break;
                    default:
                        break;
                }
            }
            break;
        

        default:
            break;
    }
}



