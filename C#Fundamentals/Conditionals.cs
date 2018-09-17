using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decisions
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Mirza's Big Giweaway");
            Console.Write("Choose a door: 1, 2 or 3: ");
            string userValue = Console.ReadLine();

            string message = "";

            if (userValue == "1")
                message = "You won a unicorn!";
            else if (userValue == "2")
                message = "You won a sword!";
            else if (userValue == "3")
                message = "You won a castle!";
            else
            {
                message = "Please choose one of 3 available options. ";
                //message = message + "You lose!";
                message += "You lose.";
            }

            Console.WriteLine(message);
            Console.ReadLine();
            */

            Console.WriteLine("Mirza's Big Giweaway");
            Console.Write("Choose a door: 1, 2 or 3: ");
            string userValue = Console.ReadLine();

            string message = (userValue == "1") ? "boat" : "potato";
            //Console.Write("You won a ");
            //Console.Write(message);
            //Console.Write(".");
            //Console.WriteLine("You won a {0}.", message);
            Console.WriteLine("You entered: {0}, therefore you won a {1}", userValue, message);
            Console.ReadLine();

          
        }
    }
}
