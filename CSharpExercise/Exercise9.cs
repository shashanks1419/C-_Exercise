using System;

namespace CSharpExercise
{
    public class Exercise9
    {
        public static void Main9()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int d = Convert.ToInt32(Console.ReadLine());
            int avg = (a + b + c + d) / 4;
            Console.WriteLine($"The average of {a},{b},{c},{d} is {avg}");
            Console.ReadKey();

        }
    }
}
