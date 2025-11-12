using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    internal class Operator
    {
        // Method to perform addition of two integers
        public int Add(int x, int y)
        {
            int result = x + y;
            return result;
        }

        // Method to perform subtraction
        public int Subtract(int x, int y)
        {
            int difference = x - y;
            return difference;
        }

        // Method to perform multiplication
        public int Multiply(int x, int y)
        {
            int product = x * y;
            return product;
        }

        // Method to perform division and return decimal result
        public double Divide(int x, int y)
        {
            if (y == 0)
            {
                Console.WriteLine("Cannot divide by zero!");
                return 0;
            }
            double quotient = (double)x / (double)y;
            return quotient;
        }

        // Method to check if a number is odd or even
        public string OddEvenFinder(int num)
        {
            if (num % 2 == 0)
            {
                return "Even";
            }
            else
            {
                return "Odd";
            }
        }
    }