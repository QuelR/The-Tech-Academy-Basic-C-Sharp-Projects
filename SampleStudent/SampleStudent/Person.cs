﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Perform these actions and create a console app that includes the following:

//1.Create an abstract class called Person with two properties: string firstName and string lastName.

//2. Give it the method SayName().

//3.Create another class called Employee and have it inherit from the Person class.

//4.Implement the SayName() method inside of the Employee class.

//5.Inside the Main() method, instantiate an Employee object with firstName "Sample" and lastName "Student". Call the SayName() method on the object.

namespace SampleStudent
{
    public abstract class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        public abstract void sayName();
    }
}
