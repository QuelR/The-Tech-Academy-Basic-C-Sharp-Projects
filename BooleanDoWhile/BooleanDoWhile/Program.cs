using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do you want to play my game? True or False?");
            bool gameFun = Convert.ToBoolean(Console.ReadLine());
            
            while (gameFun == true)
            {
                Console.ReadLine();
                break;
            }

            while (gameFun == false)
            {
                goto Finish;
            }

                {
                Console.WriteLine("What is the perfect temperature?");
                int temp = Convert.ToInt32(Console.ReadLine());
                bool isMatch = temp == 80;

                do
                {
                    switch (temp)
                    {

                        case 80:
                            Console.WriteLine("That's the perfect temperature! Thanks for playing");
                            isMatch = true;
                            break;

                        case int n when n >= 81:
                            Console.WriteLine("That's too warm!");
                            Console.WriteLine("\n" + "What is the perfect temperature?");
                            temp = Convert.ToInt32(Console.ReadLine());
                            break;

                        case int n when n <= 79:
                            Console.WriteLine("That's too cold!");
                            Console.WriteLine("\n" + "What is the perfect temperature?");
                            temp = Convert.ToInt32(Console.ReadLine());
                            break;
                    }
                }

                while (!isMatch);

                Console.ReadLine();


                }
        Finish:
            Console.WriteLine("You're missing out. Bye.");
            Console.ReadLine();
        }
    }
}
