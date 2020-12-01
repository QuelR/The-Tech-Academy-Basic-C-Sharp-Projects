using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace YourNumbersOrMine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick a number");
            int numOne = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n" + "Pick a second number if you'd like");
            string stringNum = Console.ReadLine();

            YourNumsOrMine.TwoInts twoInts = new YourNumsOrMine.TwoInts();

            Console.WriteLine("\n" + "The total equals: " + twoInts.Numbers(numOne, stringNum));

            Console.ReadLine();
        }
    }
}
