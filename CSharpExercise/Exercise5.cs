using System;

namespace CSharpExercise
{
    public class Exercise5
    {
        public static void Main5()
        {
            Console.Write("Enter first number : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number : ");
            int b = Convert.ToInt32(Console.ReadLine());
            int temp = b;
            b = a;
            a = temp;
            Console.WriteLine("First Number : " + a);
            Console.WriteLine("Second Number : " + b);
            Console.ReadKey();
        }
    }
}
