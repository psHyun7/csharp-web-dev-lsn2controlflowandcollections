using System;
using System.Collections.Generic;
using System.Linq;

namespace ListExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numList = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int result = findSum(numList);
            Console.WriteLine(result);

            string lorem = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, " +
                "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. " +
                "Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. " +
                "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. " +
                "Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum";
            string[] loremArray = lorem.Split(" ");
            List<string> loremList = loremArray.ToList();
            findFiveLettered(loremList);

        }

        static int findSum(List<int> list)
        {
            int sum = 0;
            foreach (int num in list)
            {
                if (num % 2 == 0)
                {
                    sum += num;
                }
            }
            return sum;
        }

        static List<string> findFiveLettered( List<string> listOfWords )
        {
            List<string> fiveLettered = new List<string>();

            foreach (string word in listOfWords)
            {
                if (word.Length == 5)
                {
                    fiveLettered.Add(word);
                }
            }

            foreach (string word in fiveLettered)
            {
                System.Console.WriteLine(word);
            }
            return fiveLettered;
        }
    }
}
