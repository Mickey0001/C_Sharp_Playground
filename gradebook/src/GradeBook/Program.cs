using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
           var numbers = new[] { 12.3, 17.2, 14.5 };

            var result = 0.0;

            foreach(var number in numbers)
            {
                result += number;
            }

            Console.WriteLine(result);

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
