using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotTheDog
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi there, what's your name?");
            string userName = Console.ReadLine();
            userName = userName.ToUpper();

            Console.WriteLine("Pick an animal");
            string animal = Console.ReadLine();

            string date = DateTime.Today.ToShortDateString();

            string str = "Hello " + userName + ". \nToday is " + date + ". \nI'm going to tell you a story about a little " + animal + ".";
            Console.WriteLine(str);
            Console.ReadLine();

            StringBuilder spot = new StringBuilder();
            spot.Append("Spot the " + animal + ".");
            spot.Append("\nSpot the " + animal + " is beautiful.");
            spot.Append("\nEveryone wants to see the biggest beauty in the land, Spot.");
            spot.Append("\nPeople travel from all over the world to see Spot the " + animal + ".");
            spot.Append("\nSpot the " + animal + " is known for it's vibrant colors.");
            spot.Append("\nSpot the " + animal + " has decided it's time for a quiet life.");
            spot.Append("\nSpot the " + animal + " sneaks away and finds an oasis.");
            spot.Append("\nSpot the " + animal + " lives it's remaining days unbothered and happy.");
            spot.Append("\nThe end");
            spot.Append("\nThanks for listening " + userName);

            Console.WriteLine(spot);
            Console.ReadLine();
                                          
        }
    }
}
