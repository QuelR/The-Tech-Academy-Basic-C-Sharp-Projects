using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1.Ask the user for their age.

//2. Display the year the user was born.

//3. Exceptions must be handled using “try/catch.”

//4.Display appropriate error messages if the user enters zero or negative numbers.

//5.Display a general message if an exception was caused by anything else.

namespace TryCatchExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("What is your age?");
                int age = Convert.ToInt32(Console.ReadLine());

                if (age <= 0)
                {
                    throw new LegitAge();
                }

                Console.WriteLine("True or False: Have you had a birthday this year?");
                bool bday = Convert.ToBoolean(Console.ReadLine());
                
                if (bday == false)
                {
                    int tOneBirthYear = 2020 - age;
                    Console.WriteLine("Your birth year is: " + tOneBirthYear);
                }

                if (bday == true)
                {
                    int tOneBirthYear = 2021 - age;
                    Console.WriteLine("Your birth year is: " + tOneBirthYear);
                }                
            }
            catch (LegitAge)
            {
                Console.WriteLine("Please type actual age.");
                Console.ReadLine();
                return;
            }
            catch (FormatException)
            {
                Console.WriteLine("Please answer question correctly.");
                Console.ReadLine();
                return;
            }
            catch (Exception)
            {
                Console.WriteLine("An error occurred. Please contact your System Administrator.");
                Console.ReadLine();
                return;
            }
            Console.ReadLine();
        }
    }
}
