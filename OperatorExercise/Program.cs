using System;

namespace OperatorExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;

            int sum = a + b;
            int subtract = a - b;
            int product = a * b; 
            int quotient = a / b;
            int remainder = a % b;

            Console.WriteLine($"{a} + {b} is {sum}");
            Console.WriteLine($"{a} - {b} is {subtract}");
            Console.WriteLine($"{a} * {b} is {product}");
            Console.WriteLine($"{a} / {b} is {quotient} remainder {remainder}");




        }
    }
}
