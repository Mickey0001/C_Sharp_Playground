using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
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
