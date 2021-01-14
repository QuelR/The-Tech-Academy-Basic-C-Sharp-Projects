using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//1.Create a const variable.

//2. Create a variable using the keyword "var.”

//3.Chain two constructors together.

namespace ConstructorVar
{
    public class Program
    {
        public class Celebrate
        {

            public Celebrate(string fName) : this(fName, 90210) { }

            public Celebrate(string fName, int zipCode)
            {
                FullName = fName;
                PostCode = zipCode;
            }

            public string FullName { get; set; }
            public int PostCode { get; set; }
        }

        const string mood = "Happy";
        const string bDay = "Birthday";
        const string annV = "Anniversary";

        Celebrate FullName = new Celebrate("Stan Lee");

        public static void Main(string[] args)
        {
            var years = "20";
            string employee = "Don Keigh";

            Console.WriteLine("{0} {1} {2}!", mood, bDay, employee);
            Console.WriteLine("{0} {1}th {2} {3}!", mood, years, annV, employee);
            Console.ReadLine();
        }
    }
}
