using System;

namespace MathOperations
{
    // Define a class named "MathClass"
    class MathClass
    {
        // Create a void method that takes two integers as parameters
        public void PerformOperation(int num1, int num2)
        {
            // Perform a math operation (e.g., multiply num1 by 2)
            int result = num1 * 2;
            
            // Display the second integer to the screen
            Console.WriteLine($"The result of the operation on {num1} is: {result}");
            Console.WriteLine($"The second number is: {num2}");
        }
    }

    class Program
    {
        static void Main()
        {
            // Instantiate the MathClass
            MathClass mathObj = new MathClass();

            // Call the method by passing two numbers
            mathObj.PerformOperation(5, 10);

            // Call the method using named parameters
            mathObj.PerformOperation(num1: 7, num2: 15);

            // Keep the console window open
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
