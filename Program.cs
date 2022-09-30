
using csharp_ecommerce_db;

static void MenuOptions()
{
    Console.WriteLine("1-Employee\n2-Customer\n3-Product");
}




static string StringInput(string message)
{
    Console.WriteLine(message);
    return Console.ReadLine();
}



bool exit = false;

while (!exit)
{
    MenuOptions();

    int choice = Convert.ToInt32(StringInput("Cosa vuoi fare:"));
    switch (choice)
    {

        case 1:
            Console.WriteLine("1-Aggiungi nuovo\n2-Modifica\n3-Visualizza\n4-Elimina");
            bool CusExit = false;
            while (!CusExit)
            {
                int CusChoice = Convert.ToInt32(StringInput("Cosa vuoi fare:"));
                switch (CusChoice)
                {
                    case 1:
                        Customer nC = Customer.CreateCustomer(StringInput("Nome:"), StringInput("Cognome"), StringInput("Email:"));
                        Console.WriteLine(nC.ToString(nC));
                        break;

                    case 2:
                        Customer.UpdateCustomer(StringInput("Inserisci la mail del cliente da modificare"));
                        Console.WriteLine("modificato");
                        break;

                    case 3:
                        break;
                    case 4:
                        break;
                    default:
                        CusExit = true;
                        break;
                }
            }

            break;


        default:
            break;
    }
}