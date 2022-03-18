using System;
using System.Text.RegularExpressions;

namespace PreDefienedMobileFormat
{
    internal class Program
    {
        static void Main(string[] args)
        {
          

            Console.WriteLine("Enter Mobile Number");

            string mobileNo = Console.ReadLine();


            if (Regex.Match(mobileNo, @"^([0-9]{2})\s([0-9]{10})$").Success)
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
