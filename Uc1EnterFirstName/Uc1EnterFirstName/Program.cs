using System;
using System.Text.RegularExpressions;

namespace RegexPracticeProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter first Name");

            string text = Console.ReadLine();

            if (Regex.Match(text, "^[A-Z][a-z]{1,4}$").Success)
            {
                Console.WriteLine("Success");
            }
            else
            {
                Console.WriteLine("Failed");
            }
        }
    }
}
