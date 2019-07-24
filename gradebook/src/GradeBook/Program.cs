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
            book.AddGrade(75.1);

            var statics = book.GetStatistics();
            Console.WriteLine($"The lowest grade is {statics.Low}");
            Console.WriteLine($"The highest grade is {statics.High}");
            Console.WriteLine($"The average grade is {statics:N1}");
        }
    }
}
