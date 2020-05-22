using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Package_Express
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below");
            Console.WriteLine("What is the package weight?");
            string pkgWt = Console.ReadLine();
            int passWt = 51;
            int passPkg = Convert.ToInt32(pkgWt);
            if (passPkg > passWt)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                return;
            }
            Console.WriteLine("What is the package width?");
            string pkgWd = Console.ReadLine();
            Console.WriteLine("What is the package height?");
            string pkgHt = Console.ReadLine();
            Console.WriteLine("What is the package length?");
            string pkgLt = Console.ReadLine();

            int passWd = Convert.ToInt32(pkgWd);
            int passHt = Convert.ToInt32(pkgHt);
            int passLt = Convert.ToInt32(pkgLt);

            if ((passWd + passHt + passLt) > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                Console.ReadLine();
                return;
            }
           
            Console.WriteLine("Your estimated total for shipping this package is: $" + (passPkg * passWd * passHt * passLt / 100) + ".00");
            Console.ReadLine();
        }
    }
}
