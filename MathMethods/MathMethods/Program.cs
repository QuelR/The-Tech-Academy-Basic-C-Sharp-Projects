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

            //Console.WriteLine("42 plus 100 equals: ");
            //MathClass add = new MathClass();
            //add.Adding(number);
            //Console.ReadLine();

            MathClass add = new MathClass();
            int result1 = add.Adding(number);
            Console.WriteLine("42 plus 100 equals: " + result1);

            //Console.WriteLine("\n" + "42 divided by 2 equals: ");
            //MathClass divi = new MathClass();
            //divi.Divide(number);
            //Console.ReadLine();

            MathClass divi = new MathClass();
            int result2 = divi.Divide(number);
            Console.WriteLine("\n" + "42 divided by 2 equals: " + result2);

            //Console.WriteLine("\n" + "42 multiplied by 2020 equals: ");
            //MathClass thNum = new MathClass();
            //thNum.Third(stNum);
            //Console.ReadLine();

            MathClass thNum = new MathClass();
            int result3 = thNum.Third(stNum);
            Console.WriteLine("\n" + "42 multiplied by 2020 equals: " + result3);

            Console.ReadLine();
        }        
    }
}
