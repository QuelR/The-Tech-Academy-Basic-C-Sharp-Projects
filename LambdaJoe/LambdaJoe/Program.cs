using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1.In the Main() method, create a list of at least 10 employees. Each employee should have a first and last name, as well as an Id. At least two employees should have the first name "Joe".

//2. Using a foreach loop, create a new list of all employees with the first name "Joe".

//3. Perform the same action again, but this time with a lambda expression.

//4. Using a lambda expression, make a list of all employees with an Id number greater than 5.

namespace LambdaJoe
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Employee> employeeList = new List<Employee>();

            employeeList.Add(new Employee() { FirstName = "Neil", LastName = "Down", EmployeeId = 001 });
            employeeList.Add(new Employee() { FirstName = "Paige", LastName = "Turner", EmployeeId = 002 });
            employeeList.Add(new Employee() { FirstName = "Joe", LastName = "King", EmployeeId = 003 });
            employeeList.Add(new Employee() { FirstName = "Holly", LastName = "Days", EmployeeId = 004 });
            employeeList.Add(new Employee() { FirstName = "Barb", LastName = "Burr", EmployeeId = 005 });
            employeeList.Add(new Employee() { FirstName = "Justin", LastName = "Case", EmployeeId = 006 });
            employeeList.Add(new Employee() { FirstName = "Robin", LastName = "Banks", EmployeeId = 007 });
            employeeList.Add(new Employee() { FirstName = "Anna", LastName = "Graham", EmployeeId = 008 });
            employeeList.Add(new Employee() { FirstName = "Joe", LastName = "Kerr", EmployeeId = 009 });
            employeeList.Add(new Employee() { FirstName = "Terry", LastName = "Bull", EmployeeId = 010 });

            Console.WriteLine("Employee List:");
            foreach (Employee emp in employeeList)
            {
                //Console.WriteLine("Employee List: \nFirst Name: {0} \tLast Name: {1} \tId: {2}", emp.FirstName, emp.LastName, emp.EmployeeId);
                Console.WriteLine(emp.FirstName + " " + emp.LastName + " Id: " + emp.EmployeeId);

            }

            Console.WriteLine("\nEmployees with the first name Joe.");
            List<Employee> joeList = new List<Employee>();
            foreach (Employee joeEmp in employeeList)
            {
                if (joeEmp.FirstName == "Joe")
                {
                    joeList.Add(joeEmp);
                    Console.WriteLine("First Name: {0} \tLast Name: {1} \tId: {2}", joeEmp.FirstName, joeEmp.LastName, joeEmp.EmployeeId);
                }
            }

            Console.WriteLine("\nEmployees with first name Joe.");
            foreach (Employee empJoe in employeeList.FindAll(x => x.FirstName == "Joe"))
            {
                Console.WriteLine("First Name: {0} Last Name: {1} Id: {2}", empJoe.FirstName, empJoe.LastName, empJoe.EmployeeId);
            }

            Console.WriteLine("\nEmployee Id #'s over 5: ");
            foreach (Employee idNum in employeeList.FindAll(x => x.EmployeeId > 5))
            {
                Console.WriteLine("Id # {0}: {1} {2}", idNum.EmployeeId, idNum.FirstName, idNum.LastName);
            }
            Console.ReadLine();
        }
    }
}
