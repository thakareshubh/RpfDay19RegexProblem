﻿using System;

using System.Text.RegularExpressions;

namespace PasswordWithOnenumericNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            Console.WriteLine("Enter Password");

            string password = Console.ReadLine();


            if (Regex.Match(password, @"^([a-z]{5})([@]{1})([A-Z]{1})([0-9]{1})$").Success)
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