using System;

namespace CS
{
    public class Program
    {
        public static void Main()
        {
            string[] words = {"flower", "flow", "flight"};
            Console.WriteLine(LongestCommonPrefix.LCP(words));
        }
    }   
}
