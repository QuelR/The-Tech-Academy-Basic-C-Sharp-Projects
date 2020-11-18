using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourNumsOrMine
{
    class TwoInts
    {
        public int Num1()
        {           
            Console.WriteLine("Pick a number");
            int numOne = Convert.ToInt32(Console.ReadLine());
            return numOne; 
        }

        public int Num2()
        {
            Console.WriteLine("\n" + "Pick a second number if you'd like");
            int numTwo = Convert.ToInt32(Console.ReadLine());
            return numTwo;
        }

    }
}
