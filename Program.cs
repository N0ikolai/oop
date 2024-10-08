namespace ConsoleApp1
{
    internal class Program
    {

        public static int Fibonacci(int n)
        {
            if (n <= 0)
            {
                throw new ArgumentException("n must be naturel number");
            }

            if (n == 1 || n == 2)
            {
                return 1;
            }

            return Fibonacci(n - 1) + Fibonacci(n-2);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the num Fibonacci");
            int n = Convert.ToInt32(Console.ReadLine());

            try
            {
                int result = Fibonacci(n);
                Console.WriteLine($"The Fibonacci number is {n} equals : {result}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}
