namespace Question3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prompt user to enter their age
            Console.Write("Please enter your age: ");

            // Read and parse the input safely
            string? input = Console.ReadLine();
            if (int.TryParse(input, out int userAge))
            {
                // Determine age category using if-else statements
                if (userAge < 13)
                {
                    Console.WriteLine("You are a child.");
                }
                else if (userAge < 19)
                {
                    Console.WriteLine("You are a teenager.");
                }
                else
                {
                    Console.WriteLine("You are an adult.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
    }
}