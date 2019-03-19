using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8
{
    class Student : Person
    {
        // Create a class Student that will derive from the Person class. Student class should have properties Id, Group, Course.
        // Student class should override GetInfo method and should return the Full name of student plus the id and witch group is in.
        public int Group;
        public string Course;
        public int ID;

        public override void GetInfo()
        {
            Console.WriteLine($"FullName: {FirstName} {LastName}, Age: {Age}, Gender: {Gender}, ID: {ID}, Group: {Group}.");
        }

    }
}
