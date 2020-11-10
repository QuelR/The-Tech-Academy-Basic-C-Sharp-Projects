using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below");
            
            Console.WriteLine("What is the package weight?");
            int pkgWt = Convert.ToInt32(Console.ReadLine());
            
            if (pkgWt > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                return;
            }

            Console.WriteLine("What is the package width?");
            int pkgWd = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the package height?");
            int pkgHt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the package length?");
            int pkgLt = Convert.ToInt32(Console.ReadLine());


            if ((pkgWd + pkgHt + pkgLt) > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                Console.ReadLine();
                return;
            }

            Console.WriteLine("Your estimated total for shipping this package is: $" + (pkgWt * pkgWd * pkgHt * pkgLt / 100) + ".00");
            Console.ReadLine();
        }
    }
}
