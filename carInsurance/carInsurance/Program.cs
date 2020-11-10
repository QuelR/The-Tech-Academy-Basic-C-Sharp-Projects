using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carInsurance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            int ageLimit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Have you ever had a DUI? True or False");
            bool duiQs = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("How many speeding tickets do you have?");
            int speedTix = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Qualified?");
            bool qualified = (ageLimit > 15 && duiQs == false && speedTix <= 3);
            Console.WriteLine(qualified);
            Console.ReadLine();
        }
    }
}
