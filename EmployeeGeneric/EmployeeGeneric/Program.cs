using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1.Make the Employee class take a generic type parameter.

//2. Add a property to the Employee class called "things" and have its data type be a generic list matching the generic type of the class.

//3.Instantiate an Employee object with type "string" as its generic parameter. Assign a list of strings as the property value of Things.

//4. Instantiate an Employee object with type "int" as its generic parameter. Assign a list of integers as the property value of Things.

//5. Create a loop that prints all of the Things to the Console.

namespace EmployeeGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employee = new Employee<string>();
            employee.things = new List<string>();
            Employee<int> id = new Employee<int>();
            id.things = new List<int>();

            employee.things.Add("Sample Student");
            employee.things.Add("Justin Case");
            employee.things.Add("Barb Burr");

            id.things.Add(001);
            id.things.Add(002);
            id.things.Add(003);

            foreach (string empName in employee.things)
            {
                Console.WriteLine(empName);
            }

            foreach (int empId in id.things)
            {
                Console.WriteLine(empId);
            }

            Console.ReadLine();
        }
    }
}
