using System;
using System.Collections.Generic;
using System.Text;

namespace Customer.Common
{
    public static class LogginService
    {
        public static void WriteToFile(List<Object> itemsLog)
        {
            foreach (var item in itemsLog)
            {
               // Console.WriteLine(item.Log());
            }
        }
    }
}
