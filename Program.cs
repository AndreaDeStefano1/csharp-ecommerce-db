
using csharp_ecommerce_db;

static void MenuOptions()
{
    Console.WriteLine("1-Employee\n2-Customer\n3-Product");
}

using(OrderContext db = new OrderContext())
{
    Customer nC = new Customer();
    nC.Name = StringInput("\nNome:");
    nC.Surname = StringInput("\nCognome:");
    nC.Email = StringInput("\nEmail:");

    db.Add(nC);
    db.SaveChanges();
}


static string StringInput(string message)
{
    Console.WriteLine(message);
    return Console.ReadLine();
}