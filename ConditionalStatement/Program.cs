/*
Name: Amanda Blakley
Date: 1/29/2020
Assignment: Deliberable 2: Conditional Statement 
Description: this C# console application code demonstrates the use 
             of conditional statements after getting input from the user.
*/

using System;

namespace ConditionalStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user foto input an integer value for a conditional statement
            Console.WriteLine("What grade do you expect to receive in ISM4300? Please enter digits only...");
            {
                // Use a try-catch block to help handle errors
                try
                {
                    // Create a variable for the value used in the statement
                    string input = Console.ReadLine();

                    // TNamed value as a grade and parsed the value 
                    decimal grades = decimal.Parse(input);

                    // An IF/ELSE/IF statement that handles the conditions for the users' letter grade

                    if (grades >= 98 && grades <= 100)
                    {
                        Console.WriteLine("Your grade is an A+!");
                    }
                    else if (grades >= 92 && grades <= 97)
                    {
                        Console.WriteLine("Your grade is an A!");
                    }
                    else if (grades >= 90 && grades <= 91)
                    {
                        Console.WriteLine("Your grade is an A-!");
                    }
                    else if (grades >= 88 && grades <= 89)
                    {
                        Console.WriteLine("Your grade is a B+!");

                    }
                    else if (grades >= 82 && grades <= 87)
                    {
                        Console.WriteLine("Your grade is a B!");
                    }
                    else if (grades >= 80 && grades <= 81)
                    {
                        Console.WriteLine("Your grade is a B-!");
                    }
                    else if (grades >= 78 && grades <= 79)
                    {
                        Console.WriteLine("Your grade is a C+!");
                    }
                    else if (grades >= 72 && grades <= 77)
                    {
                        Console.WriteLine("Your grade is a C!");
                    }
                    else if (grades >= 70 && grades <= 71)
                    {
                        Console.WriteLine("Your grade is a C-!");
                    }
                    else if (grades >= 68 && grades <= 69)
                    {
                        Console.WriteLine("Your grade is a D+!");
                    }
                    else if (grades >= 62 && grades <= 67)
                    {
                        Console.WriteLine("Your grade is a D!");
                    }
                    else if (grades >= 60 && grades <= 61)
                    {
                        Console.WriteLine("Your grade is a D-!");
                    }
                    else if (grades < 60)
                    {
                        Console.WriteLine("I'm sorry! You have failed the course...");

                    }
                    Console.WriteLine("Press any key to exit the program...");
                    Console.ReadKey(true);
                }
                catch 
                {
                    Console.WriteLine("Please enter an integer value and try running the program again...");
                    Console.WriteLine("Press any key to exit the program...");
                    Console.ReadKey(true);
                }
            }
        }
    }
}
