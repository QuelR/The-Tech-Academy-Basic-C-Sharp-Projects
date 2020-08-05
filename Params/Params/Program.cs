using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Params
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOne = 42;
            Console.WriteLine("Pick a number");
            string numTwo = Console.ReadLine();
            int numThree = Int32.Parse(numTwo);

            Console.WriteLine("Pick a second number");
            string numFour = Console.ReadLine();
            int numSix = Int32.Parse(numFour);

            if (numThree > numSix)
            {
                Console.WriteLine("Your first number is bigger, lets use your first number: " + numThree);
                Console.WriteLine(numThree + " x 10 is: ");
                Magic multi10 = new Magic();
                multi10.Multi10(numThree);
                Console.ReadLine();
            }

            else if (numThree < numSix)
            {
                Console.WriteLine("Your second number is bigger, lets use your second number: " + numSix);
                Console.WriteLine(numSix + " x 5 is: ");
                Magic multi5 = new Magic();
                multi5.Multi5(numSix);
                Console.ReadLine();
            }

            else if (numThree == numSix)
            {
                Console.WriteLine("Your numbers are the same, lets use my number: " + numOne);
                Console.WriteLine(numOne + " x 15 is: ");
                Magic multi15 = new Magic();
                multi15.Multi15(numOne);
                Console.ReadLine();
            }

            Console.ReadLine();

        }
        
    }
}
