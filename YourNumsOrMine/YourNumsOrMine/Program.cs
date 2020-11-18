using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourNumsOrMine
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 42;

            TwoInts twoInts = new TwoInts();
            int userNum1 = twoInts.Num1();
            int userNum2 = twoInts.Num2();

            if (userNum2 == 0)
            {
                Console.WriteLine("\n" + "We'll use my number: " + number);
                int mathNum4 = number * 5;
                Console.WriteLine("\n" + number + " x 5 is: " + mathNum4);

            }
            else if (userNum1 > userNum2)
            {
                Console.WriteLine("\n" + "Your first number is bigger, lets use your first number: " + userNum1);
                int mathNum1 = userNum1 * 10;
                Console.WriteLine("\n" + userNum1 + " x 10 is: " + mathNum1);
            }

            else if (userNum1 < userNum2 )
            {
                Console.WriteLine("\n" + "Your second number is bigger, lets use your second number: " + userNum2);
                int mathNum2 = userNum2 * 15;
                Console.WriteLine("\n" + userNum2 + " x 15 is: " + mathNum2);
            }

            else if (userNum1 == userNum2)
            {
                Console.WriteLine("\n" + "Your numbers are the same, lets use my number: " + number);
                int mathNum3 = number * 20;
                Console.WriteLine("\n" + number + " x 20 is: " + mathNum3);
            }

            Console.ReadLine();
        }
    }
}
