using System;
using System.Collections.Generic;

namespace GradeBook
{

    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Mirzaki Gradebookie");
            book.AddGrade(88.1);
            book.AddGrade(90.5);
            book.grades.Add(101);

            var grades = new List<double>() { 11.3, 35.2, 19.5 };
            grades.Add(15.5);

            var result = 0.0;
            foreach(var number in grades)
            {
                result += number;
            }

            result /= grades.Count;
            Console.WriteLine($"The average grade is {result:N1}");
        }
    }
}
