using System;
using System.Collections.Generic;

namespace Customer.Common
{
    public static class LogginService
    {
        public static void WriteToFile(List<ILoggable> itemsLog)
        {
            foreach (var item in itemsLog)
            {
               Console.WriteLine(item.Log());
            }
        }
    }
}
