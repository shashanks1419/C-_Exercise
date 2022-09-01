using System;

namespace CSharpExercise
{
    public class Exercise8
    {
        public static void Main8()
        {
            Console.Write("Enter a number : ");
            int a=Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{a} * {i} = {a * i}");
            }
            Console.ReadKey();
        }
    }
}
