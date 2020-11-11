using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayofStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] weekDays = new string[] { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

            Console.WriteLine("Pick a number 1-7");
            int weekDay = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n" + weekDays[weekDay - 1] + " will be you lucky day!");

            int[] luckNum = { 1, 3, 5, 7, 9 };

            Console.WriteLine("\n" + "Pick a number between 1-5");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number > 1 & number < 6)
            {
                Console.WriteLine("\n" + luckNum[number - 1] * 2 + " is your lucky number!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("The number chosen is not within the required parameter.");
                Console.ReadLine();
            }

            List<int> intList = new List<int>();

            intList.Add(2);
            intList.Add(4);
            intList.Add(6);
            intList.Add(8);
            intList.Add(10);

            Console.WriteLine("\n" + "Pick another number between 1-5");
            int secLuck = Convert.ToInt32(Console.ReadLine());

            if (number > 1 & number < 6)
            {
                Console.WriteLine("\n" + intList[secLuck - 1] + " is your second lucky number!");
                Console.ReadLine();
            }

            else
            {
                Console.WriteLine("The number chosen is not within the required parameter.");
                Console.ReadLine();
            }
        }
    }
}
