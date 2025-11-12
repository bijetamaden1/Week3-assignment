using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    internal class NullOperations
    {
        public void PerformNullChecks()
        {
            // Initialize a null string variable
            string userName = null;

            // Using ternary operator to check null
            string message = userName == null ? "Username is not available" : userName;
            Console.WriteLine(message);

            // Using null-coalescing operator
            string displayName = userName ?? "Username is not available";
            Console.WriteLine(displayName);

            // Using null-coalescing assignment operator
            userName ??= "Ram";

            // Display the updated value
            Console.WriteLine("Updated username: " + userName);
        }
    }
}