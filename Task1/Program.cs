
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the Operator class
            Operator calculator = new Operator();

            // Define two numbers for testing
            int firstNumber = 5;
            int secondNumber = 3;

            // Perform and display addition
            int additionResult = calculator.Add(firstNumber, secondNumber);
            Console.WriteLine("Addition: " + additionResult);

            // Perform and display subtraction
            int subtractionResult = calculator.Subtract(firstNumber, secondNumber);
            Console.WriteLine("Subtraction: " + subtractionResult);

            // Perform and display multiplication
            int multiplicationResult = calculator.Multiply(firstNumber, secondNumber);
            Console.WriteLine("Multiplication: " + multiplicationResult);

            // Perform and display division
            double divisionResult = calculator.Divide(firstNumber, secondNumber);
            Console.WriteLine("Division: " + divisionResult);

            // Check if number is odd or even
            string checkResult = calculator.OddEvenFinder(firstNumber);
            Console.WriteLine("Odd/Even: " + checkResult);
        }
    }
