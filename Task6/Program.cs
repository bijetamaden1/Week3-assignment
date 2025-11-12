using System;

namespace Question6
{

    class Program
    {
        static void Main()
        {
            // Part 1: Exception handling for number input
            try
            {
                Console.Write("Please enter a number: ");
                string? userInput = Console.ReadLine();
                if (userInput == null)
                {
                    Console.WriteLine("No input provided.");
                }
                else
                {
                    int num = int.Parse(userInput);
                    Console.WriteLine("You entered: " + num);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number format");
            }
            finally
            {
                Console.WriteLine("Program Executed");
            }

            Console.WriteLine();

            // Part 2: Custom exception for password validation
            Console.Write("Enter password: ");
            string? pwd = Console.ReadLine();

            try
            {
                if (pwd == null || pwd.Length < 6)
                {
                    throw new Exception("Password must be at least 6 characters.");
                }

                Console.WriteLine("Password satisfied the requirement");
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
        }
    }

}