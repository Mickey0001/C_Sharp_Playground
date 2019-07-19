using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var grades = new List<double>() { 11.3, 35.2, 19.5 };
            grades.Add(15.5);

            var result = 0.0;
            foreach(var number in grades)
            {
                result += number;
            }

            result /= grades.Count;
            Console.WriteLine($"The average grade is {result:N1}");

            if(args.Length > 0)
            {
               Console.WriteLine($"{args[0]} is the best ");
            }
            else 
            {
                Console.WriteLine("Meh");
            }
        }
    }
}
