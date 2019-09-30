using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            ////////  Here are the tasks
            // #1: compute the full name (string)
            // #2: compute the height in CM (double)
            // #3: compute if you can vote (bool)

            string firstName;
            string middleInitial;
            string lastName;
            string fullName;
            int age;
            bool isCitizen;
            bool canVote;
            int heightFeet;
            double heightInches;
            double totalHeightCentimeters;

            //////// Here's #1: Compute the full name

            Console.Write("What is your first name?");
            firstName = Console.ReadLine();

            Console.Write("And what is your middle initial?");
            middleInitial = Console.ReadLine();

            Console.Write("And what is your last name?");
            lastName = Console.ReadLine();

            fullName = firstName + " " + middleInitial + " " + lastName;
            Console.WriteLine(fullName);


            //////// Here's #2:  Compute the height in centimeters
            
            Console.Write("How tall are you? (in feet)");
            heightFeet = int.Parse(Console.ReadLine());

            Console.Write("How many more inches in addition to those feet?");
            heightInches = double.Parse(Console.ReadLine());

            totalHeightCentimeters = ((12 * heightFeet) + heightInches) * 2.54;
            Console.WriteLine(totalHeightCentimeters);


            //////// Here's #3:  Compute whether or not you can vote

            Console.Write("What is your age?");
            age = int.Parse(Console.ReadLine());

            Console.Write("Are you a United States citizen?");
            isCitizen = Console.ReadLine().ToLower().StartsWith("y");

            canVote = isCitizen && age >= 18;

            Console.WriteLine(fullName);
            Console.WriteLine(totalHeightCentimeters);
            Console.WriteLine(canVote);

            Console.ReadKey();

        }
    }
}
