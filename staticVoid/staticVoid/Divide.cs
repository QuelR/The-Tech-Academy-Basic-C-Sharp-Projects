using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 1. Create a class. In that class, create a void method that outputs an integer.Have the method divide the data passed to it by 2.

// 2. In the Main() method, instantiate that class.

// 3. Have the user enter a number.Call the method on that number.Display the output to the screen. It should be the entered number, divided by two.

// 4. Create a method with output parameters.

// 5. Overload a method.

// 6. Declare a class to be static.

namespace staticVoid
{
    class Divide
    {
        public void NumDivi(int divNum, out int div1)
        {
            div1 = divNum / 2;
        }

        public static void NumDivi()
        {
            Console.WriteLine("Dividing my own number 42 by 2 equals: 21");
        }
    }
}
