using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            CalculateSumUsingForLoop();
            DisplayNumbersUsingWhile();
            CalculateArraySum();
        }

        // Method to calculate sum from 1 to n using for loop
        public static void CalculateSumUsingForLoop()
        {
            Console.Write("Enter a number: ");
            int number = ReadIntFromConsole();

            int total = 0;

            for (int counter = 1; counter <= number; counter++)
            {
                total += counter;
            }
            Console.WriteLine("Sum from 1 to " + number + " is: " + total);
        }

        // Method using while loop with continue and break
        public static void DisplayNumbersUsingWhile()
        {
            Console.Write("Enter the starting number: ");
            int startNum = ReadIntFromConsole();

            while (startNum <= 20)
            {
                if (startNum % 4 == 0)
                {
                    startNum++;
                    continue;
                }

                if (startNum == 15)
                {
                    break;
                }

                Console.WriteLine(startNum);
                startNum++;
            }
        }

        // Method to calculate sum of array elements using foreach
        public static void CalculateArraySum()
        {
            Console.Write("Enter the size of the array: ");
            int arraySize = ReadIntFromConsole();

            int[] numbers = new int[arraySize];

            for (int index = 0; index < arraySize; index++)
            {
                Console.Write($"Enter element {index + 1}: ");
                numbers[index] = ReadIntFromConsole();
            }

            int arraySum = 0;
            foreach (int element in numbers)
            {
                arraySum += element;
            }

            Console.WriteLine("Sum of array elements: " + arraySum);
        }

        // Helper to safely read an int from Console.ReadLine() and avoid null being passed to int.Parse
        private static int ReadIntFromConsole()
        {
            while (true)
            {
                string? input = Console.ReadLine();
                if (input is null)
                {
                    Console.WriteLine("No input received. Exiting.");
                    Environment.Exit(1);
                }

                if (int.TryParse(input, out int value))
                {
                    return value;
                }

                Console.WriteLine("Invalid input. Please enter a valid integer:");
            }
        }
    }
