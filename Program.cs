namespace ConsoleApp1
{
    internal class Program
    {
        public static int CulcGCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        public static int CultGCD(int a, int b, int c)
        {
            return CulcGCD(CulcGCD(a, b), c);
        }

        public static void ReadInputGCD(int a, int b, int c)
        {
            Console.WriteLine("Enter first num");
            a = Convert.ToInt32(Console.ReadLine);

            Console.WriteLine("Enter second num");
            b = Convert.ToInt32(Console.ReadLine);

            Console.WriteLine("Enter thrid num");
            c = Convert.ToInt32(Console.ReadLine);
        }

        public static void ShowResult(int twoGCD, int threeGCD)
        {
            Console.WriteLine($"The result : {twoGCD}");
            Console.WriteLine($"The result : {threeGCD}");
        }

        static void Main(string[] args)
        {
            ReadInputGCD(out int num1, out int num2, out int num3,);

            int twoGCD = CulcGCD(num1, num2);
            int threeGCD = CultGCD(num1, num2, num3);

            ShowResult(twoGCD, threeGCD);

        }
    }
}
