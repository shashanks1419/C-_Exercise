using System;

namespace CSharpExercise
{
    public class Exercise7
    {
        public static void Main7()
        {
            Console.Write("First number : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Second number : ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{a} + {b} = {a + b}");
            Console.WriteLine($"{a} - {b} = {a - b}");
            Console.WriteLine($"{a} * {b} = {a * b}");
            Console.WriteLine($"{a} / {b} = {a / b}");
            Console.WriteLine($"{a} mod {b} = {a % b}");
            Console.ReadKey();
        }
    }
}
