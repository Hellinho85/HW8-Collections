using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8
{
    class Person
    {
        /* Create a class Person that will have 4 properties 
        (FirstName, LastName, Age, Gender-that will be enumeration).
        The person class should have a virtual method GetInfo that 
        will print the information of that person. */
        public string FirstName;
        public string LastName;
        public int Age;
        public Gender Gender;

        public virtual void GetInfo()
        {
            Console.WriteLine($"FirstName: {FirstName}, LastName: {LastName}, Age: {Age}, Gender: {Gender}.");
        }

    }
}
