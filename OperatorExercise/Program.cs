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

           
            
            
            Console.WriteLine();
            Console.WriteLine("what is the radius?");

           // var radius = double.Parse(Console.ReadLine());

          //  var radius = Convert.ToDouble(Console.ReadLine());


            const double PI = 3.14; 
            double radius; 
            bool repeat = false;
            do 
            { 
             repeat = double.TryParse(Console.ReadLine(), out radius);
        } while (!repeat);

            var areaOfCircle = Math.PI * Math.Pow(radius, 2);

            Console.WriteLine($"the area of your circle is {areaOfCircle}.");
        }
    }
}
