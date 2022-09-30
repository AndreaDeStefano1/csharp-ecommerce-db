using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_ecommerce_db
{
    public class Utility
    {
        public static void MenuOptions()
        {
            Console.WriteLine("1-Customer\n2-Product\n3-Employee\n4-Order");
        }

        public static string ValueChange(string value)
        {
            Console.WriteLine($"Vuoi modificare il nome? [{value}]");
            string newValue = Console.ReadLine();// QUI VORREI USARE IL MIO STRINGINPUT() CHE SI TROVA IN PROGRAM
            if (newValue != "")
            {
                return newValue;
            }
            return value;
        }


        public static string StringInput(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }
    }
}
