using Params;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethod
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Pick a number");
            string add1 = Console.ReadLine();
            int addition1 = Int32.Parse(add1);

            Console.WriteLine("Pick a second number");
            string add2 = Console.ReadLine();
            int addition2 = Int32.Parse(add2);

            Addition addition = new Addition();
            addition.Total(addition1, addition2);

            Console.ReadLine();

        }

    }
}
