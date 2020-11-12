using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterationMulti
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>() { "Jesse", "Erik", "Adam", "Daniel" }; /*pt1*/

            Console.WriteLine("Hi there, what's your name?");/*pt1*/
            string userName = Console.ReadLine();/*pt1*/

            Console.WriteLine("Thanks " + userName + ". I'll add you into a list of classmates."); /*pt1*/

            names.Add(userName);/*pt1*/

            if (names.Count < 100) /*pt4*/
                if (names.Count <= 5)/*pt5*/

                    foreach (string name in names)/*pt1*/
                    {
                        {
                            while (true) /*pt2*/
                                break; /*pt3*/
                            {
                                Console.WriteLine(name);/*pt1*/
                            }
                        }
                    }

            Console.WriteLine("Choose one the the classmates from above.");/*p6*/
            string classmateName = Console.ReadLine();/*p6*/


            if (classmateName == "Jesse")/*p6*/
            {
                Console.WriteLine(classmateName + " needs your assistance, please contact Jesse.");/*p6*/
            }
            else if (classmateName != "Jesse" && classmateName != "Erik" && classmateName != "Adam" && classmateName != "Daniel" && classmateName != "Erik" && classmateName != userName)  /*pt7*/
            {
                Console.WriteLine("Student not listed"); /*pt7*/
            }

            else if (classmateName != "Jesse") /*p6*/
            {
                Console.WriteLine(classmateName + " is a great student!");/*p6*/
            }


            Console.ReadLine();/*pt1*/

            List<string> animals = new List<string>() { "Dog", "Cat", "Rabbit", "Dog" };

            Console.WriteLine("Please type a typical house pet.");
            string animalType = Console.ReadLine();

            Console.WriteLine("Thanks for your input of a " + animalType + ".");
            animals.Add(animalType);

            for (int j = 0; j < animals.Count;)
                break;

            if (animalType == "Dog" || animalType == "Cat" || animalType == "Rabbit")
            {
                Console.WriteLine(animals.Count);
                Console.ReadLine();
            }

            else
            {
                Console.WriteLine("Please try again.");
                Console.ReadLine();
            }

            List<string> color = new List<string>() { "Black", "Black", "White", "Red", "Blue", "Green", "Pink", "Yellow", "Orange", "Purple", "Red" };

            var duplicates = color.GroupBy(s => s.ToUpper())
                         .Where(g => g.Count() > 1)
                         .Select(g => g.Key);

            foreach (var dupe in duplicates)
            {
                Console.WriteLine(dupe);
                Console.ReadLine();
            }
        }
    }
}
