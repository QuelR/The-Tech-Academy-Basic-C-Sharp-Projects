using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1.Create a class. In that class, create a method that takes two integers as parameters. Make one of them optional. 
// Have the method do a math operation and return an integer result.

//2. In the Main() method of the console app, instantiate the class.

//3.Ask the user to input two numbers, one at a time. Let them know they need not enter anything for the second number.

//4. Call the method in the class, passing in the one or two numbers entered.

//5. Try various combinations of numbers on the code, including having no second number.

namespace Params2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick a number");
            string numOne = Console.ReadLine();
            int numTwo = Int32.Parse(numOne);

            Console.WriteLine("Pick a second number, if you'd like");
            string numThree = Console.ReadLine();

            
            Magic magic = new Magic();
            magic.Total(numTwo, numThree);

            Console.WriteLine("The total equals: " + magic.Total(numTwo, numThree));

            Console.ReadLine();

        }
    }
}
