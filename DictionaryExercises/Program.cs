using System;
using System.Collections.Generic;

namespace DictionaryExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> students = new List<string>();
            List<int> ids = new List<int>();
            string newStudent;
            string input;

            Console.WriteLine("Enter your students (or ENTER to finish):");

            // Get student names
            do
            {
                input = Console.ReadLine();
                newStudent = input;

                if (!Equals(newStudent, ""))
                {
                    students.Add(newStudent);
                }

            } while (!Equals(newStudent, ""));

            // Get student grades
            foreach (string student in students)
            {
                Console.WriteLine("ID Number for " + student + ": ");
                input = Console.ReadLine();
                int id = int.Parse(input);
                ids.Add(id);
            }

            // Create Dictionary
            Dictionary<int, string> roster = new Dictionary<int, string>();
            for (int i = 0; i < students.Count; i++)
            {
                roster[ids[i]] = students[i];
            }

            // Print class roster
            Console.WriteLine("\nClass roster:");

            foreach (KeyValuePair<int, string> student in roster)
            {
                Console.WriteLine($"{student.Key}: {student.Value}");
            }
        }
    }
}
