using System;

using System.Text.RegularExpressions;

namespace RegexPracticeProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            Console.WriteLine("Enter Email");

            string email = Console.ReadLine();


            if (Regex.Match(email, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$").Success)
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
