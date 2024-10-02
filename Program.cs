namespace ConsoleApp1
{
    internal class Program
    {
        static (int, int) Swap(int a, int b)
        {
            return (b, a);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter first num");
            int firstNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second num");
            int secondNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Before swapped : firstNum = {firstNum}, secondNum = {secondNum}");
            (firstNum, secondNum) = Swap(firstNum, secondNum);

            Console.WriteLine($"After swapped : firstNum = {firstNum}, secondNum = {secondNum}");

        }
    }
}



