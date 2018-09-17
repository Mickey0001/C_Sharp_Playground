using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;

namespace AsembliesAndNamespaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //string text = "Ameleeee, " +
                         //  "a class defines the data and behavior of the data type. ";
           //File.WriteAllText(@"C:\Users\Public\WriteText.txt", text);

            WebClient client = new WebClient();
            string reply = client.DownloadString("https://msdn.microsoft.com");

            Console.WriteLine(reply);
            File.WriteAllText(@"C:\Users\Public\WriteText.txt", reply);
            Console.ReadLine();
        }
    }
}
