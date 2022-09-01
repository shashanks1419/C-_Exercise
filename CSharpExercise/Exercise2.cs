using System;

namespace CSharpExercise
{
    public class Exercise2
    {
        public static void Main2()
        {
            Console.Write("Enter first number : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number : ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The sum is : "+(a + b));
            Console.ReadKey();
        }
    }
}
