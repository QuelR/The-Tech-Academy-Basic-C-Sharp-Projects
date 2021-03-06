﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Perform these actions and create a console app that includes the following:

//1.Overload the "==" operator so it checks if two Employee objects are equal by comparing their Id property.

namespace EmployeeID
{
    public abstract class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        //public int id { get; set; }

        public abstract void sayName();
    }
}
