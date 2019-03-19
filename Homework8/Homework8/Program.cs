using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8
{
    class Program
    {
        static void Main(string[] args)
        {
            // Homework no.8 - Gjorgji Kongulovski SG1 - Imma Rock You!!!! :P

            // Create a list that will have 20 students;

            Student g1 = new Student() { FirstName = "Gjorgji", LastName = "Kongulovski", Age = 33, ID = 7, Course = "C# Basic", Group = 1, Gender = Gender.Male };
            Student g2 = new Student() { FirstName = "Ana", LastName = "Ivanovic", Age = 31, ID = 41, Course = "C# Basic", Group = 6, Gender = Gender.Female };
            Student g3 = new Student() { FirstName = "Riste", LastName = "Arsov", Age = 38, ID = 12, Course = "C# Basic", Group = 1, Gender = Gender.Male };
            Student g4 = new Student() { FirstName = "Aracely", LastName = "Arámbula", Age = 43, ID = 15, Course = "C# Basic", Group = 2, Gender = Gender.Female };
            Student g5 = new Student() { FirstName = "Venko", LastName = "Trajkovski", Age = 33, ID = 24, Course = "C# Basic", Group = 4, Gender = Gender.Male };
            Student g6 = new Student() { FirstName = "Mikaela", LastName = "Schiffrin", Age = 24, ID = 22, Course = "C# Basic", Group = 3, Gender = Gender.Female };
            Student g7 = new Student() { FirstName = "Bradley", LastName = "Cooper", Age = 44, ID = 34, Course = "C# Basic", Group = 6, Gender = Gender.Male };
            Student g8 = new Student() { FirstName = "Valentina", LastName = "Palkovska", Age = 35, ID = 14, Course = "C# Basic", Group = 1, Gender = Gender.Female };
            Student g9 = new Student() { FirstName = "Todor", LastName = "Janevski", Age = 36, ID = 5, Course = "C# Basic", Group = 1, Gender = Gender.Male };
            Student g10 = new Student() { FirstName = "Kristina", LastName = "Spasevska", Age = 31, ID = 9, Course = "C# Basic", Group = 1, Gender = Gender.Female };
            Student g11 = new Student() { FirstName = "Kristijan", LastName = "Kitevski", Age = 29, ID = 40, Course = "C# Basic", Group = 5, Gender = Gender.Male };
            Student g12 = new Student() { FirstName = "Camila", LastName = "Mendes", Age = 26, ID = 26, Course = "C# Basic", Group = 4, Gender = Gender.Female };
            Student g13 = new Student() { FirstName = "Nikola", LastName = "Tabakovski", Age = 33, ID = 19, Course = "C# Basic", Group = 2, Gender = Gender.Male };
            Student g14 = new Student() { FirstName = "Tina", LastName = "Armstrong", Age = 27, ID = 49, Course = "C# Basic", Group = 5, Gender = Gender.Female };
            Student g15 = new Student() { FirstName = "Jane", LastName = "Kostov", Age = 24, ID = 19, Course = "C# Basic", Group = 3, Gender = Gender.Male };
            Student g16 = new Student() { FirstName = "Lili", LastName = "Reinhart", Age = 22, ID = 50, Course = "C# Basic", Group = 6, Gender = Gender.Female };
            Student g17 = new Student() { FirstName = "Vladimir", LastName = "Jankovic", Age = 31, ID = 47, Course = "C# Basic", Group = 5, Gender = Gender.Male };
            Student g18 = new Student() { FirstName = "Nina", LastName = "Jovanovic", Age = 28, ID = 30, Course = "C# Basic", Group = 4, Gender = Gender.Female };
            Student g19 = new Student() { FirstName = "Terry", LastName = "Bogard", Age = 30, ID = 25, Course = "C# Basic", Group = 3, Gender = Gender.Male };
            Student g20 = new Student() { FirstName = "Chun", LastName = "Li", Age = 25, ID = 1, Course = "C# Basic", Group = 1, Gender = Gender.Female };


            // Total list;
            List<Student> all = new List<Student>() { g1, g2, g3, g4, g5, g6, g7, g8, g9,
            g10, g11, g12, g13, g14, g15, g16, g17, g18, g19, g20};
            foreach (Student item in all)
            {
                item.GetInfo();
            }

            Console.WriteLine("------------------------------------------------------------------- \n");

            // Print info for all male students;
            List<Student> males = all.Where(x => x.Gender == Gender.Male).ToList();
            foreach (Student item in males)
            {
                item.GetInfo();
            }

            Console.WriteLine("------------------------------------------------------------------- \n");

            // Print info for all female students;
            List<Student> females = all.Where(x => x.Gender == Gender.Female).ToList();
            foreach (Student item in females)
            {
                item.GetInfo();
            }

            Console.WriteLine("------------------------------------------------------------------- \n");

            // Print info for student with id(user should input an id);
            Console.Write("Please enter the number of ID: ");
            int boom = int.Parse(Console.ReadLine());
            List<Student> ids = all.Where(x => x.ID == boom).ToList();
            foreach (Student item in ids)
            {
                item.GetInfo();
            }

            Console.WriteLine("------------------------------------------------------------------- \n");

            // Print info for all students that are in group(user should input a number of group);
            Console.Write("Please enter the number of the group: ");
            int press = int.Parse(Console.ReadLine());
            List<Student> groups = all.Where(x => x.Group == press).ToList();
            foreach (Student item in groups)
            {
                item.GetInfo();
            }

            Console.WriteLine("------------------------------------------------------------------- \n");

            // Print info for all students with a first letter of a name(user should input a letter);
            Console.Write("Please enter a letter: ");
            string input = Console.ReadLine();
            List<Student> letter = all.Where(x => x.FirstName.StartsWith(input)).ToList();
            List<string> startsWithB = all.Where(x => x.FirstName.StartsWith(input)).Select(x => x.FirstName).ToList();
            foreach (Student item in letter)
            {
                item.GetInfo();
            }


            Console.ReadLine();
        }
    }
}
