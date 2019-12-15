using System;

namespace Customer.Common
{
    public static class StringHandler
    {
     public static string InsertSpaces(this string source)
        {
            //Inset spaces before each capital letter in a string
            string result = string.Empty;

            if (!String.IsNullOrWhiteSpace(source))
            {
                foreach (char letter in source)
                {
                    if (char.IsUpper(letter))
                    {
                        result = result.Trim();
                        result += " ";
                    }
                    result += letter;
                }
            }
            result = result.Trim();
            return result;
        }
    }
}
