using System;

namespace CSharpExercise
{
    public class Exercise10
    {
        public static void Main()
        {
            Console.WriteLine("Enter three number : ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Result of specified numbers {a}, {b} and {c}, (x+y).z is {(a + b) * c} and x.y + y.z is {a * b + b * c}");
            Console.ReadKey();
        }
    }
}
