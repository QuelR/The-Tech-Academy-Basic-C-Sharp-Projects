using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameParams
{
    class Program
    {
        static void Main(string[] args)
        {
            DubNums numTwo = new DubNums();
            int result2 = numTwo.Num2();

            DubNums numOne = new DubNums();
            int result1 = numOne.Num1();
            Console.WriteLine("12 times 2 equals: " + result1);

            Console.WriteLine("\n" + result2);
            Console.ReadLine();
        }
    }
}
