using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Drill_Page_66
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            string userNumber = Console.ReadLine();
            int userNum = Convert.ToInt32(userNumber);
            int total = userNum * 50;
            Console.WriteLine("Your number multiplied by 50 is: " + total);
            Console.ReadLine();

            Console.WriteLine("Choose a second number");
            string secondNumber = Console.ReadLine();
            int secondNum = Convert.ToInt32(secondNumber);
            int secondTotal = secondNum + 25;
            Console.WriteLine("Your number plus 25 is: " + secondTotal);
            Console.ReadLine();

            Console.WriteLine("Choose a third number");
            string thirdNumber = Console.ReadLine();
            int thirdNum = Convert.ToInt32(thirdNumber);
            double thirdTotal = thirdNum / 12.5;
            Console.WriteLine("Your number divided by 12.5 is: " + thirdTotal);
            Console.ReadLine();

            Console.WriteLine("Choose a fourth number");
            string fourthNumber = Console.ReadLine();
            int fourthNum = Convert.ToInt32(fourthNumber);
            bool fourthTotal = fourthNum > 50;
            Console.WriteLine("Your number is greater than 50: " + fourthTotal);
            Console.ReadLine();

            Console.WriteLine("Choose fifth number");
            string fifthNumber = Console.ReadLine();
            int fifthNum = Convert.ToInt32(fifthNumber);
            int fifthTotal = fifthNum % 7;
            Console.WriteLine("Your number divided by 7 has a remainder of: " + fifthTotal);
            Console.ReadLine();
                                                      
        }
    }
}
