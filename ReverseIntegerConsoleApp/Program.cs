using System;
using ReverseIntegerConsoleApp.Models;

namespace ReverseIntegerConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 123;
            int reversed = SuperInteger.Reverse(number);

            Console.WriteLine($"Reversed number is: {reversed}");
        }
    }
}
