﻿using System;
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
    public class LegitAge : Exception
    {
        public LegitAge()
            : base() { }
        public LegitAge(string message)
            : base(message) { }
    }

}
