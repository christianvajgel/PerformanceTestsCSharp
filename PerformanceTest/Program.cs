using System;
using System.Collections.Generic;
using System.Reflection.Metadata;


namespace PerformanceTest
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var numberBase = 245.758221;
            var numberExpoent = 10000;
            List<string> operations = new List<string> { "+", "-", "*", "/" };

            for (int power = 0; power <= numberExpoent; power++)
            {
                var result = Math.Pow(numberBase, power);
                Console.WriteLine($"{numberBase} ^ {power} = {Math.Pow(numberBase, power)}");
                var sqrtNumber = RandomNumber(1, 2000000);
                Console.WriteLine($"{result} sqrt = {Math.Sqrt(result)}");
                RandomCalculations(1, 5000000, operations);
                RandomCalculations(1, 40000000, operations);
                Console.WriteLine(Math.Sqrt(Math.PI));
                Random random = new Random();
                var dec = random.NextDouble();
                Console.WriteLine($"{dec} ˆ PI = {Math.Pow(dec, Math.PI)}");
                var dec2 = random.NextDouble();
                Console.WriteLine($"{dec2} sin = {Math.Sin(dec2)}");
            }
        }

        public static int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        public static void RandomCalculations(int min, int max, List<string> operations)
        {
            var n1 = RandomNumber(min, max);
            var n2 = RandomNumber(min, max);
            var operation = operations[RandomNumber(0, 3)];
            Console.WriteLine($"{n1} {operation} {n2} = {RandomOperation(n1, n2, operation)}");
        }

        public static decimal RandomOperation(int number1, int number2, string operation)
        {
            int v = operation switch
            {
                "+" => number1 + number2,
                "-" => number1 - number2,
                "*" => number1 * number2,
                "/" => number1 / number2,
                _ => 0,
            };
            return v;
        }
    }
}
