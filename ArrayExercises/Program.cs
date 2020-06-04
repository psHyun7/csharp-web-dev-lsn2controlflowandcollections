using System;

namespace ArrayExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayPractice = new int[] { 1, 1, 2, 3, 5, 8 };
            foreach (int element in arrayPractice)
            {
                if (element % 2 == 1)
                {
                    System.Console.WriteLine(element);
                }
            }
        }
    }
}
