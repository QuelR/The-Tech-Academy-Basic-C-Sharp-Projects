using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicInsurance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            string ageReq = Console.ReadLine();


            Console.WriteLine("Have you ever had a DUI? True or False");
            string duiReq = Console.ReadLine();

            Console.WriteLine("How many speeding tickets do you have?");
            string tixReq = Console.ReadLine();

            int ageLimit = Convert.ToInt32(ageReq);
            bool duiQs = Convert.ToBoolean(duiReq);
            int speedTix = Convert.ToInt32(tixReq);

            Console.WriteLine("Qualified?");
            bool qualified = (ageLimit > 15 && duiQs == false && speedTix <= 3);
            Console.WriteLine(qualified);
            Console.ReadLine();
        }
    }
}
