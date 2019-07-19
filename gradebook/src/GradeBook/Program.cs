using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
           var numbers = new[] { 12.3, 13.2, 14.5 };

            var result = numbers[0] + numbers[1] + numbers[2];
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
