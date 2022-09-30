using System.Runtime.CompilerServices;

namespace csharp_ecommerce_db
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Level { get; set; }

        // relazione 

        List<Order> Orders { get; set; }

        
    }
}
