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
            string equalCheck = (a == b) ? "The two parameters are equal." : "The two parameters are not equal.";
            Console.WriteLine(equalCheck);
        }

        //Write a method to check whether a given number is even or odd

        static void evenNumberCheck(int a)
        {
            string evenFormula = (a % 2 == 0) ? "The number is even." : "The number is odd.";
            Console.WriteLine(evenFormula);
        }

        //Write a method to check whether a given number is positive or negative

        static void postiveOrNegativeNumber(double a)
        {
            string postiveNegative = (a >= 0) ? "The number is positive." : "The number is negative.";
            Console.WriteLine(postiveNegative);
        }

        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()
        static void votingAge()
        {
            Console.WriteLine("What is your current age?");
            int age = Convert.ToInt32(Console.ReadLine()); //I cannot figure out how to apply Parse() or TryParse();
            string voterEligibility = (age >= 18) ? "You can vote." : "You cannot vote.";
            Console.WriteLine(voterEligibility);
        }

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        static void negativeTenToTen()
        {
            Console.WriteLine("Enter in your number.");
            int number = Convert.ToInt32(Console.ReadLine());
            string numberRange = (number <= 10 && number >= -10) ? "This number is betweeen -10 and 10" : "This number is not betweeen -10 and 10";
            Console.WriteLine(numberRange);
            
        }

        //Write a method to display the multiplication table(from 1 to 12) of a given integer
        static void multiplicationTableOneToTwelve(int a)
        {
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine(i * a);
            }
        }

        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            //print 0 - 1000
            oneThousand();

            //print 3 - 999 in increments of 3
            incrementsOfThreeOneThousand();

            //integer equality
            integerEquality(5, 6);

            //even number
            evenNumberCheck(6);

            //positive negative
            postiveOrNegativeNumber(-20);

            //voting age
            votingAge();

            //negative ten to positive ten
            negativeTenToTen();

            //mulitplication table
            multiplicationTableOneToTwelve(1);
        }
    }
}
