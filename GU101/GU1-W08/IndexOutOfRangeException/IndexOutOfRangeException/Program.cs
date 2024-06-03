using System;
using System.Collections.Generic;

namespace IndexOutOfRangeExceptionClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<char> characters = new List<char>();
                characters.InsertRange(0, new char[] { 'a', 'b', 'c', 'd', 'e', 'f' });
                int value = characters[6];


            }
            catch (IndexOutOfRangeException ex)
            {
                System.Console.WriteLine(ex);

            }
        }
    }
}
