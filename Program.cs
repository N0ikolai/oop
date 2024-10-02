using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static int FindMax(int a, int b)
        {
            return (a > b) ? a : b; 
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter first num");
            int firstNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second num");
            int secondNum = Convert.ToInt32(Console.ReadLine());
           
            int maxNum = FindMax(firstNum, secondNum);
            
            Console.WriteLine($"Greatest num is {maxNum}");
        }
    }
}