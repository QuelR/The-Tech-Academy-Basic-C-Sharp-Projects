using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 42;
            string stNum = "2020";

            Console.WriteLine("42 plus 100 equals: ");
            MathClass add = new MathClass();
            add.Adding(number);
            Console.ReadLine();

            Console.WriteLine("42 divided by 2 equals: ");
            MathClass divi = new MathClass();
            divi.Divide(number);
            Console.ReadLine();

            Console.WriteLine("42 multiplied by 2020 equals: ");
            MathClass thNum = new MathClass();
            thNum.Third(stNum);
            Console.ReadLine();
        }
    }
}
