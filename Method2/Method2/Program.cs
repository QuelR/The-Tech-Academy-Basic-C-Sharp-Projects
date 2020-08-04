using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method2
{
    class Program
    {
        public static void Main(string[] args)
        {

            int number = 43;
            string stNum = "500";

            Console.WriteLine("43 plus 100 equals: ");
            Math add = new Math();
            add.Adding(number);
            Console.ReadLine();

            Console.WriteLine("43 divided by 2 equals: ");
            Math divi = new Math();
            divi.Divide(number);
            Console.ReadLine();

            Console.WriteLine("43 multiplied by 500 equals: ");
            Math thNum = new Math();
            thNum.Third(stNum);
            Console.ReadLine();


        }
    }
}
