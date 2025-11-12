using System;


    internal class Program
    {
        static void Main(string[] args)
        {
            // Ask user for input
            Console.Write("Enter a number between 1 and 7: ");
            string? input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Invalid input! Please enter a number between 1 and 7.");
                return;
            }

            int dayNumber;
            if (!int.TryParse(input, out dayNumber))
            {
                Console.WriteLine("Invalid input! Please enter a valid number.");
                return;
            }

            // Use switch statement to determine the day
            switch (dayNumber)
            {
                case 1:
                    Console.WriteLine("Sunday");
                    break;
                case 2:
                    Console.WriteLine("Monday");
                    break;
                case 3:
                    Console.WriteLine("Tuesday");
                    break;
                case 4:
                    Console.WriteLine("Wednesday");
                    break;
                case 5:
                    Console.WriteLine("Thursday");
                    break;
                case 6:
                    Console.WriteLine("Friday");
                    break;
                case 7:
                    Console.WriteLine("Saturday");
                    break;
                default:
                    Console.WriteLine("Invalid input! Please enter a number between 1 and 7.");
                    break;
            }
        }
    }
