using System;
using System.Diagnostics.CodeAnalysis;
using System.Net;

namespace Program
{
    class ACT3
    {
        public static void Main(string[] args)
        {
            // How many students you have(1-10)? 3

            // Enter name of student 1: Alice
            // Enter Alice's score: 90

            // Enter name of student 2: Joshua
            // Enter Joshua's score: 0
            // Score is zero(0) skipped!

            // Enter name of student 2: Mark
            // Enter Mark's score: -100
            // Score is negative skipped again!

            // Total number of student with valid score: 1
            // Average score: 90.00

            int i, totStud = 1;
            string studName;
            decimal valid = 0;
            decimal sum = 0;
            decimal studScore = 0;
            int studNum;

            while (true)
            {
                Console.Write("How many students you have(1-10)?: ");
                studNum = Convert.ToInt32(Console.ReadLine());

                if (studNum > 10)
                {
                    Console.WriteLine("Exceed value in 10!");
                    continue;
                }
                else
                {
                    break;
                }
            }
            
            for (i = 1; i <= studNum; i++)
            {

                Console.Write($"Enter name of student {i}: ");
                studName = Console.ReadLine();

                Console.Write($"Enter {studName}'s score: ");
                studScore = Convert.ToDecimal(Console.ReadLine());

                if (studScore == 0)
                {
                    Console.WriteLine("Score is zero(0) skipped!");
                    continue;

                }

                if (studScore < 0)
                {
                    Console.WriteLine("Score is negative: stop the program!");
                    break;
                }


                totStud += i;



                if (studScore > 0)
                {
                    valid++;

                }

                sum += studScore;
            }


            Console.WriteLine($"Total number student with valid score: {valid}");
            if (valid > 0)
            {
                decimal ave = sum / valid;
                Console.WriteLine($"Average score: {ave:F2}");
            }

            
            

           
            
        }
    }
}