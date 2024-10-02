namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TempAnaliz tempAnaliz = new TempAnaliz();

            tempAnaliz.InputMonthlyTemp();

            double yearAvrage = tempAnaliz.Culc();

            Console.WriteLine("$ Temp of the year {yearAvrage: C }");

            double[,] dailyTemp = tempAnaliz.GenDailyTemp();

            double[] monthlyAverage = tempAnaliz.CalculateMonthlyAverages(dailyTemp);

            Array.Sort(monthlyAverage);

            Console.WriteLine("Average temp in mounth :");

            foreach (var avg in monthlyAverage)
            {
                Console.WriteLine($"{avg:F2}C");
            }
        }
    }
}
