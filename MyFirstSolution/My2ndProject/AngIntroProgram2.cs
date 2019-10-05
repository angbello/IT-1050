using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My2ndProject
{
    class AngIntroProgram2
    {
        static void Main(string[] args)
        {
            ////////  Differentiating this 2nd program from the 1st by:  
            /////////////////// -Making compound statements
            /////////////////// -Using declared variables to compute the height (instead of #'s)
            
            ////////  Here are the tasks
            // #1: compute the full name (string)
            // #2: compute the height in CM (double)
            // #3: compute if you can vote (bool)


            //////// Here's #1: Compute the full name

            Console.Write("What is your first name?");
            string firstName = Console.ReadLine();

            Console.Write("And what is your middle initial?");
            string middleInitial = Console.ReadLine();

            Console.Write("And what is your last name?");
            string lastName = Console.ReadLine();

            string fullName = firstName + " " + middleInitial + " " + lastName;
            Console.WriteLine(fullName);


            //////// Here's #2:  Compute the height in centimeters

            Console.Write("How tall are you? (in feet)");
            int heightFeet = int.Parse(Console.ReadLine());

            Console.Write("How many more inches in addition to those feet?");
            double heightInches = double.Parse(Console.ReadLine());

            int inchesEqualsFoot = 12;

            double CMequalsInch = 2.54;

            double totalHeightCentimeters = ((inchesEqualsFoot * heightFeet) + heightInches) * CMequalsInch;
            Console.WriteLine(totalHeightCentimeters);


            //////// Here's #3:  Compute whether or not you can vote

            Console.Write("What is your age?");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Are you a United States citizen?");
            bool isCitizen = Console.ReadLine().ToLower().StartsWith("y");

            bool canVote = isCitizen && age >= 18;

            Console.WriteLine(fullName);
            Console.WriteLine(totalHeightCentimeters);
            Console.WriteLine(canVote);

            Console.ReadKey();

        }
    }
}
