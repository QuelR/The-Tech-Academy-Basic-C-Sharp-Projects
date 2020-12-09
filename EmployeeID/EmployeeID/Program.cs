using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Perform these actions and create a console app that includes the following:

//1.Overload the "==" operator so it checks if two Employee objects are equal by comparing their Id property.

namespace EmployeeID
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee();
            employee1.firstName = "Sample";
            employee1.lastName = "Student";
            employee1.id = 001;
            employee1.sayName();

            Employee employee2 = new Employee();
            employee2.firstName = "Justin";
            employee2.lastName = "Case";
            employee2.id = 002;
            employee2.sayName();

            Employee employee3 = new Employee();
            employee3.firstName = "Barb";
            employee3.lastName = "Burr";
            employee3.id = 003;
            employee3.sayName();

            
            Console.ReadLine();
        }
    }
}
