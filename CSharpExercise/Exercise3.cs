using System;

namespace CSharpExercise
{
    public class Exercise3
    {
        public static void Main3()
        {
            Console.Write("Enter first Number : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second Number : ");
            int b= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a / b);
            Console.ReadKey();
        }
    }
}
