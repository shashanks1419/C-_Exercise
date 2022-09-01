using System;

namespace CSharpExercise
{
    public class Exercise6
    {
        public static void Main6()
        {
            Console.Write("First number : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Second number : ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Third number : ");
            int c = Convert.ToInt32(Console.ReadLine());
            int product = a * b * c;
            Console.WriteLine($"{a}*{b}*{c}={product}");
            Console.ReadKey();
        }
    }
}
