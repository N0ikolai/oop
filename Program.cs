namespace ConsoleApp1
{
    internal class Program
    {
        static bool CalculateFactorial(int n, out long result)
        {
            result = 1;

            if (n < 0)
            {
                return false; 
            }

            try
            {
                for (int i = 1; i <= n; i++)
                {
                    checked 
                    {
                        result *= i;
                    }
                }
                return true; 
            }
            catch (OverflowException)
            {
                return false;
            }
        }

        static void CheckFactorialOrNot()
        {
            Console.Write("Enter a number to calculate its factorial: ");
            string input = Console.ReadLine();
            int num;

            if (int.TryParse(input, out num))
            {
                long factorialResult;
                bool isSuccess = CalculateFactorial(num, out factorialResult);

                if (isSuccess)
                {
                    Console.WriteLine($"Factorial of {num} is {factorialResult}.");
                }
                else
                {
                    Console.WriteLine("Overflow occurred while calculating the factorial.");
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid integer.");
            }
        }


        static void Main(string[] args)
        {
            CheckFactorialOrNot();


        }
    }
}
