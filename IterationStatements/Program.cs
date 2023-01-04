using System;

namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000
        static void oneThousand()
        {
            //set number to zero
            int number = 0;
            while (number <= 1000)
            {
                number++;
                Console.WriteLine(number);
            }
        }

        //Write a method that will print to the console numbers 3 through 999 by 3 each time

        static void incrementsOfThreeOneThousand()
        {
            int number = 3;
            while (number <= 999)
            {
                number += 3;
                Console.WriteLine(number);
            }
        }

        //Write a method to accept two integers as parameterss and check whether they are equal or not

        static void integerEquality(int a, int b)
        {
            string equalCheck = (a == b) ? Console.WriteLine("The two parameters are equal."); : Console.WriteLine($"The two parameters are not equal. A is equal to {a} and B is {b}.");
        }

        //Write a method to check whether a given number is even or odd

        static void evenNumberCheck(int a)
        {
            string evenFormula = (a % 2 == 0) ? Console.WriteLine("The number is even."); : Console.WriteLine("The number is odd.");
        }

        //Write a method to check whether a given number is positive or negative

        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10

        //Write a method to display the multiplication table(from 1 to 12) of a given integer


        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            //print 0 - 1000
            oneThousand();

            //print 3 - 999 in increments of 3
            incrementsOfThreeOneThousand();
        }
    }
}
